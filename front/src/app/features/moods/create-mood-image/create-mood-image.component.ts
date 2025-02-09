import { Component, ElementRef, ViewChild, inject } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ImageForm } from '../../../interfaces/mood-image';
import { FlowService } from '../../../services/flow.service';
import { NotificationService } from '../../../services/notification.service';
import { LowerCasePipe } from '@angular/common';

@Component({
  selector: 'app-create-mood-image',
  templateUrl: './create-mood-image.component.html',
  styleUrl: './create-mood-image.component.scss'
})
export class CreateMoodImageComponent {
  #flowService = inject(FlowService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #notificationService = inject(NotificationService)

  public images : ImageForm[] = []
  public forms : FormGroup[] = []
  public invalidCount : number = 0
  public invalidNames : string[] = []

  @ViewChild('originalInput') originalInput!: ElementRef<HTMLInputElement>

  public onClickHack(): void {
    this.originalInput?.nativeElement.click()
  }

  public onFileSelect(event : any) {
    for (let i = 0; i < event.target.files.length; i++) {
      const file = event.target.files[i]
  
      const reader = new FileReader()
      reader.readAsDataURL(file)

      reader.onload = () => {
        if(file.name.slice(file.name.lastIndexOf('.') + 1).toLowerCase() === 'gif' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1).toLowerCase() === 'jpg' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1).toLowerCase() === 'jpeg' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1).toLowerCase() === 'png' && file.size < 50000000
        || file.name.slice(file.name.lastIndexOf('.') + 1).toLowerCase() === 'webp' && file.size < 50000000) {
          const image: ImageForm = {
            name: '...',
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
    
          img.onload = () => {
            image.height = img.naturalHeight
            image.width = img.naturalWidth
            this.images.push(image)
  
            let form = this.#builder.group({
              name: [image.name],
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
        else {
          this.invalidCount += 1
          this.invalidNames.push(file.name)
        }
      }
    }
  }

  public dropFile(fileName: string): void {
    const index = this.images.findIndex(image => image.sourceFile === fileName)

    if (index !== -1) {
      this.images.splice(index, 1)
      this.forms.splice(index, 1)
    }
  }

  public onSubmit(): void {
    if(this.forms.length > 0) {
      for (let i = 0; i < this.forms.length; i++) {
        this.#flowService.CreateImage( this.forms[i].value ).subscribe()   
      }
      this.#router.navigateByUrl('/moods')
    }
    else this.#notificationService.error('No images were selected ...')
  }

  public backToDashboard(): void {
    this.#router.navigateByUrl('/dashboard')
  }
}