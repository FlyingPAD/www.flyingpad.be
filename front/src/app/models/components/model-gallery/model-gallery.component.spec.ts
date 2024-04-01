import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModelGalleryComponent } from './model-gallery.component';

describe('ModelGalleryComponent', () => {
  let component: ModelGalleryComponent;
  let fixture: ComponentFixture<ModelGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ModelGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ModelGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
