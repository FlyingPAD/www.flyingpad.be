import { trigger, state, style, animate, transition, query, group } from '@angular/animations';

export const slideInAnimation = trigger('routeAnimations', [
  transition('* <=> *', [
    style({ position: 'relative' }),
    query(':enter, :leave', [
      style({
        position: 'absolute',
        width: '100%',
        top: 0,
        left: 0
      })
    ], { optional: true }),
    query(':enter', [
      style({ left: '-100%' })
    ], { optional: true }),
    query(':leave', [
      style({ left: '0%' })
    ], { optional: true }),
    group([
      query(':leave', [
        animate('300ms ease-out', style({ left: '100%' }))
      ], { optional: true }),
      query(':enter', [
        animate('300ms ease-out', style({ left: '0%' }))
      ], { optional: true })
    ])
  ])
]);

export const fadeInOut = trigger('fadeInOut', [
  transition(':enter', [
    style({ opacity: 0 }),
    animate('1s ease-in', style({ opacity: 1 }))
  ]),
  transition(':leave', [
    animate('1s ease-out', style({ opacity: 0 }))
  ])
]);

export const zoomInZoomOut = trigger('zoomInZoomOut', [
  transition(':enter', [
    style({ transform: 'scale(0)' }),
    animate('300ms ease-in', style({ transform: 'scale(1)' }))
  ]),
  transition(':leave', [
    animate('300ms ease-out', style({ transform: 'scale(0)' }))
  ])
]);

export const rotate = trigger('rotate', [
  state('default', style({ transform: 'rotate(0)' })),
  state('rotated', style({ transform: 'rotate(180deg)' })),
  transition('default <=> rotated', animate('500ms ease-in-out'))
]);

export const elasticEffect = trigger('elasticEffect', [
  transition(':enter', [
    style({ height: '0px', opacity: 0 }),
    animate('600ms ease-in-out', style({ height: '*', opacity: 1 }))
  ]),
  transition(':leave', [
    animate('600ms ease-in-out', style({ height: '0px', opacity: 0 }))
  ])
]);
