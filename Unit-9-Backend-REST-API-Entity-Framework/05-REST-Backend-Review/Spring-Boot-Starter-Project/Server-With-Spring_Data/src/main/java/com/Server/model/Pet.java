package com.Server.model;

import jakarta.persistence.*;

import java.util.Objects;

@Entity
@Table(name = "pet")
public class Pet {

    // Data members - one for each column in the table
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name ="pet_id")
    private int petId; // since this is defined as serial in the database, we need the @ generated

    @Column (name="name")
    private String petName;

    @Column (name="pet_type_id")
    private int petTypeID;

    @Column (name="owner_id")
    private int ownerId;

    // Constructors

    // Program defined default constructor - in case Java/Framework needs it

    public  Pet(){}

    public Pet(int petId, String petName, int petTypeID, int ownerId) {
        this.petId = petId;
        this.petName = petName;
        this.petTypeID = petTypeID;
        this.ownerId = ownerId;
    }


    // Standard names Getters and Setters

    public int getPetId() {
        return petId;
    }
    public void setPetId(int petId) {
        this.petId = petId;
    }
    public String getPetName() {
        return petName;
    }
    public void setPetName(String petName) {
        this.petName = petName;
    }
    public int getPetTypeID() {
        return petTypeID;
    }
    public void setPetTypeID(int petTypeID) {
        this.petTypeID = petTypeID;
    }
    public int getOwnerId() {
        return ownerId;
    }
    public void setOwnerId(int ownerId) {
        this.ownerId = ownerId;
    }

    // *Programmer may add custom getters and setters if they're needed*


    // toString, equals and hashCode overrides

    @Override
    public String toString() {
        return "Pet{" +
                "petId=" + petId +
                ", petName='" + petName + '\'' +
                ", petTypeID=" + petTypeID +
                ", ownerId=" + ownerId +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return petId == pet.petId && petTypeID == pet.petTypeID && ownerId == pet.ownerId && Objects.equals(petName, pet.petName);
    }

    @Override
    public int hashCode() {
        return Objects.hash(petId, petName, petTypeID, ownerId);
    }

    // Additional methods to support the class


} // end of put POJO
