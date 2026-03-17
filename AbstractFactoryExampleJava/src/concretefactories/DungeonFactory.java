package concretefactories;

import abstractions.Enemy;
import abstractions.Environment;
import abstractions.LevelFactory;
import constants.GlobalConstants;
import products.Archer;
import products.CastleWall;
import products.Knight;

public class DungeonFactory extends LevelFactory {
    @Override
    public String[] getAvailableEnemyNames() {
        return new String[] { "Knight", "Archer" };
    }

    @Override
    public Enemy createEnemy(String enemyName) {
        return switch (enemyName) {
            case "Knight" -> new Knight();
            case "Archer" -> new Archer();
            default -> throw new IllegalArgumentException(GlobalConstants.INVALID_CHOICE);
        };
    }

    @Override
    public Environment createEnvironment() {
        return new CastleWall();
    }
}