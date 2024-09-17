import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteFranchiseComponent } from './delete-franchise.component';

describe('DeleteFranchiseComponent', () => {
  let component: DeleteFranchiseComponent;
  let fixture: ComponentFixture<DeleteFranchiseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteFranchiseComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteFranchiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
