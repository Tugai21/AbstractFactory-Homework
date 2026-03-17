package products;
import abstractions.Enemy;

public class Knight extends Enemy {
    @Override
    public void attack() {
        System.out.println("The Knight charges at you!");
    }
}