package com.Server.dao;
import com.Server.model.Pet;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class PetServiceImpl implements IPet {

    PetRepository thePetRepository;

    // Constructors - created by the IDE

    @Autowired
    public PetServiceImpl(PetRepository thePetRepository) {
        this.thePetRepository = thePetRepository;
    }

    @Override
    public List<Pet> getAllPets() {
        return thePetRepository.findAll();
    }

    @Override
    public Optional<Pet> returnPet(int pKey) {
        return thePetRepository.findById(pKey);
    }

    @Override
    @Transactional
    public Pet addPet(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    @Transactional
    public Pet updatePet(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    @Transactional
    public void deletePet(int priKey) {
        thePetRepository.deleteById(priKey);
    }
}
