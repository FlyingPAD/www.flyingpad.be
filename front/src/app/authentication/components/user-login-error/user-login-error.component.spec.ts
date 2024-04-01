import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserLoginErrorComponent } from './user-login-error.component';

describe('UserLoginErrorComponent', () => {
  let component: UserLoginErrorComponent;
  let fixture: ComponentFixture<UserLoginErrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UserLoginErrorComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UserLoginErrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
