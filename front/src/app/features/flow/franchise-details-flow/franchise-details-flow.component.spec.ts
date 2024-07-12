import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FranchiseDetailsFlowComponent } from './franchise-details-flow.component';

describe('FranchiseDetailsFlowComponent', () => {
  let component: FranchiseDetailsFlowComponent;
  let fixture: ComponentFixture<FranchiseDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FranchiseDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FranchiseDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
