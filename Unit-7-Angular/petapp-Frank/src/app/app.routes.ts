import { Routes } from '@angular/router';
import { Homepage } from './components/homepage/homepage';
// Routes object is an array of paths associated with components
// If you don't change the array name from 'routes' to something else, youre done
//(just add the paths)

export const routes: Routes = [
    // Associate a path to a component - use name of import for the component
    {path: 'home', component: Homepage},
];
