import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuMainLightComponent } from './menu-main-light.component';

describe('MenuMainLightComponent', () => {
  let component: MenuMainLightComponent;
  let fixture: ComponentFixture<MenuMainLightComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MenuMainLightComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MenuMainLightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
