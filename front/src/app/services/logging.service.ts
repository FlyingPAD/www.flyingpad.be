import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggingService {
  public error(error: unknown, context?: string): void {
    console.error(`[Error]${context ? ' ' + context : ''}:`, error);
  }

  public info(message: string, context?: string): void {
    console.info(`[Info]${context ? ' ' + context : ''}:`, message);
  }

  public warn(message: string, context?: string): void {
    console.warn(`[Warn]${context ? ' ' + context : ''}:`, message);
  }
}