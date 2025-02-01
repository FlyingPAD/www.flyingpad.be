import { Component, inject, OnInit } from '@angular/core';
import { RelationsMoodModelForm } from '../../../interfaces/relations';
import { MultiTagService } from '../../../services/multi-tag.service';
import { FlowService } from '../../../services/flow.service';
import { MoodsService } from '../../../services/moods.service';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ModelCheckBox } from '../../../interfaces/model';

@Component({
  selector: 'app-multi-tag-models',
  templateUrl: './multi-tag-models.component.html',
  styleUrl: './multi-tag-models.component.scss'
})
export class MultiTagModelsComponent implements OnInit {
  #flowService = inject(FlowService)
  #multiTagService = inject(MultiTagService)
  #moodsService = inject(MoodsService)
  #formBuilder = inject(FormBuilder)
  #router = inject(Router)

  public selectedMoods = this.#multiTagService.selectedMoods
  public models = this.#multiTagService.models
  public searchModel : string = ''
  public form!: FormGroup

  ngOnInit(): void {
    const controlsConfig = this.models().reduce((config, model) => {
      config[model.businessId.toString()] = [false]
      return config
    }, {} as { [key: string]: any })

    this.form = this.#formBuilder.group(controlsConfig)
  }

  get filteredModels(): ModelCheckBox[] {
    return this.models().filter(model =>
      model.pseudonym.toLowerCase().includes(this.searchModel.toLowerCase())
    )
  }
  
  public onSubmit(): void {
    const selectedModelIds: number[] = this.models()
      .filter(model => this.form.get(model.businessId.toString())?.value)
      .map(model => model.businessId)

    const relationsForm: RelationsMoodModelForm = {
      moodId: 0,
      modelIds: selectedModelIds
    }

    this.selectedMoods().forEach(mood => {
      relationsForm.moodId = mood
      this.#flowService.InsertRMM(relationsForm).subscribe()
    })

    this.form.reset()
    this.#multiTagService.resetSelection()
    this.#moodsService.updateMoodMenuState('gallery')
    this.#router.navigateByUrl('moods')
  }
}