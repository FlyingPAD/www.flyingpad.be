import { Component } from '@angular/core';
import { VideoYouTubeDetails } from '../../models/youtube-test';
import { VideoTestService } from '../../services/video-test.service';

@Component({
  selector: 'app-video-test',
  templateUrl: './video-test.component.html',
  styleUrl: './video-test.component.scss'
})
export class VideoTestComponent 
{
  videoDetails = new VideoYouTubeDetails()

  constructor(private videoService: VideoTestService) { }

  fetchVideoDetails() {
    this.videoService.getVideoDetails('aln3Gws5nPc').subscribe(
      (data: VideoYouTubeDetails) => {
        this.videoDetails = data;
        // Maintenant, vous pouvez accéder aux propriétés de videoDetails, par exemple :
        console.log(this.videoDetails.title);
      },
      error => {
        console.error('Error fetching video details:', error);
      }
    );
  }
}
