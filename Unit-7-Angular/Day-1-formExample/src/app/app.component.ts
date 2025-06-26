import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
// import for external component - may be automatically added by IDE
import { FormExampleComponent } from './components/form-example/form-example.component';
// @Component identifies all the Angular stuff you are using
//            including new components
@Component({
  selector:      'app-root',                           // Is the name of the tag used in html to reference the component
  standalone: true,
  // imports identifies external resources, like components, used in the app
  imports: [RouterOutlet, FormExampleComponent],      // Note the name has Component
  templateUrl: './app.component.html',                // The File containing the html for the component
  styleUrl:    './app.component.css'                  // the file containing the css for the component
})
// Allows processes outside this component to access things defined in the component
// Any data or methods you want Angular to use must be exported from Typescript file for the component 
// To use One-Way Binding for data defined in this code in the HTML:  {{variable-name}}
export class AppComponent {
  pageHeading = 'Welcome to AHBC - C# - Contact Info Submission'
}
