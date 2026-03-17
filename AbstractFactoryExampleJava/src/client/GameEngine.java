package client;

import java.util.Scanner;
import abstractions.Enemy;
import abstractions.Environment;
import abstractions.LevelFactory;
import constants.GlobalConstants;

public class GameEngine {
    private LevelFactory levelFactory;
    private Enemy currentEnemy;
    private Environment currentEnvironment;
    private Scanner scanner;

    public GameEngine(LevelFactory levelFactory, Scanner scanner) {
        this.levelFactory = levelFactory;
        this.scanner = scanner;
    }

    public void run() {
        currentEnvironment = levelFactory.createEnvironment();
        currentEnvironment.describe();
        System.out.println();

        String[] availableEnemies = levelFactory.getAvailableEnemyNames();
        System.out.println("Select a monster to fight:");
        for (int i = 0; i < availableEnemies.length; i++) {
            System.out.println("[" + (i + 1) + "] " + availableEnemies[i]);
        }

        String inputStr = scanner.nextLine();
        int choice;
        try {
            choice = Integer.parseInt(inputStr);
        } catch (NumberFormatException e) {
            System.out.println(GlobalConstants.INVALID_CHOICE);
            return;
        }

        if (choice < 1 || choice > availableEnemies.length) {
            System.out.println(GlobalConstants.INVALID_CHOICE);
            return;
        }

        String selectedEnemyName = availableEnemies[choice - 1];
        currentEnemy = levelFactory.createEnemy(selectedEnemyName);

        System.out.println("\nYou engage the " + selectedEnemyName + "!");
        currentEnemy.attack();
    }
}