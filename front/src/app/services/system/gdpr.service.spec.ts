import { TestBed } from '@angular/core/testing';

import { GdprService } from './gdpr.service';

describe('GdprService', () => {
  let service: GdprService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GdprService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
