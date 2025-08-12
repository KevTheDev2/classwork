package com.Server.dao;
import com.Server.model.Pet;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class PetServiceImpl implements IPet {

    // data member
    PetRepository thePetRepository; // reference to repository

    // Constructors - created by the IDE - Note it automatically includes the reference to the repository
    //                                     a repository object will be instantiated and passed to the ctor
    //                                     automatically (Dependency injection)

    @Autowired // Tells the dtat framework to dependency injection where needed
    public PetServiceImpl(PetRepository thePetRepository) {
        this.thePetRepository = thePetRepository;
    }

    @Override
    public List<Pet> getAllPets() {

        return thePetRepository.findAll(); // call data framework method to retrieve all objects
    }

    @Override
    public Optional<Pet> returnPet(int pKey) { //

        return thePetRepository.findById(pKey); // call data framework method to retrieve by id
    }

    @Override
    @Transactional
    public Pet addPet(Pet aPet) {
        // Be sure the object primary key is null
        // if primary key is null - save adds the object to the resource
        return thePetRepository.save(aPet);
    }

    @Override
    @Transactional
    public Pet updatePet(Pet aPet) {
        // Be sure the object primary key has a value that already exists
        // if primary key is not null - save and update the object in the resource
        return thePetRepository.save(aPet);
    }

    @Override
    @Transactional
    public void deletePet(int priKey) {
        thePetRepository.deleteById(priKey);
    }
}
