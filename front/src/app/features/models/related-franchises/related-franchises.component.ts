import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { FranchiseLight } from '../../../interfaces/franchise';
import { ModelFull } from '../../../interfaces/model';
import { ActiveEntity } from '../../../enumerations/gallery-mode';
import { MoodsGalleryService } from '../../../services/moods-gallery.service';

@Component({
  selector: 'app-related-franchises',
  templateUrl: './related-franchises.component.html',
  styleUrl: './related-franchises.component.scss'
})
export class RelatedFranchisesComponent {
  @Input() model: ModelFull | undefined = undefined
  @Input() franchises: FranchiseLight[] = []
  @Input() franchiseId: number | undefined = undefined

  @Output() setFranchise = new EventEmitter<number>()
  @Output() switchToFranchise = new EventEmitter<number>()
  @Output() switchToModel = new EventEmitter<number>()

  #moodsGalleryService = inject(MoodsGalleryService)

  public activeEntities = ActiveEntity
  public activeEntity = this.#moodsGalleryService.activeEntity

  public handleSetFranchise(franchiseId: number): void {
    this.setFranchise.emit(franchiseId)
  }

  public handleSwitchToFranchise(franchiseId: number): void {
    this.switchToFranchise.emit(franchiseId)
  }

  public handleSwitchToModel(): void {
    this.switchToModel.emit(this.model?.businessId)
  }
}