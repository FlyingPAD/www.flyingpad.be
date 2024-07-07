import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { Video } from '../../../models/mood-video';
import { Image } from '../../../models/mood-image';
import { VideoYouTube } from '../../../models/mood-video-youtube';

@Component({
  selector: 'app-mood-viewer',
  templateUrl: './mood-viewer.component.html',
  styleUrl: './mood-viewer.component.scss'
})
export class MoodViewerComponent {
  #sanitizer = inject(DomSanitizer)

  @Input() mood : any | undefined = undefined

  @Output() getIndex = new EventEmitter<string>()

  environment : string = environment.apiBaseUrl
  
  windowHeight :      number          = window.innerHeight      // Window Height
  windowWidth :       number          = window.innerWidth       // Window Width  
  isFocused :         boolean         = false;                  // Toggle Content Focus ( full size )
  MOODHEIGHTMIN :     number          = this.windowHeight -64   // Toggle Minimum Mood Height ( if any )
  MOODHEIGHTMAX :     number          = 2000                    // Toggle Maximum Mood Height ( if any )
  moodHeight :        number          = this.windowHeight - 64  // Toggle Original Mood Height ( if any )

  handleGetIndex(direction : string): void {
    this.getIndex.emit(direction)
  }

  // VIDEO TEST
  getSafeContent(videoId: string) : SafeHtml 
  {
    const embedUrl = `https://www.youtube.com/embed/${videoId}?autoplay=1&mute=1` 
    const iframeHtml = `
      <iframe src="${embedUrl}" 
              frameborder="0" 
              allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen>
      </iframe>`
    return this.#sanitizer.bypassSecurityTrustHtml(iframeHtml)
  }

  // TOGGLE IMAGE SIZE
  toggleFocus() : void
  {
    this.isFocused = !this.isFocused
    this.isFocused ? this.adaptSize() : this.moodHeight = this.MOODHEIGHTMIN
  }
  sizeReset() : void
  {
    this.isFocused = false
    this.moodHeight = this.MOODHEIGHTMIN
  }
  adaptSize() : void
  {
    setTimeout(() => 
    {
      if (this.mood && this.isFocused) 
      { 
        if (this.mood.type === 1) 
        {
          const imageHeight = this.typeCheck(this.mood).height
  
          if (imageHeight > this.MOODHEIGHTMAX) 
          {
            this.moodHeight = this.MOODHEIGHTMAX
          } 
          else 
          {
            this.moodHeight = imageHeight
          }
        } 
        else if (this.mood?.type === 2) 
        {
          const videoHeight = this.typeCheck(this.mood).height
        }
      } 
      else 
      {
        this.moodHeight = this.MOODHEIGHTMIN
      }
    }, 200)
  }

  // TYPE CHECK ( TEMP )
  typeCheck(media : any)
  {
    if(this.mood?.type === 1)
    {
      return media as Image
    }
    if(this.mood?.type === 2)
    {
      return media as Video
    }
    if(this.mood?.type === 4)
      {
        return media as VideoYouTube
      }
    else
    {
      return media
    }
  }
}