import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotesExComponent } from './notes-ex.component';

describe('NotesExComponent', () => {
  let component: NotesExComponent;
  let fixture: ComponentFixture<NotesExComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NotesExComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NotesExComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
