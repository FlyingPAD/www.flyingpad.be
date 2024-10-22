import { Pipe, PipeTransform, inject } from '@angular/core'
import { TranslateService } from '@ngx-translate/core'

@Pipe({
  name: 'localizedDate',
  pure: false
})
export class LocalizedDatePipe implements PipeTransform {
  private translate = inject(TranslateService)

  private dateFormats: { [key: string]: Intl.DateTimeFormatOptions } = {
    en: { month: 'long', day: 'numeric', year: 'numeric', hour: '2-digit', minute: '2-digit' },
    fr: { day: 'numeric', month: 'long', year: 'numeric', hour: '2-digit', minute: '2-digit' },
  }

  transform(value: Date | string | number, langOverride?: string, showTime: boolean = true): string {
    let language = langOverride || this.translate.currentLang || 'en'
    
    let formatOptions = Object.assign({}, this.dateFormats[language] || this.dateFormats['en'])
    
    if (!showTime) {
      delete formatOptions.hour
      delete formatOptions.minute
    }

    const date = typeof value === 'string' || typeof value === 'number' ? new Date(value) : value

    let formattedDate = new Intl.DateTimeFormat(language, formatOptions).format(date)
    
    formattedDate = formattedDate.replace(/ at | à /g, ' | ').replace(/AM|PM/g, '')

    return formattedDate.trim()
  }
}