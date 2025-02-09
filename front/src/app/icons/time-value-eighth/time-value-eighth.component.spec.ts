import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeValueEighthComponent } from './time-value-eighth.component';

describe('TimeValueEighthComponent', () => {
  let component: TimeValueEighthComponent;
  let fixture: ComponentFixture<TimeValueEighthComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TimeValueEighthComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TimeValueEighthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
