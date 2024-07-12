import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MediaDetailsFlowComponent } from './media-details-flow.component';

describe('MediaDetailsFlowComponent', () => {
  let component: MediaDetailsFlowComponent;
  let fixture: ComponentFixture<MediaDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MediaDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MediaDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
