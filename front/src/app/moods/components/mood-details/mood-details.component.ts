import { Component, HostListener, OnDestroy, OnInit, inject } from '@angular/core';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { ActivatedRoute } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { Subscription } from 'rxjs';
import { StateMoodsService } from '../../../core/services/state/state-moods.service';
import { UserService } from '../../../core/services/client/client-user.service';
import { ImageService } from '../../../core/services/client/client-mood-image.service';
import { VideoService } from '../../../core/services/client/client-mood-video.service';
import { VideoYouTubeService } from '../../../core/services/client/client-mood-video-youtube';
import { MoodFull, MoodLight, UpdateMoodScoreCall } from '../../../core/models/mood';
import { StateTagsService } from '../../../core/services/state/state-tags.service';
import { TagService } from '../../../core/services/client/client-tag.service';
import { Image } from '../../../core/models/mood-image';
import { Video } from '../../../core/models/mood-video';
import { VideoYouTube } from '../../../core/models/mood-video-youtube';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { ArtistLight } from '../../../core/models/artist';
import { ModelLight } from '../../../core/models/model';
import { ModelService } from '../../../core/services/client/client-model.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { FranchiseService } from '../../../core/services/client/client-franchise.service';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { StateFranchisesService } from '../../../core/services/state/state-franchises.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';
import { StateModelsService } from '../../../core/services/state/state-models.service';

@Component({
  selector: 'app-mood-details',
  templateUrl: './mood-details.component.html',
  styleUrl: './mood-details.component.scss'
})
export class MoodDetailsComponent  implements OnInit, OnDestroy
{
  // Injections :

  #artistsState = inject(StateArtistService)
  #modelsState = inject(StateModelsService)
  #franchisesState = inject(StateFranchisesService)

  #stateMoodsService = inject(StateMoodsService)
  #stateTagsService = inject(StateTagsService)

  #artistsService = inject(ArtistService)
  #franchisesService = inject(FranchiseService)
  #modelsService = inject(ModelService)
  #tagService = inject(TagService)
  #moodService = inject(MoodService)
  #imageService = inject(ImageService)
  #videoService = inject(VideoService)  
  #videoYouTubeService = inject(VideoYouTubeService)
  menuService = inject(MenuMobileService)  
  #route = inject(ActivatedRoute)
  #sanitizer = inject(DomSanitizer)
  userService = inject(UserService)


  // Properties :

  environment :       string = environment.apiBaseUrl
  galleryMode :       string = this.#route.snapshot.params['galleryMode']  
  moodId :            number = this.#route.snapshot.params['id'] 

  mood                = new MoodFull()
  image               = new Image()
  video               = new Video()
  videoYouTube        = new VideoYouTube()

  moods :             MoodLight[] = []
  artistsByMood :     ArtistLight[] = []
  modelsByMood :      ModelLight[] = []

  moodIndexPosition : number = 0
  
  windowHeight:       number          = window.innerHeight
  intervalId :        any | undefined = undefined              // Set Interval ID for Diaporama
  diaporamaSwitch :   boolean         = false                  // Switch to activate / deactive second diaporama when one is running
  isFocused :         boolean         = false;                 // Toggle Content Focus ( full size )
  MOODHEIGHTMIN :     number          = this.windowHeight -64  // Minimum Mood Height ( if any ) for size Toggle
  MOODHEIGHTMAX :     number          = 2000                   // Maximum Mood Height ( if any ) for size Toggle
  moodHeight :        number          = this.windowHeight - 64 // Original Mood Height ( if any ) for Size Toggle
  diaporamaDelay :    number          = 3000                   // Diaporama Delay

  currentMood$ = this.#stateMoodsService.currentMood$
  currentImage$ = this.#stateMoodsService.currentImage$
  currentVideo$ = this.#stateMoodsService.currentVideo$
  currentVideoYouTube$ = this.#stateMoodsService.currentVideoYouTube$
  currentTag$ = this.#stateTagsService.currentTag$
  currentTagsByMood$ = this.#stateTagsService.currentTagsByMood$
  currentArtist$ = this.#artistsState.currentArtist$
  currentModel$ = this.#modelsState.currentModel$
  currentFranchise$ = this.#franchisesState.currentFranchise$

  franchisesByMood$ = this.#franchisesState.currentFranchises$

