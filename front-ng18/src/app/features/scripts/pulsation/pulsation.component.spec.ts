import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PulsationComponent } from './pulsation.component';

describe('PulsationComponent', () => {
  let component: PulsationComponent;
  let fixture: ComponentFixture<PulsationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PulsationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PulsationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
