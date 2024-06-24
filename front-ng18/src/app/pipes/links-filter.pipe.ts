import { Pipe, PipeTransform } from "@angular/core";
import { Link } from "../models/link";

@Pipe({
  name: 'filter',
  pure: false,
  standalone: true
})
export class LinksFilterPipe implements PipeTransform 
{
  transform(links : Link[], term : string) : any 
  {
    return links.filter(link => link.name.toLocaleLowerCase().includes(term.toLocaleLowerCase()))
  }
}