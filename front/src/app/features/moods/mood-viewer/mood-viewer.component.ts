import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { ViewerService } from '../../../services/features/viewer.service';

@Component({
  selector: 'app-mood-viewer',
  templateUrl: './mood-viewer.component.html',
  styleUrl: './mood-viewer.component.scss'
})
export class MoodViewerComponent {
  #sanitizer = inject(DomSanitizer)
  viewerService = inject(ViewerService)

  @Input() mood : any | undefined = undefined
  @Output() getIndex = new EventEmitter<string>()

  environment : string = environment.apiBaseUrl
  
  moodHeight = this.viewerService.moodHeight

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
}