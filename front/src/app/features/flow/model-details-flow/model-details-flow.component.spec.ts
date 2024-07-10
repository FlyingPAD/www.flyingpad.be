import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModelDetailsFlowComponent } from './model-details-flow.component';

describe('ModelDetailsFlowComponent', () => {
  let component: ModelDetailsFlowComponent;
  let fixture: ComponentFixture<ModelDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ModelDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ModelDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
