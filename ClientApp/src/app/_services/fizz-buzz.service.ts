import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FizzBuzzResponse } from '../_models/fizzBuzzResponse';
import { FizzBuzzInput } from '../_models/fizzBuzzInput';

@Injectable({
  providedIn: 'root'
})
export class FizzBuzzService {
  data = [];
  private baseUrl;
  constructor( private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.baseUrl = baseUrl;
  }

  getFizzBuzz(): Observable <FizzBuzzResponse>{
    console.log(this.baseUrl +'fizzbuzz');
    
    return this.http.post<FizzBuzzResponse>(this.baseUrl +'fizzbuzz', FizzBuzzInput);
  }
}
