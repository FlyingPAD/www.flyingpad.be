import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotesTradComponent } from './notes-trad.component';

describe('NotesTradComponent', () => {
  let component: NotesTradComponent;
  let fixture: ComponentFixture<NotesTradComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NotesTradComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NotesTradComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
