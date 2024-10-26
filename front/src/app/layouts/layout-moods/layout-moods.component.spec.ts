import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutMoodsComponent } from './layout-moods.component';

describe('LayoutMoodsComponent', () => {
  let component: LayoutMoodsComponent;
  let fixture: ComponentFixture<LayoutMoodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LayoutMoodsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LayoutMoodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
