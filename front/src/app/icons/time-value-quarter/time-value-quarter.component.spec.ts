import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeValueQuarterComponent } from './time-value-quarter.component';

describe('TimeValueQuarterComponent', () => {
  let component: TimeValueQuarterComponent;
  let fixture: ComponentFixture<TimeValueQuarterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TimeValueQuarterComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TimeValueQuarterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
