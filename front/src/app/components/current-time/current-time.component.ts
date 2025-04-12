import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-current-time',
  templateUrl: './current-time.component.html',
  styleUrls: ['./current-time.component.scss']
})
export class CurrentTimeComponent implements OnInit, OnDestroy {
  #intervalId: any = 1
  public currentDate: Date = new Date()

  ngOnInit(): void {
    this.dateStart()
  }

  ngOnDestroy(): void {
    this.dateStop()
  }

  private dateStart(): void {
    this.callCurrentDate()
    this.#intervalId = setInterval(() => {
      this.callCurrentDate()
    },
      1000)
  }

  private dateStop(): void {
    if (this.#intervalId) {
      clearInterval(this.#intervalId)
    }
  }

  private callCurrentDate(): void {
    this.currentDate = new Date()
  }
}