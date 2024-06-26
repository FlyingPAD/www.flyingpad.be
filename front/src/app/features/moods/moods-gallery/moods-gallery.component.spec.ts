import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodsGalleryComponent } from './moods-gallery.component';

describe('MoodsGalleryComponent', () => {
  let component: MoodsGalleryComponent;
  let fixture: ComponentFixture<MoodsGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodsGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodsGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
