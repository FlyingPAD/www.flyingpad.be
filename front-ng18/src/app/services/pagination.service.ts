import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PaginationService {  
  moodsByTagCurrentPage : number = 1
  moodsByTagCurrentPageReset() {
    this.moodsByTagCurrentPage = 1
  }
}