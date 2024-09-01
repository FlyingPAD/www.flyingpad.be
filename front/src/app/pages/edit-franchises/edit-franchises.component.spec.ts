import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditFranchisesComponent } from './edit-franchises.component';

describe('EditFranchisesComponent', () => {
  let component: EditFranchisesComponent;
  let fixture: ComponentFixture<EditFranchisesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditFranchisesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditFranchisesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
