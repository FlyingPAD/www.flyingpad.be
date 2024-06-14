import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StorageService 
{
  // Save any value under any key
  setItem(key : string, value : any) : void 
  {
    localStorage.setItem(key, JSON.stringify(value))
  }

  // Retrieve the value by key
  getItem<T>(key : string) : T | null 
  {
    let item = localStorage.getItem(key)
    return item ? JSON.parse(item) as T : null
  }

  // Remove an item by key
  removeItem(key : string) : void 
  {
    localStorage.removeItem(key)
  }

  // Optional : Clear all local storage
  clearAll() : void 
  {
    localStorage.clear()
  }
}