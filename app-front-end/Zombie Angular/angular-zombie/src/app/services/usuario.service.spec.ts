import { TestBed, inject } from '@angular/core/testing';

import { UsuarioService } from './usuario.service';

describe('UsuarioService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [UsuarioService]
    });
  });

  it('should ...', inject([UsuarioService], (service: UsuarioService) => {
    expect(service).toBeTruthy();
  }));
});
