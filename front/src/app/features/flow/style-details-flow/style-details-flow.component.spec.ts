import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StyleDetailsFlowComponent } from './style-details-flow.component';

describe('StyleDetailsFlowComponent', () => {
  let component: StyleDetailsFlowComponent;
  let fixture: ComponentFixture<StyleDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [StyleDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(StyleDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
