import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { MoodFull, MoodLight } from '../../models/mood';
import { Image } from '../../models/mood-image';
import { Video } from '../../models/mood-video';
import { VideoYouTube } from '../../models/mood-video-youtube';

@Injectable({
  providedIn: 'root'
})
export class StateMoodsService 
{
  // Properties :

  #totalMoodsSubject              = new BehaviorSubject<MoodLight[]>([])
  #currentMoodsByTagSubject       = new BehaviorSubject<MoodLight[]>([])
  #currentMoodsByModelSubject     = new BehaviorSubject<MoodLight[]>([])
  #currentMoodsByArtistSubject    = new BehaviorSubject<MoodLight[]>([])
  #currentMoodsByFranchiseSubject = new BehaviorSubject<MoodLight[]>([])
  #currentMoodSubject             = new BehaviorSubject<MoodFull>(new MoodFull())
  #currentImageSubject            = new BehaviorSubject<Image>(new Image())
  #currentVideoSubject            = new BehaviorSubject<Video>(new Video())
  #currentVideoYouTubeSubject     = new BehaviorSubject<VideoYouTube>(new VideoYouTube())

  // Getters :
  
  get totalMoods$()              { return this.#totalMoodsSubject.asObservable() }
  get currentMoodsByTag$()       { return this.#currentMoodsByTagSubject.asObservable() }
  get currentMoodsByModel$()     { return this.#currentMoodsByModelSubject.asObservable() }
  get currentMoodsByArtist$()    { return this.#currentMoodsByArtistSubject.asObservable() }
  get currentMoodsByFranchise$() { return this.#currentMoodsByFranchiseSubject.asObservable() }
  get currentMood$()             { return this.#currentMoodSubject.asObservable() }
  get currentImage$()            { return this.#currentImageSubject.asObservable() }
  get currentVideo$()            { return this.#currentVideoSubject.asObservable() }
  get currentVideoYouTube$()     { return this.#currentVideoYouTubeSubject.asObservable() }

  // Methods :

  updateTotalMoods( moods : MoodLight[] ) 
  {
    this.#totalMoodsSubject.next( moods )
  }

  updateCurrentMoodsByTag( moods : MoodLight[] ) 
  {
    this.#currentMoodsByTagSubject.next( moods )
  }

  updateCurrentMoodsByModel( moods : MoodLight[] ) 
  {
    this.#currentMoodsByModelSubject.next( moods )
  }

  updateCurrentMoodsByArtist( moods : MoodLight[] ) 
  {
    this.#currentMoodsByArtistSubject.next( moods )
  }

  updateCurrentMoodsByFranchise( moods : MoodLight[] ) 
  {
    this.#currentMoodsByFranchiseSubject.next( moods )
  }

  updateCurrentMood( mood : MoodFull ) 
  {
    this.#currentMoodSubject.next( mood )
  }

  updateCurrentImage( image : Image ) 
  {
    this.#currentImageSubject.next( image )
  }

  updateCurrentVideo( video : Video ) 
  {
    this.#currentVideoSubject.next( video )
  }

  updateCurrentVideoYouTube( videoYouTube : VideoYouTube ) 
  {
    this.#currentVideoYouTubeSubject.next( videoYouTube )
  }
}