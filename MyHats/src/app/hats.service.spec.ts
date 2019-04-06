import { TestBed } from '@angular/core/testing';

import { HatsService } from './hats.service';

describe('HatsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: HatsService = TestBed.get(HatsService);
    expect(service).toBeTruthy();
  });
});
