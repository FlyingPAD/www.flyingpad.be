import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditMediumComponent } from './edit-medium.component';

describe('EditMediumComponent', () => {
  let component: EditMediumComponent;
  let fixture: ComponentFixture<EditMediumComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditMediumComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditMediumComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
