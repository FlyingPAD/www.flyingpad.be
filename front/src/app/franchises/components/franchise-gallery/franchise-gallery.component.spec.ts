import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FranchiseGalleryComponent } from './franchise-gallery.component';

describe('FranchiseGalleryComponent', () => {
  let component: FranchiseGalleryComponent;
  let fixture: ComponentFixture<FranchiseGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FranchiseGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FranchiseGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
