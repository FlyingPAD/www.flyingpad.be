import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChordsComponent } from './chords.component';

describe('ChordsComponent', () => {
  let component: ChordsComponent;
  let fixture: ComponentFixture<ChordsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ChordsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChordsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
