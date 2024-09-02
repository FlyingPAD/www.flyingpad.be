import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PaginationService 
{
  editArtistsCurrentPage : number = 1
  editArtistsCurrentPageReset(): void {
    this.editArtistsCurrentPage = 1
  }

  editFranchisesCurrentPage : number = 1
  editFranchisesCurrentPageReset(): void {
    this.editFranchisesCurrentPage = 1
  }

  editModelsCurrentPage : number = 1
  editModelsCurrentPageReset(): void {
    this.editModelsCurrentPage = 1
  }

  editTagsCurrentPage : number = 1
  editTagsCurrentPageReset(): void {
    this.editTagsCurrentPage = 1
  }

  editLinksCurrentPage : number = 1
  editLinksCurrentPageReset(): void {
    this.editLinksCurrentPage = 1
  }

  moodsByTagCurrentPage : number = 1
  moodsByTagCurrentPageReset(): void {
    this.moodsByTagCurrentPage = 1
  }
}