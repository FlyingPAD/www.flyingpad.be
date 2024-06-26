import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FranchisesGalleryComponent } from './franchises-gallery.component';

describe('FranchisesGalleryComponent', () => {
  let component: FranchisesGalleryComponent;
  let fixture: ComponentFixture<FranchisesGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FranchisesGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FranchisesGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
