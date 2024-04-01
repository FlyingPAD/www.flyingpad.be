import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PanelCrudMobileComponent } from './panel-crud-mobile.component';

describe('PanelCrudMobileComponent', () => {
  let component: PanelCrudMobileComponent;
  let fixture: ComponentFixture<PanelCrudMobileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PanelCrudMobileComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(PanelCrudMobileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
