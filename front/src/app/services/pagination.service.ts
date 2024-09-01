import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PaginationService 
{
  // Artists
  editArtistsCurrentPage : number = 1
  editArtistsCurrentPageReset(): void {
    this.editArtistsCurrentPage = 1
  }

  // Franchises
  editFranchisesCurrentPage : number = 1
  editFranchisesCurrentPageReset(): void {
    this.editFranchisesCurrentPage = 1
  }

  // Models
  editModelsCurrentPage : number = 1
  editModelsCurrentPageReset(): void {
    this.editModelsCurrentPage = 1
  }

  // Tags
  editTagsCurrentPage : number = 1
  editTagsCurrentPageReset(): void {
    this.editTagsCurrentPage = 1
  }

  // Links
  editLinksCurrentPage : number = 1
  editLinksCurrentPageReset(): void {
    this.editLinksCurrentPage = 1
  }

  // Moods
  moodsByTagCurrentPage : number = 1
  moodsByTagCurrentPageReset(): void {
    this.moodsByTagCurrentPage = 1
  }
}