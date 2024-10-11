import { Component, HostListener, inject, Input, OnDestroy, OnInit } from '@angular/core';
import { TagsCheckBoxesList } from '../../../models/tags-list';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';
import { MoodFull } from '../../../models/mood';
import { Subscription } from 'rxjs';
import { RelationsMoodTagForm } from '../../../models/relations';

@Component({
  selector: 'app-edition-tags',
  templateUrl: './edition-tags.component.html',
  styleUrl: './edition-tags.component.scss'
})
export class EditionTagsComponent implements OnInit, OnDestroy {
  @Input() mood! : MoodFull

  #flowService = inject(FlowService)
  #toastr = inject(ToastrService)

  tagsList! : TagsCheckBoxesList[]

  subscription : Subscription = new Subscription()
  subscriptionRelation : Subscription = new Subscription()


  ngOnInit(): void {
    this.subscription = this.#flowService.getTagsCheckBoxByMood(this.mood.businessId).subscribe(data => this.tagsList = data)
  }
  ngOnDestroy(): void {
    this.subscription.unsubscribe()
    this.subscriptionRelation.unsubscribe()
  }

  onSubmit(): void {
    let rmtForm : RelationsMoodTagForm = {
      moodId : this.mood.businessId,
      tagIds : this.tagsList.flatMap(list =>
        list.tagsCheckBoxes.filter(tag => tag.isChecked).map(tag => tag.businessId))
    }
  
    if (rmtForm.tagIds.length === 0) {
      this.#toastr.error('No tags selected.')
      return
    }
  
    this.subscriptionRelation = this.#flowService.InsertRMT(rmtForm).subscribe()
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}