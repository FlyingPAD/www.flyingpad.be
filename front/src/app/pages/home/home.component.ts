import { Component, OnInit, inject } from '@angular/core';
import { UserService } from '../../services/http/user.service';
import { Router } from '@angular/router';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { environment } from '../../../environments/environment';
import { MoodService } from '../../services/http/mood.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit {
  #moodService = inject(MoodService)
  #userService = inject(UserService)
  #imageURLService = inject(ImageUrlService)
  #router = inject(Router)

  public moodsFlow = this.#moodService.moodsFlow
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