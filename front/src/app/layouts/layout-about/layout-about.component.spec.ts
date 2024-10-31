import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutAboutComponent } from './layout-about.component';

describe('LayoutAboutComponent', () => {
  let component: LayoutAboutComponent;
  let fixture: ComponentFixture<LayoutAboutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LayoutAboutComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LayoutAboutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
