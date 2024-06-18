import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuMainFullComponent } from './menu-main-full.component';

describe('MenuMainFullComponent', () => {
  let component: MenuMainFullComponent;
  let fixture: ComponentFixture<MenuMainFullComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MenuMainFullComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MenuMainFullComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
