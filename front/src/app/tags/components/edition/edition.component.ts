import { Component, HostListener, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagCreateForm } from '../../../core/models/tag';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { TagsEditionService } from '../../../services/tags-edition.service';
import { MoodStateService } from '../../../services/mood.service';

@Component({
  selector: 'app-edition',
  templateUrl: './edition.component.html',
  styleUrl: './edition.component.scss'
})
export class EditionComponent 
{
  #tagsEditionService = inject(TagsEditionService)
  #formBuilder = inject(FormBuilder)
  #moodsService = inject(MoodStateService)
  menuService = inject(MenuDesktopService)            

  // Signal
  tagsEditionFlow = this.#tagsEditionService.tagsEditionFlow

  // Pagination
  elementsPerPage : number = 18
  currentPage : number = 1
  resetPage() : void
  {
    this.currentPage = 1
  }

  // Filter Tags Search Input
  searchTags : string = ''
  filterTags() 
  {
    return this.tagsEditionFlow().tags.filter(m => m.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  // Trigger Right column
  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }

  updateTagId( tagId : number | null ) : void
  {
    this.#moodsService.updateSelectedGalleryType('tag')
    this.#moodsService.updateSelectedTagId( tagId )
  }

  // Tag Selection
  updateTag( tagId : number | null ) : void
  {
    this.#tagsEditionService.updateSelectedTag( tagId )
    this.triggerUpdate()
  }

  // Category Selection
  updateCategory( categoryId : number | null ) : void
  {
    this.resetPage()
    this.#tagsEditionService.updateSelectedCategory( categoryId )
  }

  // CREATE MODAL
  tagTriggerCreate : boolean = false
  triggerCreate() : void
  {
    this.tagTriggerCreate = !this.tagTriggerCreate
  }
  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  createSubscription = new Subscription()
  resetCreate()
  {
    this.createFormGroup.reset()
    this.triggerCreate()
  }
  onCreate()
  {
    let form : TagCreateForm = 
    {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description,
    }

    if(this.createFormGroup.valid)
    {
      this.createSubscription = this.#tagsEditionService.CreateTag(form).subscribe({
        next : () => 
        {
          this.resetPage()
          this.triggerCreate()
          this.createFormGroup.reset()
        }
      })
    }
  }

  // UPDATE Modal
  tagTriggerUpdate : boolean = false
  triggerUpdate() : void
  {
    this.tagTriggerUpdate = !this.tagTriggerUpdate
  }
  updateFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.tagsEditionFlow().tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.tagsEditionFlow().tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  updateSubscription = new Subscription()
  cancelUpdate()
  {
    this.triggerUpdate()
  }
  onUpdate()
  {
    let form : TagCreateForm = 
    {
      name : this.updateFormGroup.value.name,
      description : this.updateFormGroup.value.description
    }
    if(this.updateFormGroup.valid)
    {
      this.updateSubscription = this.#tagsEditionService.UpdateTag(form).subscribe({
        next : () => 
        {
          this.triggerUpdate()
        }
      })
    }
  }

  // DELETE MODAL
  tagTriggerDelete : boolean = false
  triggerDelete() : void
  {
    this.tagTriggerDelete = !this.tagTriggerDelete
  }
  deleteSubscription = new Subscription()
  cancelDelete()
  {
    this.triggerDelete()
  }
  onDelete( tagId : number | undefined ) : void 
  {
    if(tagId === undefined) return
    this.deleteSubscription = this.#tagsEditionService.DeleteTag(tagId).subscribe({
      next : () => 
      {
        this.triggerDelete()
      }
    })
  }

  // COMPONENT LIFE CYCLE
  ngOnDestroy() : void 
  {
    this.createSubscription.unsubscribe()
    this.updateSubscription.unsubscribe()
    this.deleteSubscription.unsubscribe()
  }

  // TO TOP BUTTON
  topButtonIsActive = false    
  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }   
  toTop() : void 
  {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }
}
