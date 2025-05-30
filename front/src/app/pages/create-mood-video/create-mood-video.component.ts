// src/app/components/create-mood-video/create-mood-video.component.ts
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MoodService } from '../../services/http/mood.service';
import { VideoCreateForm } from '../../interfaces/http/forms-create';

@Component({
  selector: 'app-create-mood-video',
  templateUrl: './create-mood-video.component.html',
  styleUrls: ['./create-mood-video.component.scss']
})
export class CreateMoodVideoComponent implements OnInit {
  private fb = inject(FormBuilder);
  private moodService = inject(MoodService);
  private router = inject(Router);

  form!: FormGroup;

  // Ces propriétés sont utilisées par votre template
  public url!: string;
  public size!: number;
  public extension!: string;
  public width!: number;
  public height!: number;
  public duration!: number;

  // On ne stocke plus que le File brut
  private file!: File;

  ngOnInit(): void {
    this.form = this.fb.group({
      name:        ['...', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['...50_000_000', [Validators.required, Validators.minLength(1), Validators.maxLength(500)]]
    });
  }

  loadFile(event: Event): void {
    const input = (event.target as HTMLInputElement);
    if (!input.files?.length) {
      return;
    }

    this.file      = input.files[0];
    this.size      = this.file.size;
    this.extension = this.file.type.split('/')[1] ?? '';

    // Valider le format et la taille
    if (!['mp4', 'webm'].includes(this.extension) || this.size > 50_000_000) {
      alert('Format non supporté (MP4/WEBM) ou fichier trop volumineux (> 50 Mo).');
      this.url = '';
      return;
    }

    // Générer l’aperçu en base64
    const reader = new FileReader();
    reader.onload = (e: any) => {
      this.url = e.target.result as string;
    };
    reader.readAsDataURL(this.file);

    // Récupérer les métadonnées vidéo
    const videoEl = document.createElement('video');
    videoEl.src = URL.createObjectURL(this.file);
    videoEl.onloadedmetadata = (e: any) => {
      this.width    = e.target.videoWidth;
      this.height   = e.target.videoHeight;
      this.duration = Math.floor(e.target.duration);
      URL.revokeObjectURL(videoEl.src);
    };
  }

  onSubmit(): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }

    // Construction de l’objet typé à envoyer
    const payload: VideoCreateForm = {
      name:        this.form.value.name,
      description: this.form.value.description,
      size:        this.size,
      extension:   this.extension,
      height:      this.height,
      width:       this.width,
      duration:    this.duration,
      sourceFile:  this.url
    };

    this.moodService.createVideo(payload).subscribe({
      next: () => {
        this.router.navigateByUrl('/central-gallery');
      },
      error: err => {
        console.error(err);
        alert('Une erreur est survenue lors de l’upload.');
      }
    });
  }
}