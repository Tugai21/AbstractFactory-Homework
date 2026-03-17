package abstractions;

public abstract class LevelFactory {
    public abstract String[] getAvailableEnemyNames();
    public abstract Enemy createEnemy(String enemyName);
    public abstract Environment createEnvironment();
}
