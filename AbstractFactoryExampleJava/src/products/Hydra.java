package products;
import abstractions.Enemy;

public class Hydra extends Enemy {
    @Override
    public void attack() {
        System.out.println("The Hydra snaps at you!");
    }
}