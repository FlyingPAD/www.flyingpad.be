import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodDetailsTagsComponent } from './mood-details-tags.component';

describe('MoodDetailsTagsComponent', () => {
  let component: MoodDetailsTagsComponent;
  let fixture: ComponentFixture<MoodDetailsTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodDetailsTagsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodDetailsTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
