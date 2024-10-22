import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BottomBarLargerComponent } from './bottom-bar-larger.component';

describe('BottomBarLargerComponent', () => {
  let component: BottomBarLargerComponent;
  let fixture: ComponentFixture<BottomBarLargerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [BottomBarLargerComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BottomBarLargerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
