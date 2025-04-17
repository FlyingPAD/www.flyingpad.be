import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ModelLight } from '../../../interfaces/model';
import { FranchiseFull } from '../../../interfaces/franchise';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { ActiveEntity } from '../../../enumerations/gallery-mode';

@Component({
  selector: 'app-related-models',
  templateUrl: './related-models.component.html',
  styleUrl: './related-models.component.scss'
})
export class RelatedModelsComponent {
  @Input() franchise: FranchiseFull | undefined = undefined
  @Input() models: ModelLight[] = []
  @Input() modelId: number | undefined = undefined

  @Output() setModel = new EventEmitter<number>()
  @Output() switchToModel = new EventEmitter<number>()
  @Output() switchToFranchise = new EventEmitter<number>()

  #moodsGalleryService = inject(MoodsGalleryService)

  public activeEntities = ActiveEntity
  public activeEntity = this.#moodsGalleryService.activeEntity


  public handleSetModel(modelId: number): void {
    this.setModel.emit(modelId)
  }
  
  public handleSwitchToModel(modelId: number): void {
    this.switchToModel.emit(modelId)
  }

  public handleSwitchToFranchise(): void {
    this.switchToFranchise.emit(this.franchise?.businessId)
  }
}