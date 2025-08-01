import { Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core'
import { FormBuilder, FormGroup } from '@angular/forms'
import { Router } from '@angular/router'
import { ModelCheckBox } from '../../interfaces/model'
import { RelationsMoodModelForm } from '../../interfaces/http/relations'
import { NotificationService } from '../../services/user-interface/notification.service'
import { RelationsService } from '../../services/http/relations.service'
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service'
import { GalleryType } from '../../enumerations/gallery-type'
import { ModelService } from '../../services/http/model.service'
import { Subject, takeUntil } from 'rxjs'
import { MoodManagerService } from '../../services/mood-manager.service'

@Component({
  selector: 'app-multi-tag-models',
  templateUrl: './multi-tag-models.component.html'
})
export class MultiTagModelsComponent implements OnInit, OnDestroy {
  #moodManagerService = inject(MoodManagerService)
  #modelService = inject(ModelService)
  #relationService = inject(RelationsService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)
  #formBuilder = inject(FormBuilder)
  #notificationService = inject(NotificationService)

  #destroy$ = new Subject<void>()

  public modelsFlow = this.#modelService.modelsFlow
  public selectedMoods = this.#moodManagerService.selectedMoods

  public searchModel = ''
  public form!: FormGroup


  ngOnInit(): void {
    const modelsData = this.mapModels()

    const controlsConfig = modelsData.reduce((config, model) => {
      config[model.businessId.toString()] = [false]
      return config
    }, {} as { [key: string]: any })
    this.form = this.#formBuilder.group(controlsConfig)
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private mapModels(): ModelCheckBox[] {
    return (this.modelsFlow()?.models ?? []).map(model => ({ ...model, isChecked: false }))
  }

  public filteredModels(): ModelCheckBox[] {
    return this.mapModels().filter(model => model.pseudonym.toLowerCase().includes(this.searchModel.toLowerCase()))
  }

  public onSubmit(): void {
    const models = this.modelsFlow()?.models ?? []
    const selectedModelIds = models.filter(model => this.form.get(model.businessId.toString())?.value)
      .map(model => model.businessId)

    if (selectedModelIds.length === 0) {
      this.#notificationService.warning('No models selected')
      return
    }
    const selectedMoodsList = this.selectedMoods() ?? []
    
    selectedMoodsList.forEach(mood => {
      const relationsForm: RelationsMoodModelForm = { moodId: mood, modelIds: selectedModelIds }
      this.#relationService.InsertRMM(relationsForm)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => {
          if (response.success) {
            this.form.reset()
            this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
            this.#router.navigateByUrl('/moods/mood-manager')
          }
        })
    })
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent): void {
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}