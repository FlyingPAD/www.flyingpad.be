import { Component, inject } from '@angular/core';
import { FranchiseStateService } from '../../../core/services/franchise.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent 
{
  franchiseService = inject(FranchiseStateService)

  franchisesFlow = this.franchiseService.franchises

  mpp : number = 36
  p : number = 1

  updateFranchiseId( franchiseId : number )
  {
    
  }
}
