import { TestBed } from '@angular/core/testing';

import { MoodsService } from './moods.service';

describe('MoodsService', () => {
  let service: MoodsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MoodsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
