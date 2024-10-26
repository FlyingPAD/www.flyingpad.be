import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutToolsComponent } from './layout-tools.component';

describe('LayoutToolsComponent', () => {
  let component: LayoutToolsComponent;
  let fixture: ComponentFixture<LayoutToolsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LayoutToolsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LayoutToolsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
