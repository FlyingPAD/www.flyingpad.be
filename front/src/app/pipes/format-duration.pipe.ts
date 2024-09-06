import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatDuration'
})
export class FormatDurationPipe implements PipeTransform 
{
  transform(seconds : number) : string {
    if (seconds < 60) {
      return seconds.toFixed(0) + " seconds"
    }
    if (seconds > 60 && seconds < 3600) {
      return (seconds / 60).toFixed(0) + " minutes"
    }
    if (seconds > 3600 && seconds < 216000) {
      return ((seconds / 60) / 60).toFixed(0) + " hours"
    }
    else {
      return seconds.toFixed(0)
    }
  }
}