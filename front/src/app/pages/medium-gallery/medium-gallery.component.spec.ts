import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MediumGalleryComponent } from './medium-gallery.component';

describe('MediumGalleryComponent', () => {
  let component: MediumGalleryComponent;
  let fixture: ComponentFixture<MediumGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MediumGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MediumGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
