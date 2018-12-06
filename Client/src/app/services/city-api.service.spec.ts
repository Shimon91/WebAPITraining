import { TestBed } from '@angular/core/testing';

import { CityApiService } from './city-api.service';

describe('CityApiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CityApiService = TestBed.get(CityApiService);
    expect(service).toBeTruthy();
  });
});
