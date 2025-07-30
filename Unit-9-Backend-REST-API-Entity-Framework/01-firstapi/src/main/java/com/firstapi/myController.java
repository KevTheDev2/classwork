package com.firstapi;

// this file contains controllers to handle HTTP requests sent to this server.

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

// The @RestController annotation indicates that this class has REST controllers to it
// REST stands for Representational STate Transfer,
//      WHich is an archatechtural style for designing networked applications.
// REST is a type of API - Most p
@RestController
public class myController {

    @GetMapping
    public String anyName() {
        return "Hi There";
    }
}
