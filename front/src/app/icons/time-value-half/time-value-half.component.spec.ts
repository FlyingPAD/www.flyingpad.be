import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeValueHalfComponent } from './time-value-half.component';

describe('TimeValueHalfComponent', () => {
  let component: TimeValueHalfComponent;
  let fixture: ComponentFixture<TimeValueHalfComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TimeValueHalfComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TimeValueHalfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
