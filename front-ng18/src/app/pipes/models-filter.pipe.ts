import { Pipe, PipeTransform } from "@angular/core";
import { Model } from "../models/model";

@Pipe({
  name: 'filter',
  pure: false,
  standalone: true
})
export class ModelsFilterPipe implements PipeTransform 
{
  transform(models : Model[], term : string) : any 
  {
    return models.filter(model => model.pseudonym.toLocaleLowerCase().includes(term.toLocaleLowerCase()))
  }
}