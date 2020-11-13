import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FizzBuzzComponent } from './fizz-buzz/fizz-buzz.component';

const routes: Routes = [  
        { path: '', component: HomeComponent, pathMatch: 'full' },
        //{ path: 'counter', component: CounterComponent },
        { path: 'fizz-buzz', component: FizzBuzzComponent },
        { path: 'fetch-data', component: FetchDataComponent },
]

@NgModule({
    imports:[
        CommonModule,
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})
export class AppRoutingModule{}