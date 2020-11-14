import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import {FizzBuzzInput} from '../_models/fizzBuzzInput';
import {FizzBuzzResponse} from '../_models/fizzBuzzResponse';
import {FizzBuzzService} from '../_services/fizz-buzz.service';

@Component({
  selector: 'app-fizz-buzz',
  templateUrl: './fizz-buzz.component.html',
  styleUrls: ['./fizz-buzz.component.css']
})
export class FizzBuzzComponent implements OnInit {
  //inputs: FizzBuzzInput[] = [];
  responses: FizzBuzzResponse[] = [];
  fizzBuzzForm = new FormGroup({
    fizzBuzzInput: new FormControl('')
  });
  constructor(private fizzBuzzService:FizzBuzzService) { }

  ngOnInit() {
  }

  onSubmit() {
    console.log("FizzBuz Form value: " + this.fizzBuzzForm.value.fizzBuzzInput);
    
    this.fizzBuzzService.getFizzBuzz(this.fizzBuzzForm.value.fizzBuzzInput).subscribe(
      responses => {
        this.responses.concat(responses);
      }); 

    console.log("FizzBuzz Response Count:  " + this.responses.length);
  }
}
