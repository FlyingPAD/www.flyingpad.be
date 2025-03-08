import { Component, Input, OnDestroy, OnInit, Output, EventEmitter, inject } from '@angular/core'
import { Subscription } from 'rxjs'
import { FlowService } from '../../../services/http/flow.service'
import { MoodFull } from '../../../interfaces/mood'
import { ModelCheckBox } from '../../../interfaces/model'

@Component({
  selector: 'app-edit-mood-models',
  templateUrl: './edit-mood-models.component.html',
  styleUrls: ['./edit-mood-models.component.scss']
})
export class EditMoodModelsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)

  @Input() mood!: MoodFull
  @Output() modelsSelected = new EventEmitter<number[]>()

  #subscription = new Subscription()

  public models: ModelCheckBox[] = []
  public input: string = ''

  ngOnInit(): void {
    this.#subscription = this.#flowService.getModelsCheckBoxByMood(this.mood.businessId).subscribe({
      next: (data) => {
        this.models = data
        this.emitSelectedModels()
      }
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
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