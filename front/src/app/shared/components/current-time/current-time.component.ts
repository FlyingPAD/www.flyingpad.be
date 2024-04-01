import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-current-time',
  templateUrl: './current-time.component.html',
  styleUrls: ['./current-time.component.scss']
})
export class CurrentTimeComponent implements OnInit, OnDestroy
{
  // Properties :

  currentDate : Date = new Date()
  intervalId : any = 1

  // Methods :

  ngOnInit() : void 
  {   
    this.dateStart()
  }

  ngOnDestroy() : void
  {
    this.dateStop()
  }

  dateStart() : void
  {
    this.callCurrentDate()
    this.intervalId = setInterval(() => 
    {
      this.callCurrentDate()
    }, 
    1000)
  }

  dateStop() : void
  {
    if (this.intervalId) 
    {
      clearInterval(this.intervalId)
    }
  }

  callCurrentDate() : void
  {
    this.currentDate = new Date()
  }
}