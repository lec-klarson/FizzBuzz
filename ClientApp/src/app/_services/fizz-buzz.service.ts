import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FizzBuzzResponse } from '../_models/fizzBuzzResponse';

@Injectable({
  providedIn: 'root'
})
export class FizzBuzzService {
  private baseUrl;
  constructor( private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.baseUrl = baseUrl;
  }

  getFizzBuzz(fizzBuzzInputStr): Observable<FizzBuzzResponse[]>{
    return this.http.get<FizzBuzzResponse[]>(this.baseUrl +'api/FB/get?inputStr=' + fizzBuzzInputStr);
  }
}
