import { Component, HostListener, inject, OnInit, ViewChild, ElementRef } from '@angular/core'
import { TimelineService } from '../../../services/tools/timeline.service'
import { Timeline } from '../../../models/music-tools/timeline'

@Component({
  selector: 'app-timeline',
  templateUrl: './timeline.component.html',
  styleUrls: ['./timeline.component.scss']
})
export class TimelineComponent implements OnInit {
  timelineService = inject(TimelineService)
  windowWidth: number = window.innerWidth
  timelines: Timeline[] = [
    new Timeline()
  ]

  @ViewChild('timelineContainer') timelineContainer!: ElementRef<HTMLDivElement>
  
  private firstFocus: boolean = true // Drapeau pour détecter le premier focus

  ngOnInit(): void {
    setTimeout(() => {
      this.centerOnCurrentYear()
    }, 500)
  }

  @HostListener('window:resize', ['$event'])
  onResize(event: any): void {
    this.windowWidth = event.target.innerWidth
  }

  getViewBox(timeline: Timeline): string {
    return `0 0 ${timeline.timelineWidth} 300`
  }

  setSelectedYear(year: number): void {
    this.timelines[0].selectedyear = year
  }

  goToSelectedYear(): void {
    this.timelines[0].currentYear = this.timelines[0].selectedyear
    this.centerOnCurrentYear()
  }

  centerOnCurrentYear(): void {
    const currentYear = this.timelines[0].currentYear
    const currentMonth = new Date().getMonth()
    const graduations = this.timelines[0].generateGraduations(this.timelines[0].zoomLevels[this.timelines[0].currentZoomLevel])

    const position = graduations.find(graduation => {
      if (this.timelines[0].zoomLevels[this.timelines[0].currentZoomLevel] === 1 / 12) {
        return graduation.year === currentYear && graduation.month === currentMonth
      } else if (this.timelines[0].zoomLevels[this.timelines[0].currentZoomLevel] === 1) {
        return graduation.year === currentYear
      } else {
        return Math.floor(currentYear / this.timelines[0].zoomLevels[this.timelines[0].currentZoomLevel]) * this.timelines[0].zoomLevels[this.timelines[0].currentZoomLevel] === graduation.year
      }
    })?.position

    if (position !== undefined) {
      this.centerOnPosition(position)
    } else {
      console.warn('Année actuelle introuvable dans les graduations')
    }
  }

  centerOnPosition(position: number): void {
    if (this.timelineContainer && this.timelineContainer.nativeElement) {
      const container = this.timelineContainer.nativeElement
      const halfWidth = container.clientWidth / 2
      const scrollPosition = Math.max(0, position - halfWidth)
      
      if (this.firstFocus) {
        container.scrollTo({
          left: scrollPosition,
          behavior: 'smooth'
        })
        this.firstFocus = false
      } else {
        container.scrollLeft = scrollPosition
      }
    } else {
      console.warn('Le conteneur de la timeline est indisponible')
    }
  }

  getTrianglePoints(cx: number, cy: number, size: number): string {
    const height = (Math.sqrt(3) / 2) * size
    const points = [
      `${cx},${cy + height / 2}`,
      `${cx - size / 2},${cy - height / 2}`,
      `${cx + size / 2},${cy - height / 2}`
    ]
    return points.join(' ')
  }

  zoomIn(): void {
    this.timelines[0].zoomIn()
    setTimeout(() => this.centerOnCurrentYear(), 200)
  }

  zoomOut(): void {
    this.timelines[0].zoomOut()
    setTimeout(() => this.centerOnCurrentYear(), 200)
  }
}