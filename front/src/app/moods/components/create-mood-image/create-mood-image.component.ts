import { Component, ElementRef, ViewChild, inject } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';
import { ImageForm } from '../../../core/models/mood-image';
import { MoodStateService } from '../../../core/services/mood.service';

@Component({
  selector: 'app-create-mood-image',
  templateUrl: './create-mood-image.component.html',
  styleUrl: './create-mood-image.component.scss'
})
export class CreateMoodImageComponent 
{
  #moodService = inject(MoodStateService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  menuService = inject(MenuDesktopService)

  images : ImageForm[] = []
  forms : FormGroup[] = []
  invalidCount : number = 0
  invalidNames : string[] = []
  form : FormGroup = this.#builder.group({
    title: '...',
    description: '...',
    type: 1,
    size: 0,
    extension: '...',
    height: 0,
    width: 0,
    sourceFile: '...'
  })

  @ViewChild('originalInput') originalInput!: ElementRef<HTMLInputElement>

  onClickHack() 
  {
    this.originalInput?.nativeElement.click()
  }

  onFileSelect(event : any) 
  {
    for (let i = 0; i < event.target.files.length; i++) 
    {
      const file = event.target.files[i]
  
      const reader = new FileReader()
      reader.readAsDataURL(file)
  
      reader.onload = () => 
      {
        if(file.name.slice(file.name.lastIndexOf('.') + 1) === 'gif' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1) === 'jpg' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1) === 'jpeg' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1) === 'png' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1) === 'webp' && file.size < 50000000)
        {
          const image: ImageForm = 
          {
            title: '...',
            description: '...',
            type: 1,
            size: file.size,
            extension: file.name.slice(file.name.lastIndexOf('.') + 1),
            height: 0,
            width: 0,
            sourceFile: file.name,
            url: reader.result as string
          }
    
          const img = new Image()
          img.src = reader.result as string
    
          img.onload = () => 
          {
            image.height = img.naturalHeight
            image.width = img.naturalWidth
            this.images.push(image)
  
            let form = this.#builder.group({
              title: [image.title],
              description: [image.description],
              type: [image.type],
              size: [image.size],
              extension: [image.extension],
              height: [image.height],
              width: [image.width],
              sourceFile: [reader.result as string]
            })
            this.forms.push(form)
          }
        }
        else
        {
          this.invalidCount += 1
          this.invalidNames.push(file.name)
        }
      }
    }
  }

  dropFile(fileName: string): void 
  {
    const index = this.images.findIndex(image => image.sourceFile === fileName)

    if (index !== -1) 
    {
      this.images.splice(index, 1)
      this.forms.splice(index, 1)
    }
  }

  onSubmit() 
  {
    for (let i = 0; i < this.forms.length; i++) 
    {
      this.#moodService.Insert( this.forms[i].value ).subscribe
      ({
        error : (e) => console.error(e),
        complete : () => 
        {
          this.#router.navigateByUrl('/moods/mood-details')
        }
      })   
    }
  }

  ngOnDestroy()
  {
    this.menuService.allMenuTriggerOn()
  }
}