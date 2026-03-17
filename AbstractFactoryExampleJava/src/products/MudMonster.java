package products;
import abstractions.Enemy;

public class MudMonster extends Enemy {
    @Override
    public void attack() {
        System.out.println("The Mud Monster flings toxic sludge at you!");
    }
}