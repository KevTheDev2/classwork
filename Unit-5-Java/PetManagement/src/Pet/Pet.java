package Pet;

// Every class in Java is part of a package
// First thing you do to create a new class is create a new package
//      then create the class inside the package


import java.util.Objects;

/**********************************************************************************************
 *  This class will represent Pet information for a pet
 *
 *  Data: Name of the pet
 *        Type of Pet (Dog, Cat, Gerbil, Lizard, Bird, ect)
 *        Gender
 *        Weight (lbs)
 *        Is it spayed or neutered?
 *
 *  Behavior (methods):
 *
 *  1. You should always have at least one constructor
 *      You have a default constructor (in case Java needs it; Java uses the default constructor
 *                                                              behind the scenes if needed)
 *      At least one constructor that takes arguments used to initialize the object
 *
 *  2. Getters and setter to allow controlled access to private data members (encapsulation)
 *
 *  3. Object method overrides to get the behavior you want from the methods
 *
 *      toString() - represent the class data as a string rather than show the location@package.Class
 *      equals() - to determine if two objects of the class are equal based on the content
 *                              rather than based on their location in memory
 *      hashCode() - To generate a hash code based on the content of the object
 *                                  not it's location
 *                   The same data members used in equals should be used hashCode() so
 *                   objects that are equal have equal hash codes
 *
 *  4. Additional methods to support the helper methods
 *
 *  A class that has data and methods in items 1 thru 3 is known as a POJO
 *  (Plain Old Java Object)
 ***********************************************************************************************/


class Pet {
/********************************************************************
* Member data - should be private to support Encapsulation
 ********************************************************************/

private String      petName;
private String      petType;
private char        petGender;
private int         petWeight;
private boolean     isSpayed;

/****************************************************************
* Constructors - initialize objects instantiated for a class
 ***************************************************************/

// Default constructor - define an empty object (we don't know the default pet info)
    public Pet(){} // Constructor that takes no arguments and doesn't do anything

    // Constructor initializes using arguments passed to the constructor
    // Why is this. used in these statements?
    // It's needed because the parameter names are the same as the data member names (common)
    //      this. is used to reference the data member and NOT the parameter

    public Pet(String petName, String petType, char petGender, int petWeight, boolean isSpayed) {
        this.petName    = petName;      // copy petName parameter to the petName data member
        this.petType    = petType;      // copy petType parameter to the petType data member
        this.petGender  = petGender;    // copy petGender parameter to the petGender data member
        this.petWeight  = petWeight;    // copy petWeight parameter to the petWeight data member
        this.isSpayed   = isSpayed;     // copy isSpayed parameter to the isSpayed data member
    }

    /************************************************************************************
     * Standard getters and setters to allow controlled access to private data members
     *
     * Standard names: getters -getVariableName         setters: setVariableName
     *                          boolean: variableName
     ************************************************************************************/

    public String getPetName() {
        return petName;
    }
    public void setPetName(String petName) {
        this.petName = petName;
    }
    public String getPetType() {
        return petType;
    }
    public void setPetType(String petType) {
        this.petType = petType;
    }
    public char getPetGender() {
        return petGender;
    }
    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }
    public int getPetWeight() {
        return petWeight;
    }
    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }
    public boolean isSpayed() {
        return isSpayed;
    }
    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }



    /************************************************************************************
           Object method override

            toString() - represent the class data as a string rather than show the location@package.Class
     *      equals() - to determine if two objects of the class are equal based on the content
     *                              rather than based on their location in memory
     *      hashCode() - To generate a hash code based on the content of the object
     *                                  not it's location
     *                   The same data members used in equals should be used hashCode() so
     *                   objects that are equal have equal hash codes
     ************************************************************************************/

    @Override // Optional - Asks the complier to check to be sure this is a valid override
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", petGender=" + petGender +
                ", petWeight=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    @Override
    // equals receives a generic object - NOT an object of the class
    // We have to check or cast to the generic object of the class
    // Usage: aPet.equals(anotherPet) - in the method aPet is assumed and o represents the other pet
    public boolean equals(Object o) {
        // an object called pet is instantiated as part of if
        // (o instance of Pet pet) - the pet Pet instantiates a Pet object called pet
        if (!(o instanceof Pet pet)) return false;
        return     getPetGender() == pet.getPetGender() // compare the object to the left of .equals to object inside the ()
                && getPetWeight() == pet.getPetWeight()
                && isSpayed() == pet.isSpayed()
                && Objects.equals(getPetName(), pet.getPetName())
                && Objects.equals(getPetType(), pet.getPetType());
    }

    @Override
    public int hashCode() {
        return Objects.hash(petName, petType, petGender, petWeight, isSpayed);
    }
} // End Pet Class
