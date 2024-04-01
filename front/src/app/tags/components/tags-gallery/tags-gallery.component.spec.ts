import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagsGalleryComponent } from './tags-gallery.component';

describe('TagsGalleryComponent', () => {
  let component: TagsGalleryComponent;
  let fixture: ComponentFixture<TagsGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagsGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TagsGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
