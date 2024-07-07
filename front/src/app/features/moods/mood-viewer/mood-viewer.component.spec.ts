import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodViewerComponent } from './mood-viewer.component';

describe('MoodViewerComponent', () => {
  let component: MoodViewerComponent;
  let fixture: ComponentFixture<MoodViewerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodViewerComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodViewerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
