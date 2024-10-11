import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'formatRatio'
})
export class FormatRatioPipe implements PipeTransform {
  transform(width: number, height: number): string {
    if (!width || !height) return '';

    const gcd = this.greatestCommonDivisor(width, height);
    const simplifiedWidth = width / gcd;
    const simplifiedHeight = height / gcd;

    return `${simplifiedWidth} : ${simplifiedHeight}`;
  }

  private greatestCommonDivisor(a: number, b: number): number {
    return b === 0 ? a : this.greatestCommonDivisor(b, a % b);
  }
}