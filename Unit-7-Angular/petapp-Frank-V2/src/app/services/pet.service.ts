// Services manage data for the app and access to the data

// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';
import { PetInfo } from '../interfaces/pet-info'

@Injectable({
  providedIn: 'root'
})
// the class of the service (aka module) contains data and functions to manage the data
export class PetService {

   // typically data is kept in an array inside the service
   // and is described by an interface
   petData : PetInfo[] = [] // hold data for the service - initially empty
  constructor() 
  {
    this.petData.push({name: 'Pina', type: 'Dog', gender: 'Female'})
    this.petData.push({name: 'Bella', type: 'Cat', gender: 'Female'})
    this.petData.push({name: 'Beans', type: 'Dog', gender: 'Male'})
    this.petData.push({name: 'Zoey', type: 'Cat', gender: 'Female'})

    
   }

   // provide a function to return the array of data
   getPetData() : PetInfo[] {
return this.petData;

   }
}
