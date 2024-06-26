import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainerNotesComponent } from './trainer-notes.component';

describe('TrainerNotesComponent', () => {
  let component: TrainerNotesComponent;
  let fixture: ComponentFixture<TrainerNotesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TrainerNotesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TrainerNotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
