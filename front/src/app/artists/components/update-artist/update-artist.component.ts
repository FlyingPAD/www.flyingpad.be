import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs';
import { GetOneArtistResponse, ArtistUpdateForm } from '../../../core/models/artist';
import { RelationsArtistStyleForm } from '../../../core/models/relations';
import { StylesCheckResponse } from '../../../core/models/style';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { RelationService } from '../../../core/services/client/client-relation.service';
import { StyleService } from '../../../core/services/client/client-style.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';

@Component({
  selector: 'app-update-artist',
  templateUrl: './update-artist.component.html',
  styleUrls: ['./update-artist.component.scss']
})
export class UpdateArtistComponent
{
  // Properties :

  #stateArtistService = inject(StateArtistService)
  #artistService = inject(ArtistService)
  #styleService = inject(StyleService)
  #relationService = inject(RelationService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #route = inject(ActivatedRoute)
  #toastr = inject(ToastrService)

  styleId : number | null = null  
  nameSearchField : string = ''

  artistId : number = this.#route.snapshot.params['id']
  artistGetOneResponse : GetOneArtistResponse | null = null
  stylesCheckResponse : StylesCheckResponse | null = null

  form : FormGroup = this.#builder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  
  // Methods :

  ngOnInit()
  {
    this.#artistService.GetOne(this.artistId).subscribe({
      next: (response) => 
      {
        if (response.success && response.artist) 
        {
          this.form.patchValue({ name: response.artist.name })
        }
      },
    })
    this.#styleService.GetStylesCheck(this.artistId).subscribe({
      next : (response) => {
        this.stylesCheckResponse = response
      }
    })
    this.#stateArtistService.nameSearchField$.subscribe((nameSearchField) => { this.nameSearchField = nameSearchField })
    this.#styleService.styleId$.subscribe((input) => { this.styleId = input })
  }

  onSubmit() 
  {
    if (this.form.valid) 
    {
      let artistUpdateForm: ArtistUpdateForm = 
      {
        businessId: this.artistId,
        name: this.form.value.name
      }
  
      this.#artistService.Update(artistUpdateForm).pipe(
        switchMap(() => 
        {
          // Construire la liste des IDs des styles sélectionnés

          let selectedStyleIds = this.stylesCheckResponse?.stylesCheck
            ? this.stylesCheckResponse.stylesCheck
                .filter(style => style.isChecked)
                .map(style => style.businessId)
            : [] // Fournir une valeur par défaut (tableau vide) si stylesCheck est indéfini
  
          // Créer l'objet RASForm pour la mise à jour des relations artiste-style

          let rasForm: RelationsArtistStyleForm = 
          {
            artistId: this.artistId,
            styleIds: selectedStyleIds
          }
  
          // Appel API pour mettre à jour les relations artiste-style

          return this.#relationService.InsertRAS(rasForm)
        }),
        switchMap(() => this.#artistService.GetPage(this.styleId, this.artistId, this.nameSearchField, 20))
      ).subscribe({
        next: () => 
        {
          this.#router.navigateByUrl('artists')
          this.#toastr.success('Artist was successfully updated.')
        },
        error: () => 
        {
          this.#router.navigateByUrl('artists')
          this.#toastr.error('Error: Artist update failed!')
        }
      })
    }
  } 
}