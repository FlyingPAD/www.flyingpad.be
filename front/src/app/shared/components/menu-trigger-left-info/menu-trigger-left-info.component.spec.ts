import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuTriggerLeftInfoComponent } from './menu-trigger-left-info.component';

describe('MenuTriggerLeftInfoComponent', () => {
  let component: MenuTriggerLeftInfoComponent;
  let fixture: ComponentFixture<MenuTriggerLeftInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MenuTriggerLeftInfoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MenuTriggerLeftInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
