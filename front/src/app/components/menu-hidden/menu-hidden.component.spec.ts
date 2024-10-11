import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuHiddenComponent } from './menu-hidden.component';

describe('MenuHiddenComponent', () => {
  let component: MenuHiddenComponent;
  let fixture: ComponentFixture<MenuHiddenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MenuHiddenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MenuHiddenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
