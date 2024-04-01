import { Component, inject } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { RelationService } from '../../../core/services/client/client-relation.service';
import { StyleService } from '../../../core/services/client/client-style.service';

@Component({
  selector: 'app-delete-style',
  templateUrl: './delete-style.component.html',
  styleUrls: ['./delete-style.component.scss']
})
export class DeleteStyleComponent
{
  #artistService = inject(ArtistService)
  #styleService = inject(StyleService)
  #relationService = inject(RelationService)

  #router = inject(Router)
  #route = inject(ActivatedRoute)
  #toastr = inject(ToastrService)

  styleId : number = this.#route.snapshot.params['id']
  styleGetOneResponse$ = this.#styleService.GetOne( this.styleId )
  checkRelationsArtistStyleByStyleResponse$ = this.#relationService.CheckRelationsArtistStyleByStyle( this.styleId )

  ngOnInit() 
  {
    this.#route.params.subscribe(params => 
    {
      this.styleId = params['id']

      if (this.styleId) 
      {
        this.loadStyle()
      }
      else 
      {
        this.#toastr.error('Invalid style ID.')
        this.#router.navigateByUrl('artists')
      }
    })
  }

  loadStyle() 
  {
    this.#styleService.GetOne(this.styleId).subscribe({
      error: () => {
        this.#toastr.error('Style was not found.')
        this.#router.navigateByUrl('artists')
      }
    })
  }

  onDelete() 
  {
    this.#styleService.Delete(this.styleId).pipe(
      switchMap(() => this.#styleService.GetAll()),
      switchMap(() => this.#styleService.Count()),
      switchMap(() => this.#artistService.GetPage(null, null, '', 20))
    ).subscribe({
      next: () => {
        this.#styleService.updateStyleID(null)
        this.#toastr.success('Style was successfully deleted.')
        this.#router.navigateByUrl('artists')
      },
      error: (err) => {
        this.#toastr.error('Error: ' + err.message)
      }
    })
  }
}