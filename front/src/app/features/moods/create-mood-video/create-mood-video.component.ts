import { Component, inject } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-mood-video',
  templateUrl: './create-mood-video.component.html',
  styleUrl: './create-mood-video.component.scss'
})
export class CreateMoodVideoComponent {
    #flowService = inject(FlowService)
    #formBuilder = inject(FormBuilder) 
    #router = inject(Router)
 
    form : FormGroup = this.#formBuilder.group({ title: [''] })
    
    public name! : string
    public extension! : string
    public size! : number
    
    url! : string
  
    width! : number
    height! : number
    duration! : number
    sourcefile! : string
  
    loadFile(event : any): void {   
      this.getFileDetails(event)
  
      if (
        this.extension === "video/mp4" && this.size < 50000000 || 
        this.extension === "video/webm" && this.size < 50000000 ) {
        this.videoForm(event)
      }
    }
  
    getFileDetails (event : any): void {
      for (var i = 0; i < event.target.files.length; i++) 
      { 
        this.name = event.target.files[i].name;
        this.extension = event.target.files[i].type;
        this.size = event.target.files[i].size;
      }
    }
    videoForm (event : any): void {
      var reader = new FileReader()
  
      reader.onload = (event : any) => 
      {
        this.url = event.target.result;
        this.sourcefile = reader?.result as string;
  
        this.form = this.#formBuilder.group
        ({
          title: ["...", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
          description: ["...", [Validators.required, Validators.minLength(1), Validators.maxLength(500)]],
          type: [2],
          size: [this.size],
          extension: [this.extension.substring(6)],
          height: [this.height],
          width: [this.width],
          duration: [Math.floor(this.duration)],
          sourcefile: [this.sourcefile]
        })
      }
      reader.onerror = (event: any) => {
        console.log("File could not be read: " + event.target.error.code);
      }
      this.getVideoDetails(event.target.files[0])
      reader.readAsDataURL(event.target.files[0])     
    }
 
    getVideoDetails(file : File) {
      var reader = new FileReader();
      reader.onload = (e: any) => {
        var video = document.createElement('video');
        video.src = e.target.result;
        video.onloadedmetadata = (ev: any) => {
          this.width = ev.target.videoWidth;
          this.height = ev.target.videoHeight;
          this.duration = ev.target.duration;
        };
      };
      reader.readAsDataURL(file);
    }  

    onUpload(): void {   
      this.form = this.#formBuilder.group
      ({
        title: ["...", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        description: ["...", [Validators.required, Validators.minLength(1), Validators.maxLength(500)]],
        type: [2],
        size: [this.size],
        extension: [this.extension.substring(6)],
        height: [this.height],
        width: [this.width],
        duration: [Math.floor(this.duration)],
        sourceFile: [this.sourcefile]
      })
      if(this.form.valid)
      {      
        this.#flowService.CreateVideo( this.form.value ).subscribe({
          next : () => {
            this.#router.navigateByUrl('moods')
          },
          error: (e) => console.error(e),
        })
      }
    }
  }