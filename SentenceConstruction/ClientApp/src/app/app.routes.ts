import { Routes } from "@angular/router";
import { CounterComponent } from "./components/counter/counter.component";
import { HomeComponent } from "./components/home/home.component";
import {SentenceComponent} from "./components/sentence/sentence.component";

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    pathMatch: 'full'
  },
  {
    path: 'counter',
    component: CounterComponent
  },
  {
    path: 'sentence',
    component: SentenceComponent
  },
];
