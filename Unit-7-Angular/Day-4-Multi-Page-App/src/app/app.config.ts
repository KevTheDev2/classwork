import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

// Tell the router where to find the array with the routes
//    that connects a URL to a component
// the import name must match the export name in app.rotes.ts 
import { routes } from './app.routes'; // connect app to app.routes.ts (.ts is assumed)

// appConfig object identifies things that you are using that are not part of 
//            base Angular processing
// (the router is not required for basic Angular processing)
// the providers attribute is a list of optional Angular processes you are using
// providerRouter indicates you want Angular to router support using the import
//    specified above

//
export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes)]
};