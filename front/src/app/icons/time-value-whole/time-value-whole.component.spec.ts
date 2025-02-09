import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeValueWholeComponent } from './time-value-whole.component';

describe('TimeValueWholeComponent', () => {
  let component: TimeValueWholeComponent;
  let fixture: ComponentFixture<TimeValueWholeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TimeValueWholeComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TimeValueWholeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
