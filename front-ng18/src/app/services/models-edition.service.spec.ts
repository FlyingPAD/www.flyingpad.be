import { TestBed } from '@angular/core/testing';

import { ModelsEditionService } from './models-edition.service';

describe('ModelsEditionService', () => {
  let service: ModelsEditionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ModelsEditionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
