import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuTriggerRightSearchComponent } from './menu-trigger-right-search.component';

describe('MenuTriggerRightSearchComponent', () => {
  let component: MenuTriggerRightSearchComponent;
  let fixture: ComponentFixture<MenuTriggerRightSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MenuTriggerRightSearchComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MenuTriggerRightSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
