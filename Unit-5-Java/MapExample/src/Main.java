import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.TreeMap;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
        // to see how IntelliJ IDEA suggests fixing it.
        System.out.printf("Hello and welcome!");
// Create a Map to hold  a person's name and their favorite number
//      Map<key-type, value type. name      = new typeOfMap;
        // Map<String, Integer> peoplesNumbers = new HashMap<>(); // HashMap stores in an unknown sequence
        // Map<String, Integer> peoplesNumbers = new TreeMap<>(); // TreeMapMap stores in sequence based on type
        Map<String, Integer> peoplesNumbers = new LinkedHashMap<>(); // TreeMapMap stores in entry sequence



        // Add some entries to the Map
        //  .put(key, value) - Add an entry to the Map
        peoplesNumbers.put("Ravyn", 5);
        peoplesNumbers.put("Frank", 42);
        peoplesNumbers.put("Missy", 13);
        peoplesNumbers.put("Zach", 51);
        peoplesNumbers.put("Youssef", 7);


        // Find an entry in the Map
        // .get(key-value) - retreive the value associated with the key - null if the key is not in the Map
        System.out.println("Ravyn's favorite number is " + peoplesNumbers.get("Ravyn"));
        System.out.println("Missy's favorite number is " + peoplesNumbers.get("Missy"));
        System.out.println("Arnold's favorite number is " + peoplesNumbers.get("Arnold"));

        // display all entries in the map
        for (Map.Entry<String, Integer> anEntry: peoplesNumbers.entrySet()) {
        System.out.println("Name: " + anEntry.getKey() + " Favorite number: " + anEntry.getValue());
    }

        // remove an entry from the map
        peoplesNumbers.remove("Frank");

        System.out.println("Frank's favorite number is " + peoplesNumbers.get("Frank"));
} // End of Main
}