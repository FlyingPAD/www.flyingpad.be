import { Component, HostListener, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { environment } from '../../../../environments/environment';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { Video } from '../../../core/models/mood-video';
import { Image } from '../../../core/models/mood-image';
import { ModelStateService } from '../../../core/services/model-state.service';

@Component({
  selector: 'app-new-moods',
  templateUrl: './new-moods.component.html',
  styleUrls: ['./new-moods.component.scss']
})
export class NewMoodsComponent 
{
  // Dependency Injections
  moodsService = inject(MoodStateService)
  #sanitizer = inject(DomSanitizer)
  newModelsService = inject(ModelStateService)

  updateModelId(modelId : number)
  {
    this.newModelsService.updateSelectedModelId(modelId)
  }

  // Properties
  environment :       string          = environment.apiBaseUrl
  windowHeight :      number          = window.innerHeight
  windowWidth :       number          = window.innerWidth
  
  intervalId :        any | undefined = undefined              // Set Interval ID for Diaporama
  diaporamaSwitch :   boolean         = false                  // Switch to activate / deactive second diaporama when one is running
  isFocused :         boolean         = false;                 // Toggle Content Focus ( full size )
  MOODHEIGHTMIN :     number          = this.windowHeight -64  // Minimum Mood Height ( if any ) for size Toggle
  MOODHEIGHTMAX :     number          = 2000                   // Maximum Mood Height ( if any ) for size Toggle
  moodHeight :        number          = this.windowHeight - 64 // Original Mood Height ( if any ) for Size Toggle
  diaporamaDelay :    number          = 3000                   // Diaporama Delay

  // Signal
  mood = this.moodsService.getMoodFlow

  // Methods
  getMoodRandom()
  {
    this.moodsService.updateSelectedMoodId( null )
  }
  getMood( moodId : number)
  {
    this.moodsService.updateSelectedMoodId( moodId )
  }

  // -----------------------------------------------------------------
  // - Keyboard Configuration :

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'ArrowLeft':
        // this.previousMood();
        break
      case 'ArrowRight':
        // this.nextMood();
        break
      case ' ':
        // this.intervalId === undefined ? this.diaporamaStart() : this.diaporamaStop()
        break
      // case 'Backspace':
      //   this.getMoods(this.tag.id)
      //   break
      case 'Enter':
        this.openDownload()
        break
      case '0':
        this.getMoodRandom()
        break
      case '+':
        this.toggleFocus()
        break;
    }
  }

  // -----------------------------------------------------------------
  // - Open Mood in new Window :

  openDownload()
  {
    let downloadLink = ''

    // if (this.mood().mood.type === 1 && this.image) 
    // {
    //   downloadLink = `${this.environment}/Content/img/${this.image.businessId}.${this.image.extension}`
    // } 
    // else if (this.mood().mood.type === 2 && this.video) 
    // {
    //   downloadLink = `${this.environment}/Content/video/${this.video.businessId}.${this.video.extension}`
    // }
    // if (downloadLink) 
    // {
    //   window.open(downloadLink, '_blank')
    // }
  }

  // -----------------------------------------------------------------
  // Focus

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

  adaptSize() {
    setTimeout(() => {
      if (this.isFocused) {
        const moodData = this.mood(); // Supposons que cela renvoie la structure de données que vous avez configurée dans moodFlow$
  
        if (moodData.mood.type === 1 && moodData.media) {
          // Supposons que media de type 1 est une Image et a une propriété height
          const image = moodData.media as Image; // Utilisez le type correct pour Image
          const imageHeight = image.height; // Maintenant vous pouvez accéder à height
  
          if (imageHeight > this.MOODHEIGHTMAX) {
            this.moodHeight = this.MOODHEIGHTMAX;
          } else {
            this.moodHeight = imageHeight;
          }
        } else if (moodData.mood.type === 2 && moodData.media) {
          // Supposons que media de type 2 est une Video et a une propriété height
          const video = moodData.media as Video; // Utilisez le type correct pour Video
          const videoHeight = video.height; // Maintenant vous pouvez accéder à height
  
          // Vous pouvez maintenant comparer videoHeight avec MOODHEIGHTMAX comme dans le cas de l'image
        }
      } else {
        this.moodHeight = this.MOODHEIGHTMIN;
      }
    }, 200);
  }

  getSafeContent(videoId: string): SafeHtml {
    // Construire l'URL d'intégration avec autoplay et mute
    const embedUrl = `https://www.youtube.com/embed/${videoId}?autoplay=1&mute=1`;
  
    // Construire le HTML de l'iframe avec l'URL d'intégration
    const iframeHtml = `
      <iframe width="560" height="315" src="${embedUrl}" 
              frameborder="0" 
              allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen>
      </iframe>`;
    return this.#sanitizer.bypassSecurityTrustHtml(iframeHtml);
  }
}