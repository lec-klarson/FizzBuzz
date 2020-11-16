import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FizzBuzzComponent } from './fizz-buzz/fizz-buzz.component';

const routes: Routes = [  
        { path: '', component: FizzBuzzComponent, pathMatch: 'full' },
        { path: 'fizz-buzz', component: FizzBuzzComponent },
]

@NgModule({
    imports:[
        CommonModule,
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})
export class AppRoutingModule{}
