import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodDetailsFlowComponent } from './mood-details-flow.component';

describe('MoodDetailsFlowComponent', () => {
  let component: MoodDetailsFlowComponent;
  let fixture: ComponentFixture<MoodDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
