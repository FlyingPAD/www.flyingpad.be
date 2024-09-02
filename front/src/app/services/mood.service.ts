import { HttpClient } from "@angular/common/http";
import { Injectable, inject } from "@angular/core";
import { BehaviorSubject, map, tap, Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { CreateMoodImageResponse, ImageForm } from "../models/mood-image";


@Injectable({
  providedIn: 'root'
})
export class MoodStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedGalleryType = new BehaviorSubject<string | null>(null)
  updateSelectedGalleryType( galleryType : string | null) : void { this.#selectedGalleryType.next( galleryType ) }

  #selectedMoodId = new BehaviorSubject<number | null>(null)
  updateSelectedMoodId(moodId : number | null) : void { this.#selectedMoodId.next(moodId) }

  #selectedTagId = new BehaviorSubject<number | null>(null)
  updateSelectedTagId(TagId : number | null) { this.#selectedTagId.next(TagId) }

  #selectedArtistId = new BehaviorSubject<number | null>(null)
  updateSelectedArtistId( artistId : number | null ) : void { this.#selectedArtistId.next(artistId) }

  public Insert(form : ImageForm) : Observable<number> 
  {
    return this.#http.post<CreateMoodImageResponse>(`${this.#url}Moods/CreateMoodImage`, form).pipe(
      map(response => response.mood.businessId),
      tap(businessId => this.updateSelectedMoodId(businessId))
    )
  }
}