package products;
import abstractions.Environment;

public class CastleWall extends Environment {
    @Override
    public void describe() {
        System.out.println("You see a sturdy castle wall, built to withstand sieges" +
                " and protect the inhabitants within.");
    }
}