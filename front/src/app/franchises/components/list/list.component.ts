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

  updateFranchiseId( franchiseId : number )
  {
    
  }
}
