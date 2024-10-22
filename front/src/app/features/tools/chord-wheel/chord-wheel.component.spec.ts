import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChordWheelComponent } from './chord-wheel.component';

describe('ChordWheelComponent', () => {
  let component: ChordWheelComponent;
  let fixture: ComponentFixture<ChordWheelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ChordWheelComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ChordWheelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
