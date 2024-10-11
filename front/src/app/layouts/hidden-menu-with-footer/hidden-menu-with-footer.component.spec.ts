import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HiddenMenuWithFooterComponent } from './hidden-menu-with-footer.component';

describe('HiddenMenuWithFooterComponent', () => {
  let component: HiddenMenuWithFooterComponent;
  let fixture: ComponentFixture<HiddenMenuWithFooterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HiddenMenuWithFooterComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HiddenMenuWithFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
