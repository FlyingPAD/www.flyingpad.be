import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { LinksEditionService } from '../../../core/services/links-edition.service';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCreateForm, LinkUpdateForm } from '../../../core/models/link';

@Component({
  selector: 'app-edition',
  templateUrl: './edition.component.html',
  styleUrl: './edition.component.scss'
})
export class EditionComponent implements OnDestroy
{
  #linksEditionService = inject(LinksEditionService)
  #formBuilder = inject(FormBuilder)
  menuService = inject(MenuDesktopService)            

  linksEditionFlow = this.#linksEditionService.linksEditionFlow

  elementsPerPage : number = 18
  currentPage : number = 1

  searchLinks : string = ''
  linkTriggerCreate : boolean = false
  linkTriggerUpdate : boolean = false
  linkTriggerDelete : boolean = false
  topButtonIsActive : boolean = false  

  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  updateFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.linksEditionFlow().link?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.linksEditionFlow().link?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : [this.linksEditionFlow().link?.url, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  createSubscription = new Subscription()
  updateSubscription = new Subscription()
  deleteSubscription = new Subscription()

  ngOnDestroy() : void 
  {
    this.createSubscription.unsubscribe()
    this.updateSubscription.unsubscribe()
    this.deleteSubscription.unsubscribe()
  }

  resetPage() : void
  {
    this.currentPage = 1
  }

  filterLinks() 
  {
    return this.linksEditionFlow().links.filter(m => m.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }

  updateLink( linkId : number | null ) : void
  {
    this.#linksEditionService.updateSelectedLink( linkId )
  }

  updateCategory( categoryId : number | null ) : void
  {
    this.resetPage()
    this.#linksEditionService.updateSelectedCategory( categoryId )
  }

  triggerCreate() : void
  {
    this.linkTriggerCreate = !this.linkTriggerCreate
  }
  resetCreate() : void
  {
    this.createFormGroup.reset()
    this.triggerCreate()
  }
  onCreate() : void
  {
    let form : LinkCreateForm = 
    {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description,
      url : this.createFormGroup.value.url
    }

    if(this.createFormGroup.valid)
    {
      this.createSubscription = this.#linksEditionService.CreateLink(form).subscribe({
        next : () => 
        {
          this.resetPage()
          this.triggerCreate()
          this.createFormGroup.reset()
        }
      })
    }
  }

  triggerUpdate() : void
  {
    this.linkTriggerUpdate = !this.linkTriggerUpdate
  }
  resetUpdate( linkId : number) : void
  {
    this.updateLink(linkId)
    this.triggerUpdate()
    this.updateFormGroup = this.#formBuilder.group
    ({
      name : [this.linksEditionFlow().link?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description : [this.linksEditionFlow().link?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      url : [this.linksEditionFlow().link?.url, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }
  cancelUpdate() : void
  {
    this.triggerUpdate()
  }
  onUpdate() : void
  {
    const businessId = this.linksEditionFlow().link?.businessId;
    if (businessId === undefined) 
    {
      throw new Error('businessId is required but was undefined.');
    }

    let form : LinkUpdateForm = 
    {
      businessId : businessId,
      name : this.updateFormGroup.value.name,
      description : this.updateFormGroup.value.description,
      url : this.updateFormGroup.value.url
    }
    if(this.updateFormGroup.valid)
    {
      this.updateSubscription = this.#linksEditionService.UpdateLink(form).subscribe({
        next : () => 
        {
          this.triggerUpdate()
        }
      })
    }
  }

  triggerDelete() : void
  {
    this.linkTriggerDelete = !this.linkTriggerDelete
  }
  cancelDelete() : void
  {
    this.triggerDelete()
  }
  onDelete( linkId : number | undefined ) : void 
  {
    if(linkId === undefined) return
    this.deleteSubscription = this.#linksEditionService.DeleteLink(linkId).subscribe({
      next : () => 
      {
        this.triggerDelete()
      }
    })
  }

  // TO TOP BUTTON  
  @HostListener('window:scroll', ['$event'])
  onWindowScroll() : void
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