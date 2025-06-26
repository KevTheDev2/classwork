import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // data to be shared with the Angular when processing the web page
  buttonClicked = false
  firstName= "" // hold the data from the first name field on the form
  lastName= "" // hold the data from the first last field on the form
  birthday= "" // hold the data from the birthday field on the form
  foodPreference= "" // hold the data from the food preference field on the form
  emailAddress= "" // hold the data from the email address field on the form
  sendEmail= "" // hold the data from the send name field on the form
  sports= "" // hold the data from the sports field on the form
  // Methods to handle the interactions with html/web page
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the First Name field` )
    console.log(`You entered ${this.lastName} in the Last Name field` )
    console.log(`You entered ${this.foodPreference} in the food preference field` )
    console.log(`You entered ${this.emailAddress} in the email field` )
    console.log(`You entered ${this.sendEmail} in the send field` )
  }
}