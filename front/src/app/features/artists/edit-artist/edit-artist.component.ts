import { Component, Input } from '@angular/core';
import { ArtistFull } from '../../../models/artist';

@Component({
  selector: 'app-edit-artist',
  templateUrl: './edit-artist.component.html',
  styleUrl: './edit-artist.component.scss'
})
export class EditArtistComponent {
  @Input() artist! : ArtistFull | undefined
}
