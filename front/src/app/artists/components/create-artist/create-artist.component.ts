import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { StylesGetAllResponse } from '../../../core/models/style';
import { RelationService } from '../../../core/services/client/client-relation.service';
import { StyleService } from '../../../core/services/client/client-style.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';
import { ArtistsStateService } from '../../../core/services/artists-state.service';

@Component({
  selector: 'app-create-artist',
  templateUrl: './create-artist.component.html',
  styleUrls: ['./create-artist.component.scss']
})
export class CreateArtistComponent
{
  // Properties :
  
  #stateArtistService = inject(StateArtistService)
  #artistsService = inject(ArtistsStateService)
  #styleService = inject(StyleService)
  #relationService = inject(RelationService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  artistId : number = 0
  nameSearchField: string = ''
  stylesGetAllResponse : StylesGetAllResponse | null = null

  form : FormGroup = this.#builder.group
  ({
    name : ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  // Methods :

  ngOnInit()
  {
    this.#stateArtistService.nameSearchField$.subscribe((nameSearchField) => { this.nameSearchField = nameSearchField })
    this.#styleService.GetAll().subscribe({
      next : (response) => 
      {
        this.stylesGetAllResponse = response

        this.stylesGetAllResponse.stylesList.forEach((style) => 
        {
          style.isChecked = false
        })
      }
    })
  }

  onSubmit() 
  {
    if (this.form.valid && this.stylesGetAllResponse && this.stylesGetAllResponse.stylesList) 
    {
      this.#artistsService.CreateArtist(this.form.value).subscribe({
        next : (response) => 
        {
          // Récupérer l'ID de l'artiste nouvellement créé

          let artistId = response.artist?.businessId
  
          if (this.stylesGetAllResponse && artistId !== undefined) 
          {
            // Récupérer les styles 'checked' dans un tableau

            let selectedStyles : number[] = []

            for (let style of this.stylesGetAllResponse.stylesList) 
            {
              if (style.isChecked) 
              {
                selectedStyles.push(style.businessId);
              }
            }
  
            // Créer un objet pour les relations entre l'artiste et les styles

            let rasForm = 
            {
              artistId : artistId,
              styleIds : selectedStyles
            }
  
            // Ajouter les relations entre l'artiste et les styles

            this.#relationService.InsertRAS(rasForm).subscribe({
              next: () => 
              {
                this.#router.navigateByUrl('artists')
                this.#toastr.success('Artist successfully created.')
              },
              error: () => 
              {
                this.#toastr.error('Error creating relations.')
              }
            })
          }
        },
        error: () => 
        {
          this.#toastr.error('Error creating artist.')
        }
      })
    }
  }
  
}