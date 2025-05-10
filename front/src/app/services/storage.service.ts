import { Injectable, inject } from '@angular/core';
import { NotificationService } from './user-interface/notification.service';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  #notificationService = inject(NotificationService)

  public setItem(key: string, value: any): void {
    try {
      if (value === undefined) localStorage.removeItem(key) 
      else localStorage.setItem(key, JSON.stringify(value))
    } 
    catch (error) {
      this.#notificationService.error(`Error saving item ${key}`, 'Error')
    }
  }

  public getItem<T>(key: string): T | null {
    try {
      const item = localStorage.getItem(key)
      return item ? JSON.parse(item) as T : null
    } 
    catch (error) {
      this.#notificationService.error(`Error retrieving item ${key}`, 'Error')
      return null
    }
  }

  public removeItem(key: string): void {
    try {
      localStorage.removeItem(key)
    }
    catch (error) {
      this.#notificationService.error(`Error removing item ${key}`, 'Error')
    }
  }

  public clearAll(): void {
    try {
      localStorage.clear()
    }
    catch (error) {
      this.#notificationService.error('Error clearing all items', 'Error')
    }
  }
}