import { TestBed } from '@angular/core/testing';

import { AudioOldService } from './audio-old.service';

describe('AudioOldService', () => {
  let service: AudioOldService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AudioOldService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
