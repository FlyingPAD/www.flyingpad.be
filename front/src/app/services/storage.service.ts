import { Injectable, inject } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  #toastr = inject(ToastrService);

  setItem(key: string, value: any): void {
    try {
      localStorage.setItem(key, JSON.stringify(value));
    } catch (error) {
      this.#toastr.error(`Error saving item ${key}`, 'Error');
    }
  }

  getItem<T>(key: string): T | null {
    try {
      const item = localStorage.getItem(key);
      return item ? JSON.parse(item) as T : null;
    } catch (error) {
      this.#toastr.error(`Error retrieving item ${key}`, 'Error');
      return null;
    }
  }

  removeItem(key: string): void {
    try {
      localStorage.removeItem(key);
    } catch (error) {
      this.#toastr.error(`Error removing item ${key}`, 'Error');
    }
  }

  clearAll(): void {
    try {
      localStorage.clear();
    } catch (error) {
      this.#toastr.error('Error clearing all items', 'Error');
    }
  }
}