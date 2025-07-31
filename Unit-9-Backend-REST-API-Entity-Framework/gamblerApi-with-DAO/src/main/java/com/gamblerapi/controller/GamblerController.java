package com.gamblerapi.controller;
// Anything associated with the server must be in the same package as the server
//          so the server can find it.
// Server, Controller, DAO Service, POJO Model for data, Repository, ect
//          are all in the same package as the server

// Controllers contains methods that handle HTTP Requests
// When the server receives a request,
//              it will route it to the appropriate controller
//

import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

// When the server is looking for controller methods, it searches for classes
//       that are annotated with @RESTController
//
// If you forget to add the @RestController annotation,
//      the server will not be able to find the

@RestController // This annotation indicates that this class
                //      contains A REST controller method
                // REST stands for Representation State Transfer
                //          REST is an architectural style for designing
                //                  networked applications
                //          REST is protocol for communication between client and server
                //                  All requests follow a certain protocol
public class GamblerController {

    // This is where you will define your controller methods
    // Controller methods are the methods that handle HTTP requests
    // They are annotated tih @GetMapping, @PostMapping, @PutMapping, @DeleteMapping, ect.

    // Define a reference to the GamblerDAO
    private GamblerMemoryDao gamblerDAO;

    // define a reference to GamblerDAO
    public GamblerController() {
        this.gamblerDAO = new GamblerMemoryDao();
    }

    // constructor - initializes te data source

    // Define a controller to handle a GET request to that root URL ("\" or nothing)
    // This method will return a simple greeting message

    @GetMapping("/")
    public String unique1() {
        return "Finally, welcome to the gambler API!";

    }

    // define a controller to handle a GET request to return all the gamblers
    //
    // We need:
    //      1. return a LIst of all gamblers: __List<Gambler>
    //      2. DAO method we call will return list of getGamblers()
    //      3. URL path: "/gamblers"
    //      4. HTTP method: GET

    // Tell the server that this method will handle GET requests
    //          for the URL path "/gamblers"
    @GetMapping("/gamblers")
    public List<Gambler> getAllGamblers() {
        // call the DAO method to get all the gamblers
        //      and return the list of gamblers it gives us
            return gamblerDAO.getGamblers();
    }   // End getAllGamblers method

     @GetMapping("/gamblers/{id}")
    public Gambler getGamblerById (@PathVariable int id)
     {
         return gamblerDAO.getGamblerByID(id);
     }


           @GetMapping("/gamblers/search")
    public Gambler getGamblerByName(@RequestParam String name)
           {
               return gamblerDAO.getGamblerByName(name);
           }

}
