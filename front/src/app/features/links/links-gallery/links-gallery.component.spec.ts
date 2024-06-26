import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinksGalleryComponent } from './links-gallery.component';

describe('LinksGalleryComponent', () => {
  let component: LinksGalleryComponent;
  let fixture: ComponentFixture<LinksGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LinksGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LinksGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