  typeSubscription = new Subscription()
  moodSubscription = new Subscription()
  moodsSubscription = new Subscription()
  tagsByMoodSubscription = new Subscription()
  artistsByMoodSubscription = new Subscription()
  modelsByMoodSubscription = new Subscription()
  franchisesSubscription = new Subscription()

  // Component Life Cycles :

  ngOnInit() : void
  {
    this.getMoods()
    this.getMood()
  }

  ngOnDestroy() : void
  {
    this.typeSubscription.unsubscribe()
    this.moodSubscription.unsubscribe()
    this.moodsSubscription.unsubscribe()
    this.tagsByMoodSubscription.unsubscribe()
    this.artistsByMoodSubscription.unsubscribe()
    this.modelsByMoodSubscription.unsubscribe()
    this.franchisesSubscription.unsubscribe()
  }

  // Get Mood Methods

  getMood() : void
  {
    (this.moodId) ? this.getMoodById(this.moodId) : this.getRandomMood()
  }

  getMoodById( moodId : number ) : void
  {
    this.moodSubscription = this.#moodService.GetOneDetails( moodId ).subscribe({
      next : (data) => 
      {
        this.mood = data.mood
        this.#stateMoodsService.updateCurrentMood(data.mood)
        this.getMoodType(data.mood)
        this.findIndex(data.mood.businessId)
        this.getTagsByMood(data.mood.businessId)
        this.getArtistsByMood(data.mood.businessId)
        this.getModelsByMood(data.mood.businessId)
        this.getFranchisesByMood(data.mood.businessId)
      }
    })
  }

  getRandomMood() : void
  {
    this.moodSubscription = this.#moodService.GetOneDetailsRandom().subscribe({
      next : (data) => 
      {
        this.mood = data.mood
        this.#stateMoodsService.updateCurrentMood(data.mood)
        this.getMoodType(data.mood)
        this.findIndex(data.mood.businessId)
        this.getTagsByMood(data.mood.businessId)
        this.getArtistsByMood(data.mood.businessId)
        this.getModelsByMood(data.mood.businessId)
        this.getFranchisesByMood(data.mood.businessId)
      }
    })
  }

  getArtistsByMood( moodId : number ) : void
  {
    this.artistsByMoodSubscription = this.#artistsService.GetByMood( moodId ).subscribe({
      next : (data) => {
        this.artistsByMood = data.artistsByMood
      }
    })
  }

  getModelsByMood( moodId : number ) : void
  {
    this.modelsByMoodSubscription = this.#modelsService.GetByMood( moodId ).subscribe({
      next : (data) => {
        this.modelsByMood = data.modelsByMood
      }
    })
  }

  getFranchisesByMood( moodId : number )
  {
    this.franchisesSubscription = this.#franchisesService.GetByMood( moodId ).subscribe({
      next : (data) => {
        this.#franchisesState.updateCurrentFranchises(data.franchisesByMood)
      }
    })
  }

  getTagsByMood( moodId : number ) : void
  {
    this.tagsByMoodSubscription = this.#tagService.GetByMood( moodId ).subscribe({
      next : (data) => 
      {
        this.#stateTagsService.updateCurrentTagsByMood(data.tagsByMood)
      }
    })
  }

  getMoodType( mood : MoodFull ) : void
  {
    if(mood.type === 1)
    {
      this.typeSubscription = this.#imageService.GetOneDetails(mood.businessId).subscribe({
        next : (data) => {
          this.image = data.image
          this.#stateMoodsService.updateCurrentImage(data.image)
        }
      })
    }
    if(mood.type === 2)
    {
      this.typeSubscription = this.#videoService.GetOneDetails(mood.businessId).subscribe({
        next : (data) => {
          this.video = data.video
          this.#stateMoodsService.updateCurrentVideo(data.video)
        }
      })
    }
    if(mood.type === 4)
    {
      this.typeSubscription = this.#videoYouTubeService.GetOneDetails(mood.businessId).subscribe({
        next : (data) => {
          this.videoYouTube = data.videoYouTube
          this.#stateMoodsService.updateCurrentVideoYouTube(data.videoYouTube)
        }
      })
    }
    // Other Types ... Coming Soon ...
  }

  getMoods()
  {
    this.galleryMode = this.#route.snapshot.params['galleryMode']
    if(this.galleryMode = 'tag')
    {
      this.moodsSubscription = this.#stateMoodsService.currentMoodsByTag$.subscribe({
        next : (data) => 
        {
          this.moods = data
        }
      })
    }
    if(this.galleryMode = 'model')
    {
      this.moodsSubscription = this.#stateMoodsService.currentMoodsByModel$.subscribe({
        next : (data) => 
        {
          this.moods = data
        }
      })
    }
    if(this.galleryMode = 'artist')
    {
      this.moodsSubscription = this.#stateMoodsService.currentMoodsByArtist$.subscribe({
        next : (data) => 
        {
          this.moods = data
        }
      })
    }
    if(this.galleryMode = 'franchise')
    {
      this.moodsSubscription = this.#stateMoodsService.currentMoodsByFranchise$.subscribe({
        next : (data) => 
        {
          this.moods = data
        }
      })
    }
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

  // -----------------------------------------------------------------
  // - Open Mood in new Window :

  openDownload()
  {
    let downloadLink = ''

    if (this.mood.type === 1 && this.image) 
    {
      downloadLink = `${this.environment}/Content/img/${this.image.businessId}.${this.image.extension}`
    } 
    else if (this.mood.type === 2 && this.video) 
    {
      downloadLink = `${this.environment}/Content/video/${this.video.businessId}.${this.video.extension}`
    }
    if (downloadLink) 
    {
      window.open(downloadLink, '_blank')
    }
  }

  // -----------------------------------------------------------------
  // Pagination

  findIndex( moodId : number ) : void
  {
    this.moodIndexPosition =  this.moods.findIndex( mood => mood.businessId === moodId ) + 1
  }

  previousMood()
  {
    let moodIndex = this.moods.findIndex(mood => mood.businessId === this.mood.businessId)
    let moodNextIndex = 0
    if(moodIndex > 0)
    {
      moodNextIndex = (moodIndex - 1) % this.moods.length
    }
    this.getMoodById(this.moods[moodNextIndex].businessId)
    this.adaptSize()
  }

  nextMood()
  {
    let moodIndex = this.moods.findIndex(mood => mood.businessId === this.mood.businessId)
    let moodNextIndex = (moodIndex + 1) % this.moods.length
    this.getMoodById(this.moods[moodNextIndex].businessId)
    this.adaptSize()
  }

  // -----------------------------------------------------------------
  // - Diaporama :

  diaporamaStart()
  {
    
    this.nextMood()
    this.intervalId = setInterval(() => 
    {
      this.nextMood()
    }, 
    this.diaporamaDelay)
  }
  
  diaporamaStop()
  {
    if (this.intervalId !== undefined) 
    {
      clearInterval(this.intervalId);
      this.intervalId = undefined
    }
  }

  diaporamaRStart()
  {
    this.getRandomMood()
    this.intervalId = setInterval(() => 
    {
      this.getRandomMood()
    }, 
    this.diaporamaDelay)
  }
  
  diaporamaRStop()
  {
    if (this.intervalId !== undefined) 
    {
      clearInterval(this.intervalId);
      this.intervalId = undefined
    }
  }

  // -----------------------------------------------------------------
  // - Update Mood Score :

  updateMoodScore( moodBusinessId : number, scoreValue : number)
  {
    let form : UpdateMoodScoreCall = { businessId : moodBusinessId, value : scoreValue }
    this.#moodService.UpdateScore(form).subscribe({
      next : () => {
        this.getMoodById(moodBusinessId)
      }
    })
  }

  // -----------------------------------------------------------------
  // - Keyboard Configuration :

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'ArrowLeft':
        this.previousMood();
        break
      case 'ArrowRight':
        this.nextMood();
        break
      case ' ':
        this.intervalId === undefined ? this.diaporamaStart() : this.diaporamaStop()
        break
      // case 'Backspace':
      //   this.getMoods(this.tag.id)
      //   break
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

  adaptSize()
  {
    setTimeout(() => 
    {
      if(this.isFocused)
      {
        if(this.mood.type === 1)
        {
          if(this.image.height > this.MOODHEIGHTMAX)
          {
            this.moodHeight = this.MOODHEIGHTMAX
          }
          else
          {
            this.moodHeight = this.image.height
          }
        }
        else if(this.mood.type === 2)
        {
          if(this.video.height > this.MOODHEIGHTMAX)
          {
            this.moodHeight = this.MOODHEIGHTMAX
          }
          else
          {
            this.moodHeight = this.video.height
          }
        }
      }
      else
      {
        this.moodHeight = this.MOODHEIGHTMIN
      }
    }, 200);
  }
}