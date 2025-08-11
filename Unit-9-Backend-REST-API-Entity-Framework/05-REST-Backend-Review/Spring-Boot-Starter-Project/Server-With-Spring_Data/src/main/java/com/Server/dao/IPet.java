package com.Server.dao;
import com.Server.model.Pet;
import java.util.List;
import java.util.Optional;

public interface IPet {

    public  List<Pet> getAllPets();


    public Optional<Pet> returnPet(int pKey);


    public Pet addPet( Pet aPet);


    public Pet updatePet(Pet aPet);


    public void deletePet(int priKey);

} // End of iPet interface
