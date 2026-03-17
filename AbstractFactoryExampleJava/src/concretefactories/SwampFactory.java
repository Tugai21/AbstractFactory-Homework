package concretefactories;

import abstractions.Enemy;
import abstractions.Environment;
import abstractions.LevelFactory;
import constants.GlobalConstants;
import products.Hydra;
import products.MudMonster;
import products.MuddyLake;

public class SwampFactory extends LevelFactory {
    @Override
    public String[] getAvailableEnemyNames() {
        return new String[] { "Mud Monster", "Hydra" };
    }

    @Override
    public Enemy createEnemy(String enemyName) {
        return switch (enemyName) {
            case "Mud Monster" -> new MudMonster();
            case "Hydra" -> new Hydra();
            default -> throw new IllegalArgumentException(GlobalConstants.INVALID_CHOICE);
        };
    }

    @Override
    public Environment createEnvironment() {
        return new MuddyLake();
    }
}