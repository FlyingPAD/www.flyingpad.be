import { Component, inject, OnInit } from '@angular/core';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrl: './tags.component.scss'
})
export class TagsComponent implements OnInit {
  #flowService = inject(FlowService)
  flow = this.#flowService.flow

  ngOnInit(): void {
    window.scrollTo(0, 0)
    const businessIdString = `${this.flow()?.tag?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  updateTagId(tagId : number | null) {
    this.#flowService.updateTagId( tagId )
  }

  scrollToStart(elementId : string): void {
    const domElement = document.getElementById( elementId )

    if (domElement) {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" })
    }
  }
}