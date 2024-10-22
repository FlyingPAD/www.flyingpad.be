import { Pipe, PipeTransform, inject } from '@angular/core'
import { TranslateService } from '@ngx-translate/core'

@Pipe({
  name: 'formatDuration',
  pure: true
})
export class FormatDurationPipe implements PipeTransform {
  private translate = inject(TranslateService)

  transform(seconds: number): string {
    const singularPlurals = {
      second: this.translate.instant('title.second'),
      seconds: this.translate.instant('title.seconds'),
      minute: this.translate.instant('title.minute'),
      minutes: this.translate.instant('title.minutes'),
      hour: this.translate.instant('title.hour'),
      hours: this.translate.instant('title.hours')
    }

    if (seconds < 60) {
      const unit = seconds === 1 ? singularPlurals.second : singularPlurals.seconds
      return `${seconds.toFixed(0)} ${unit}`
    } 

    if (seconds >= 60 && seconds < 3600) {
      const minutes = (seconds / 60).toFixed(0)
      const unit = minutes === '1' ? singularPlurals.minute : singularPlurals.minutes
      return `${minutes} ${unit}`
    } 

    if (seconds >= 3600 && seconds < 216000) {
      const hours = ((seconds / 60) / 60).toFixed(0)
      const unit = hours === '1' ? singularPlurals.hour : singularPlurals.hours
      return `${hours} ${unit}`
    }

    return seconds.toFixed(0)
  }
}