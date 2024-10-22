import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuitarTunerComponent } from './guitar-tuner.component';

describe('GuitarTunerComponent', () => {
  let component: GuitarTunerComponent;
  let fixture: ComponentFixture<GuitarTunerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [GuitarTunerComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(GuitarTunerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
