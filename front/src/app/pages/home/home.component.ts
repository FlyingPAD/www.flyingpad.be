import { Component, OnInit, inject } from '@angular/core';
import { UserService } from '../../services/http/user.service';
import { Router } from '@angular/router';
import { ImageUrlService } from '../../services/image-url.service';
import { FlowService } from '../../services/http/flow.service';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit {
  #flowService = inject(FlowService)
  #userService = inject(UserService)
  #imageURLService = inject(ImageUrlService)
  #router = inject(Router)

  public flow = this.#flowService.flow
  public user = this.#userService.user
  public environment : string = environment.apiBaseUrl
  

  ngOnInit() : void {
    if(this.user()?.role === 2) {
      this.#router.navigateByUrl('/dashboard')
    }
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string { 
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}