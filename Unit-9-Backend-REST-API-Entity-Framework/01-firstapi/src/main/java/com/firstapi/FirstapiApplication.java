package com.firstapi;
// this is generated for you when you create Spring Boot application.
//			DO NOT CHANGE ANYTHING IN HERE!!!!

// Spring Boot
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

// This is the main class for the Spring Boot application
// It contains the main method which is the entry point of the application
// The @SpringBootApplication annotation indicates that is a Spring Boot application
// This is what starts when you run the application

@SpringBootApplication
public class FirstapiApplication {
// The main method is the entry point of the application
	public static void main(String[] args) {
		SpringApplication.run(FirstapiApplication.class, args);
	}
// SpringApplication.run() method is used to launch the application
	// It takes the application class and command line arguments as parameters
}
