import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuTriggerRightFilterComponent } from './menu-trigger-right-filter.component';

describe('MenuTriggerRightFilterComponent', () => {
  let component: MenuTriggerRightFilterComponent;
  let fixture: ComponentFixture<MenuTriggerRightFilterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MenuTriggerRightFilterComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MenuTriggerRightFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
