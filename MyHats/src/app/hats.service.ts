import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Hat } from './hat';

@Injectable({
  providedIn: 'root'
})
export class HatsService {

  constructor(private httpClient: HttpClient) { }

  getHats(): Observable<Hat[]> {
    return this.httpClient.get<Hat[]>('/api/hats');
  }

}
