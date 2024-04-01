import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { StateTagsService } from '../../../core/services/state/state-tags.service';
import { Tag } from '../../../core/models/tag';
import { Subscription, debounceTime } from 'rxjs';

@Component({
  selector: 'app-tags-gallery',
  templateUrl: './tags-gallery.component.html',
  styleUrl: './tags-gallery.component.scss'
})
export class TagsGalleryComponent implements OnInit, OnDestroy
{
  #stateTagsService = inject(StateTagsService)

  currentTagList$ = this.#stateTagsService.currentTagList$

  currentTag = new Tag()
  tagSubscription = new Subscription()

  ngOnInit() {
    this.tagSubscription = this.#stateTagsService.currentTag$
      .pipe(
        debounceTime(300) // Attend 300ms après le dernier signal avant d'exécuter le next
      )
      .subscribe({
        next: (data) => {
          this.currentTag = data;
          // Assurez-vous que l'élément est dans le DOM
          this.scrollToStart(this.currentTag.businessId.toString());
        }
      });
  }

  ngOnDestroy(): void 
  {
    this.tagSubscription.unsubscribe()
  }

  scrollToStart( elementId : string ) : void 
  {
    const domElement = document.getElementById( elementId )

    if (domElement) 
    {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
    }
  }
}