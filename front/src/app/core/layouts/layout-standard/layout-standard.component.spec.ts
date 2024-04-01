import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutStandardComponent } from './layout-standard.component';

describe('LayoutStandardComponent', () => {
  let component: LayoutStandardComponent;
  let fixture: ComponentFixture<LayoutStandardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LayoutStandardComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LayoutStandardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
