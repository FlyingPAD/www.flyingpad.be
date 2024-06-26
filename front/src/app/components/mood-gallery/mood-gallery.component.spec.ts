import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodGalleryComponent } from './mood-gallery.component';

describe('MoodGalleryComponent', () => {
  let component: MoodGalleryComponent;
  let fixture: ComponentFixture<MoodGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
