import { TestBed } from '@angular/core/testing';

import { RightColumnService } from './right-column.service';

describe('RightColumnService', () => {
  let service: RightColumnService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RightColumnService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
