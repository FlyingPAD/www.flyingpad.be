import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { UserService } from './services/user.service';
import { CustomCookieService } from './services/system/cookie.service';
import { AuthenticationService } from './services/system/authentication.service';
import { MenuCustomService } from './services/display/menu-custom.service';

// Mock des services utilisés dans AppComponent
class MockUserService {
  setSpecificUser() {}
  setDefaultUser() {}
}

class MockCustomCookieService {
  retrieveToken() { return null; }
}

class MockAuthenticationService {
  acceptConnection() {}
}

class MockMenuCustomService {
  triggerMenuCustom() {}
}

describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        AppComponent
      ],
      providers: [
        { provide: UserService, useClass: MockUserService },
        { provide: CustomCookieService, useClass: MockCustomCookieService },
        { provide: AuthenticationService, useClass: MockAuthenticationService },
        { provide: MenuCustomService, useClass: MockMenuCustomService }
      ]
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });
});
