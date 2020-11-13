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
  inputs: FizzBuzzInput[] = [];
  responses: FizzBuzzResponse[] = [];
  fizzBuzzForm = new FormGroup({
    fizzBuzzInput: new FormControl('')
  });
  constructor(private fizzBuzzService:FizzBuzzService) { }

  ngOnInit() {
  }

  checkForFizzBuzz(){

  }

  onSubmit() {
    //var searchName = this.fizzbuzzForm.value.fizzBuzInput;
    
    //if (searchName.length > 0) {
      this.fizzBuzzService.getFizzBuzz().subscribe(
        responses => {
          this.responses.concat(responses);
        });
    //}
    //console.log("FizzBuz Form value: " + this.fizzbuzzForm.value.fizzBuzInput);
  }
}
