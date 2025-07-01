import { Routes }        from '@angular/router'; // Give me access to Angular 
import { HomeComponent } from './components/home/home.component'; // Give me access to the home component
import { SampleFormComponent } from './components/sample-form/sample-form.component';
import { StateSealsComponent } from './components/state-seals/state-seals.component';
import { StudentListComponent} from './components/student-list/student-list.component'
// The Routed Object is an array of objects to associate a URL path to a component

// Each entry in the array contains the following attributes:

//      path - the URL path to e associated witha component
//      component - name of the import component associated with the path
//      redirect - optional attribute to redirect the path to a different page
//      pathMacth - indicates if a full match toa URL path is necesarry to use the entry

// we are defining an object called routes with a data type of Routes
// We tell the router the name of the array  in app.config.ts
export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' }, // empty path should redirect to /home page
    {path: 'home', component: HomeComponent},            // /home should display the HomeComponent
    {path: 'whatever', component:SampleFormComponent},    // /whatever should display the SampleFormComponent  
    {path: 'seals', component: StateSealsComponent},
    {path: 'student-list', component: StudentListComponent} 
];
