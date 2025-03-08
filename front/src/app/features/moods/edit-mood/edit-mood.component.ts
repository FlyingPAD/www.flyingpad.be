import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { FlowService } from '../../../services/http/flow.service';
import { MoodUpdateForm } from '../../../interfaces/forms-update';
import { Subscription } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RelationsMoodArtistForm, RelationsMoodModelForm, RelationsMoodTagForm } from '../../../interfaces/relations';
import { MoodsService } from '../../../services/moods.service';
import { MoodService } from '../../../services/http/mood.service';

@Component({
  selector: 'app-edit-mood',
  templateUrl: './edit-mood.component.html',
  styleUrl: './edit-mood.component.scss'
})
export class EditMoodComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #moodService = inject(MoodService)
  #moodsService = inject(MoodsService)
  #formBuilder = inject(FormBuilder)

  @Input() mood!: MoodFull
  @Input() environment!: string
  @Output() showDetails = new EventEmitter<void>()
  @Output() showGallery = new EventEmitter<void>()

  #infoSubscription: Subscription = new Subscription()
  #tagSubscription: Subscription = new Subscription()
  #artistSubscription: Subscription = new Subscription()
  #modelSubscription: Subscription = new Subscription()

  public editMoodMenuState = this.#moodsService.editMoodMenuState

  public selectedArtistIds: number[] = []
  public selectedModelIds: number[] = []
  public selectedTagIds: number[] = []

  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnInit(): void {
    this.formGroup.patchValue({
      name: this.mood.name,
      description: this.mood.description
    })
  }

  ngOnDestroy(): void {
    this.#infoSubscription.unsubscribe()
    this.#tagSubscription.unsubscribe()
    this.#artistSubscription.unsubscribe()
    this.#modelSubscription.unsubscribe()
  }
  public toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  public handleEditMoodMenuState(state: string): void {
    this.#moodsService.updateEditMoodMenuState(state)
  }

  public handleShowDetails(): void {
    this.showDetails.emit()
  }
  public handleShowGallery(): void {
    this.showGallery.emit()
  }

  public handleOverlay(): boolean {
    return this.editMoodMenuState() === 'delete'
  }

  public onSave(): void {
    if (this.editMoodMenuState() === 'info') {
      this.updateMoodInfo()
    }
    else if (this.editMoodMenuState() === 'artists') {
      this.saveMoodArtists()
    }
    else if (this.editMoodMenuState() === 'models') {
      this.saveMoodModels()
    }
    else if (this.editMoodMenuState() === 'tags') {
      this.saveMoodTags()
    }
  }

  public updateMoodInfo(): void {
    const form: MoodUpdateForm = {
      moodId: this.mood.businessId,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description
    }

    if (this.formGroup.valid) {
      this.#infoSubscription = this.#moodService.updateMood(form).subscribe()
    }
  }

  public saveMoodArtists(): void {
    const payload: RelationsMoodArtistForm = {
      moodId: this.mood.businessId,
      artistIds: this.selectedArtistIds
    }

    if (payload.artistIds.length === 0) {
      console.warn('No artists selected.')
      return
    }

    this.#artistSubscription = this.#flowService.InsertRMA(payload).subscribe()
  }

  public saveMoodModels(): void {
    const payload: RelationsMoodModelForm = {
      moodId: this.mood.businessId,
      modelIds: this.selectedModelIds
    }

    if (payload.modelIds.length === 0) {
      console.warn('No models selected.')
      return
    }

    this.#modelSubscription = this.#flowService.InsertRMM(payload).subscribe()
  }

  public saveMoodTags(): void {
    const payload: RelationsMoodTagForm = {
      moodId: this.mood.businessId,
      tagIds: this.selectedTagIds
    }

    if (payload.tagIds.length === 0) {
      console.warn('No tags selected.')
      return
    }

    this.#tagSubscription = this.#flowService.InsertRMT(payload).subscribe()
  }

  public deleteMood(): void {
    this.#moodService.deleteMood(this.mood.businessId).subscribe(response => {
      if (response.success) {
        this.showGallery.emit()
        this.#moodsService.updateEditMoodMenuState('info')
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
      case 'Backspace':
        this.showDetails.emit()
        break
    }
  }
}