package com.Server.dao;
import com.Server.model.Pet;
import java.util.List;
import java.util.Optional;

public interface IPet {

    /* the interface provides method signatures for operations that can e performed on the data
    Should provide at least minimum CRUD support
    The actual code to perform the processing is in the implementation file */

    // 1. get all entries for data source       - return multiple objects - receive nothing
    public  List<Pet> getAllPets();

    // 2. get an entry by primary key           - return one object - receive a primary key value
    public Optional<Pet> returnPet(int pKey);

    // 3. Add an Entry to the data source       - return the entry added (REST Protocol) - receive an object
    public Pet addPet( Pet aPet);

    // 4. Update an entry in the data source    - return the entry updated (REST Protocol) - receive an object
    public Pet updatePet(Pet aPet);

    // 5. Delete an entry by primary key        - return nothing (REST protocol) - receive a primary key
    public void deletePet(int priKey);

} // End of iPet interface
