import { Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { YouTubeVideoCreateForm } from '../../interfaces/http/forms-create';
import { MoodService } from '../../services/http/mood.service';

@Component({
  selector: 'app-create-mood-audio-soundcloud',
  templateUrl: './create-mood-audio-soundcloud.component.html',
  styleUrl: './create-mood-audio-soundcloud.component.scss'
})
export class CreateMoodAudioSoundcloudComponent implements OnInit, OnDestroy {
  private moodService = inject(MoodService)
  private fb = inject(FormBuilder)
  private router = inject(Router)

  private destroy$ = new Subject<void>()

  public formGroup!: FormGroup

  get name() { return this.formGroup.get('name') }
  get description() { return this.formGroup.get('description') }
  get url() { return this.formGroup.get('url') }


  ngOnInit(): void {
    this.formGroup = this.fb.group({
      name: ['', [Validators.required, Validators.maxLength(100)]],
      description: ['', [Validators.maxLength(300)]],
      url: ['', [Validators.required]]
    })
  }

  ngOnDestroy(): void {
    this.destroy$.next()
    this.destroy$.complete()
  }

  public createSoundCloudAudio(): void {
    if (this.formGroup.invalid) {
      this.formGroup.markAllAsTouched()
      return
    }

    const form: YouTubeVideoCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
      url: this.formGroup.value.url
    }

    this.moodService.createSoundCloudAudio(form)
      .pipe(takeUntil(this.destroy$))
      .subscribe(response => {
        if (response.success) {
          this.router.navigateByUrl('/central-gallery')
        }
      })
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createSoundCloudAudio()
        break
    }
  }
}