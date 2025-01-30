import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { ButtonTopService } from '../../services/button-top.service';
import { MoodsService } from '../../services/moods.service';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrl: './tags.component.scss'
})
export class TagsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #moodsService = inject(MoodsService)
  #buttonTopService = inject(ButtonTopService)
  
  public flow = this.#flowService.flow

  ngOnInit(): void {
    window.scrollTo(0, 0)
    this.#buttonTopService.setShowButtonTop(true)
  }

  ngOnDestroy(): void {
    this.#buttonTopService.setShowButtonTop(false)
  }

  public updateTagId(tagId : number | null) {
    this.#flowService.updateTagId( tagId )
    this.#moodsService.updateMoodMenuState('gallery')
  }
}