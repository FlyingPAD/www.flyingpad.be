import { TestBed } from '@angular/core/testing';

import { MenuMainService } from './menu-main.service';

describe('MenuMainService', () => {
  let service: MenuMainService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MenuMainService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
