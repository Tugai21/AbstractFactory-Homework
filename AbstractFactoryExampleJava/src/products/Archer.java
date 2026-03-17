package products;
import abstractions.Enemy;

public class Archer extends Enemy {
    @Override
    public void attack() {
        System.out.println("The Archer fires a volley of arrows!");
    }
}