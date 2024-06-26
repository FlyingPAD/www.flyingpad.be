import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodsGalleryFlowComponent } from './moods-gallery-flow.component';

describe('MoodsGalleryFlowComponent', () => {
  let component: MoodsGalleryFlowComponent;
  let fixture: ComponentFixture<MoodsGalleryFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodsGalleryFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodsGalleryFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
