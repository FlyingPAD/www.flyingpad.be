import { Component, HostListener, inject, OnDestroy } from '@angular/core';
import { MoodScoreUpdate, MoodUpdateForm } from '../../interfaces/http/forms-update';
import { Subject, takeUntil } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RelationsMoodArtistForm, RelationsMoodModelForm, RelationsMoodTagForm } from '../../interfaces/http/relations';
import { RelationsService } from '../../services/http/relations.service';
import { MoodService } from '../../services/http/mood.service';
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service';
import { EditMoodViewMode } from '../../enumerations/view-modes-edition';
import { Router } from '@angular/router';
import { GalleryType } from '../../enumerations/gallery-type';
import { DialogService } from '../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-mood',
  templateUrl: './edit-mood.component.html',
  styleUrl: './edit-mood.component.scss'
})

export class EditMoodComponent implements OnDestroy {
  #moodService = inject(MoodService)
  #relationService = inject(RelationsService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)
  #router = inject(Router)

  #destroy$ = new Subject<void>()

  public moodsFlow = this.#moodService.moodsFlow

  public viewMode = this.#moodsGalleryService.editMoodViewMode
  public viewModes = EditMoodViewMode

  public selectedArtistIds: number[] = []
  public selectedModelIds: number[] = []
  public selectedTagIds: number[] = []

  public formGroup: FormGroup = this.#formBuilder.group({
    name: [this.moodsFlow()?.mood.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: [this.moodsFlow()?.mood.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public backToGallery(): void { this.#router.navigateByUrl('/central-gallery') }
  public toggleDialog(): void { this.#dialogService.toggleDialog() }

  public onSave(): void {
    if (this.viewMode() === EditMoodViewMode.InfoView) this.updateMoodInfo()
    else if (this.viewMode() === EditMoodViewMode.ArtistsView) this.saveMoodArtists()
    else if (this.viewMode() === EditMoodViewMode.ModelsView) this.saveMoodModels()
    else if (this.viewMode() === EditMoodViewMode.TagsView) this.saveMoodTags()
  }

  public updateMoodInfo(): void {
    const form: MoodUpdateForm = {
      moodId: this.moodsFlow()?.mood.businessId,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description
    }

    if (this.formGroup.valid) {
      this.#moodService.updateMood(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe()
    }
  }

  public updateMoodScore(scoreValue: number): void {
    let form: MoodScoreUpdate = { moodId: this.moodsFlow()?.mood.businessId, value: scoreValue }
    this.#moodService.updateMoodScore(form)
      .pipe(takeUntil(this.#destroy$))
      .subscribe()
  }

  public saveMoodArtists(): void {
    const payload: RelationsMoodArtistForm = {
      moodId: this.moodsFlow()?.mood.businessId,
      artistIds: this.selectedArtistIds
    }

    if (payload.artistIds.length === 0) {
      console.warn('No artists selected.')
      return
    }

    this.#relationService.InsertRMA(payload)
      .pipe(takeUntil(this.#destroy$))
      .subscribe()
  }

  public saveMoodModels(): void {
    const payload: RelationsMoodModelForm = {
      moodId: this.moodsFlow()?.mood.businessId,
      modelIds: this.selectedModelIds
    }

    if (payload.modelIds.length === 0) {
      console.warn('No models selected.')
      return
    }

    this.#relationService.InsertRMM(payload)
      .pipe(takeUntil(this.#destroy$))
      .subscribe()
  }

  public saveMoodTags(): void {
    const payload: RelationsMoodTagForm = {
      moodId: this.moodsFlow()?.mood.businessId,
      tagIds: this.selectedTagIds
    }

    if (payload.tagIds.length === 0) {
      console.warn('No tags selected.')
      return
    }

    this.#relationService.InsertRMT(payload)
      .pipe(takeUntil(this.#destroy$))
      .subscribe()
  }

  public deleteMood(): void {
    this.#moodService.deleteMood(this.moodsFlow()?.mood.businessId).subscribe(response => {
      if (response.success) {
        this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
        this.#moodsGalleryService.setEditMoodViewMode(EditMoodViewMode.InfoView)
        this.toggleDialog()
        this.backToGallery()
      }
    })
  }

  public handleArtistsSelected(artistIds: number[]): void {
    this.selectedArtistIds = artistIds
  }
  public handleModelsSelected(modelIds: number[]): void {
    this.selectedModelIds = modelIds
  }
  public handleTagsSelected(tagIds: number[]): void {
    this.selectedTagIds = tagIds
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onSave()
        break
    }
  }
}