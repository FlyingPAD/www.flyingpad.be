import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { Location } from '@angular/common';
import { Image } from "../../../core/models/mood-image"
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { environment } from '../../../../environments/environment';
import { UpdateMoodScoreCall } from '../../../core/models/mood';
import { Video } from '../../../core/models/mood-video';
import { VideoYouTube } from '../../../core/models/mood-video-youtube';
import { ArtistsStateService } from '../../../core/services/artists-state.service';
import { UserService } from '../../../core/services/client/client-user.service';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';
import { ModelStateService } from '../../../core/services/model-state.service';
import { MoodStateService } from '../../../core/services/mood-state.service';

@Component({
  selector: 'app-mood-details-edit',
  templateUrl: './mood-details-edit.component.html',
  styleUrl: './mood-details-edit.component.scss'
})
export class MoodDetailsEditComponent implements OnDestroy
{
  #artistsService = inject(ArtistsStateService)
  #moodsService = inject(MoodStateService)
  #sanitizer = inject(DomSanitizer)
  #modelsService = inject(ModelStateService)
  #franchiseService = inject(FranchiseStateService)
  #location = inject(Location)
  userService = inject(UserService)

  environment :       string          = environment.apiBaseUrl  // API URL
  windowHeight :      number          = window.innerHeight      // Window Height
  windowWidth :       number          = window.innerWidth       // Window Width  
  isFocused :         boolean         = false;                  // Toggle Content Focus ( full size )
  MOODHEIGHTMIN :     number          = this.windowHeight -64   // Toggle Minimum Mood Height ( if any )
  MOODHEIGHTMAX :     number          = 2000                    // Toggle Maximum Mood Height ( if any )
  moodHeight :        number          = this.windowHeight - 64  // Toggle Original Mood Height ( if any )
  diaporamaDelay :    number          = 3000                    // Diaporama Delay
  intervalId :        any | undefined = undefined               // Diaporama Set Interval ID
  diaporamaSwitch :   boolean         = false                   // Diaporama Switch to activate / deactive second when one is running
  moodIndexPosition : number          = 0                       // Mood Index Position ( pagination )
  mood = this.#moodsService.getMoodFlow                         // Signal
  moods = this.#moodsService.newMoodsFlow                       // Signal
  model = this.#modelsService.model                             // Signal
  
  ngOnDestroy() : void
  {
    this.diaporamaStop()
  }

  getMood( moodId : number | null )
  {
    this.#moodsService.updateSelectedMoodId( moodId )
  }

  getRandomMood()
  {
    this.#moodsService.updateSelectedMoodId( null )
    this.#moodsService.updateSelectedGalleryType('')
    this.adaptSize()
  }

  getPage( direction : string )
  {
    if(direction === 'previous')
    {
      this.getMood(this.moods().previousMoodId)
    } 
    if(direction === 'next')
    {
      this.getMood(this.moods().nextMoodId)
    } 
    this.adaptSize()
  }

  updateFranchiseId( franchiseId : number | null )
  {
    this.#franchiseService.updateSelectedFranchiseId(franchiseId)
  }

  updateModelId( modelId : number | null )
  {
    this.#modelsService.updateSelectedModelId(modelId)
    this.#moodsService.updateSelectedModelId(modelId)
  }

  updateArtistId( artistId : number | null )
  {
    this.#artistsService.updateSelectedArtistId(artistId)
    this.#moodsService.updateSelectedArtistId(artistId)
  }

  updateTagId( tagId : number | null )
  {
    this.#moodsService.updateSelectedGalleryType('tag')
    this.#moodsService.updateSelectedTagId(tagId)
  }

  updateMoodScore( moodBusinessId : number, scoreValue : number)
  {
    let form : UpdateMoodScoreCall = { businessId : moodBusinessId, value : scoreValue }
    this.#moodsService.updateScoreTrigger(form)
  }

  goBack() : void
  {
    this.#location.back()
  }

  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'ArrowLeft':
        this.getMood(this.moods().previousMoodId)
        break
      case 'ArrowRight':
        this.getMood(this.moods().nextMoodId)
        break
      case ' ':
        this.intervalId === undefined ? this.diaporamaStart(false) : this.diaporamaStop()
        break
      case 'Backspace':
        this.goBack()
        break
      case 'Enter':
        this.openDownload()
        break
      case '0':
        this.getRandomMood()
        break
      case '+':
        this.toggleFocus()
        break;
    }
  }

  // OPEN FILE IN NEW WINDOW ( DOWNLOAD )
  openDownload()
  {
    let downloadLink = ''

    if (this.mood().mood.type === 1) 
    {
      downloadLink = `${this.environment}/Content/img/${this.mood().mood.businessId}.${this.mood().mood.extension}`
    } 
    else if (this.mood().mood.type === 2) 
    {
      downloadLink = `${this.environment}/Content/video/${this.mood().mood.businessId}.${this.mood().mood.extension}`
    }
    if (downloadLink) 
    {
      window.open(downloadLink, '_blank')
    }
  }

  // TOGGLE IMAGE SIZE
  toggleFocus() 
  {
    this.isFocused = !this.isFocused
    this.isFocused ? this.adaptSize() : this.moodHeight = this.MOODHEIGHTMIN
  }
  sizeReset()
  {
    this.isFocused = false
    this.moodHeight = this.MOODHEIGHTMIN
  }
  adaptSize() 
  {
    setTimeout(() => 
    {
      if (this.isFocused) 
      {
        const moodData = this.mood()
  
        if (moodData.mood.type === 1 && moodData.media) 
        {
          const image = moodData.media as Image
          const imageHeight = image.height
  
          if (imageHeight > this.MOODHEIGHTMAX) 
          {
            this.moodHeight = this.MOODHEIGHTMAX
          } 
          else 
          {
            this.moodHeight = imageHeight
          }
        } 
        else if (moodData.mood.type === 2 && moodData.media) 
        {

          const video = moodData.media as Video
          const videoHeight = video.height
        }
      } 
      else 
      {
        this.moodHeight = this.MOODHEIGHTMIN
      }
    }, 200)
  }

  // VIDEO TEST
  getSafeContent(videoId: string): SafeHtml 
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


  // DIAPORAMA
  diaporamaStart( isRandom : boolean )
  {
    isRandom ? this.getRandomMood() : this.getPage('next')
    this.intervalId = setInterval(() => 
    {
      isRandom ? this.getRandomMood() : this.getPage('next')
    }, 
    this.diaporamaDelay)
  }  
  diaporamaStop()
  {
    if (this.intervalId !== undefined) 
    {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
  }

  // TYPE CHECK ( TEMP )
  typeCheck(media : any)
  {
    if(this.mood().mood.type === 1)
    {
      return media as Image
    }
    if(this.mood().mood.type === 2)
    {
      return media as Video
    }
    if(this.mood().mood.type === 4)
      {
        return media as VideoYouTube
      }
    else
    {
      return media
    }
  }
}