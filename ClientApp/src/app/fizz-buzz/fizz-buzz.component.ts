import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { MatTable, MatTableDataSource } from '@angular/material';
import { FizzBuzzResponse } from '../_models/fizzBuzzResponse';
import { FizzBuzzService } from '../_services/fizz-buzz.service';

@Component({
  selector: 'app-fizz-buzz',
  templateUrl: './fizz-buzz.component.html',
  styleUrls: ['./fizz-buzz.component.css']
})
export class FizzBuzzComponent implements OnInit {
  displayedColumns: string[] = ['input', 'response'];
  responses: FizzBuzzResponse[];
  fizzBuzzForm = new FormGroup({
    fizzBuzzInput: new FormControl('')
  });
  constructor(private fizzBuzzService:FizzBuzzService) { }

  ngOnInit() {
  }

  onSubmit() {
   this.responses = [];
   this.fizzBuzzService.getFizzBuzz(this.fizzBuzzForm.value.fizzBuzzInput).subscribe(
    responses => {
      this.responses=responses;
   }); 
  }
}
