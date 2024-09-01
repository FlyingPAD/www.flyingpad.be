import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateFranchiseComponent } from './create-franchise.component';

describe('CreateFranchiseComponent', () => {
  let component: CreateFranchiseComponent;
  let fixture: ComponentFixture<CreateFranchiseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateFranchiseComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateFranchiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
