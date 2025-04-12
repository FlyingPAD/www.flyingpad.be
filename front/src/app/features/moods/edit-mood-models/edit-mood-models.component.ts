import { Component, Input, OnDestroy, OnInit, Output, EventEmitter, inject } from '@angular/core'
import { Subject, takeUntil } from 'rxjs'
import { MoodFull } from '../../../interfaces/mood'
import { ModelCheckBox } from '../../../interfaces/model'
import { MoodService } from '../../../services/http/mood.service'

@Component({
  selector: 'app-edit-mood-models',
  templateUrl: './edit-mood-models.component.html'
})
export class EditMoodModelsComponent implements OnInit, OnDestroy {
  #moodService = inject(MoodService)

  @Input() mood!: MoodFull
  @Output() modelsSelected = new EventEmitter<number[]>()

  #destroy$ = new Subject<void>()

  public models: ModelCheckBox[] = []
  public input: string = ''


  ngOnInit(): void {
    this.#moodService.getModelsCheckBoxesByMood(this.mood.businessId)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(data => {
        this.models = data
        this.emitSelectedModels()
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private emitSelectedModels() {
    const selectedIds = this.models
      .filter((m) => m.isChecked)
      .map((m) => m.businessId)
    this.modelsSelected.emit(selectedIds)
  }

  public filterModels() {
    return this.models.filter((model) =>
      model.pseudonym.toLowerCase().includes(this.input.toLowerCase())
    )
  }

  public onModelCheckChange(model: ModelCheckBox) {
    model.isChecked = !model.isChecked
    this.emitSelectedModels()
  }
}