import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeValueSixteenthComponent } from './time-value-sixteenth.component';

describe('TimeValueSixteenthComponent', () => {
  let component: TimeValueSixteenthComponent;
  let fixture: ComponentFixture<TimeValueSixteenthComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TimeValueSixteenthComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TimeValueSixteenthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
