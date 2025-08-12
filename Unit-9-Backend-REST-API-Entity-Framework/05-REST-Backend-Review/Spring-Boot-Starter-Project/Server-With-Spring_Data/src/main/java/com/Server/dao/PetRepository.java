package com.Server.dao;
import com.Server.model.Pet;
import org.springframework.data.jpa.repository.JpaRepository;

//data type passed to JpaRepository cannot be a primitive type:
// Use Wrapper classes: Integer, Float, Double, Boolean, String
//                                                    class  p key
//                                                    class, type
public interface PetRepository extends JpaRepository<Pet, Integer> {


}
