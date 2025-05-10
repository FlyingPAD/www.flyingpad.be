import { Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core'
import { MoodService } from '../../services/http/mood.service'
import { Subject, takeUntil } from 'rxjs'
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { Router } from '@angular/router'
import { YouTubeVideoCreateForm } from '../../interfaces/http/forms-create'

@Component({
  selector: 'app-create-mood-video-youtube',
  templateUrl: './create-mood-video-youtube.component.html',
  styleUrls: ['./create-mood-video-youtube.component.scss']
})
export class CreateMoodVideoYoutubeComponent implements OnInit, OnDestroy {
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

  public createYoutubeVideo(): void {
    if (this.formGroup.invalid) {
      this.formGroup.markAllAsTouched()
      return
    }

    const form: YouTubeVideoCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
      url: this.formGroup.value.url
    }

    this.moodService.createYouTubeVideo(form)
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
        this.createYoutubeVideo()
        break
    }
  }
}