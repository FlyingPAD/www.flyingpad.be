import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CircleOfFifthsComponent } from './circle-of-fifths.component';

describe('CircleOfFifthsComponent', () => {
  let component: CircleOfFifthsComponent;
  let fixture: ComponentFixture<CircleOfFifthsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CircleOfFifthsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CircleOfFifthsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
