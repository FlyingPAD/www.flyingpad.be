import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditFranchiseComponent } from './edit-franchise.component';

describe('EditFranchiseComponent', () => {
  let component: EditFranchiseComponent;
  let fixture: ComponentFixture<EditFranchiseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditFranchiseComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditFranchiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
