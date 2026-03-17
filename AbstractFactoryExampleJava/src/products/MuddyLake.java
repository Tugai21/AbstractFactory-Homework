package products;
import abstractions.Environment;

public class MuddyLake extends Environment {
    @Override
    public void describe() {
        System.out.println("You see a muddy lake, its murky waters hiding what lies beneath.");
    }
}