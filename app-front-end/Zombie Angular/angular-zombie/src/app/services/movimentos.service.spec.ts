import { TestBed, inject } from '@angular/core/testing';

import { MovimentosService } from './movimentos.service';

describe('MovimentosService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MovimentosService]
    });
  });

  it('should ...', inject([MovimentosService], (service: MovimentosService) => {
    expect(service).toBeTruthy();
  }));
});
