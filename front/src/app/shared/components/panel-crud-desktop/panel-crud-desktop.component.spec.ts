import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PanelCrudDesktopComponent } from './panel-crud-desktop.component';

describe('PanelCrudDesktopComponent', () => {
  let component: PanelCrudDesktopComponent;
  let fixture: ComponentFixture<PanelCrudDesktopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PanelCrudDesktopComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PanelCrudDesktopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
