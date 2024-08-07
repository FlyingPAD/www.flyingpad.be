import { Component, HostListener, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LinksEditionService } from '../../../services/links-edition.service';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { LinkCreateForm } from '../../../models/forms-create';
import { LinkUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-links-edition',
  templateUrl: './links-edition.component.html',
  styleUrl: './links-edition.component.scss'
})
export class LinksEditionComponent 
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
      this.#linksEditionService.CreateLink(form).subscribe( () =>
      {
        this.resetPage()
        this.triggerCreate()
        this.createFormGroup.reset()
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
      linkId : businessId,
      name : this.updateFormGroup.value.name,
      description : this.updateFormGroup.value.description,
      url : this.updateFormGroup.value.url
    }
    if(this.updateFormGroup.valid)
    {
      this.#linksEditionService.UpdateLink(form).subscribe( () =>
      {
        this.triggerUpdate()
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
    this.#linksEditionService.DeleteLink(linkId).subscribe( () =>
    {
      this.triggerDelete()
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