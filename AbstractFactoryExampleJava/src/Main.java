import java.util.Scanner;
import abstractions.LevelFactory;
import client.GameEngine;
import concretefactories.DungeonFactory;
import concretefactories.SwampFactory;
import constants.GlobalConstants;

public class Main {
    public static void main(String[] args) {
        System.out.println("Welcome to the game!\n");

        Scanner scanner = new Scanner(System.in);
        int input = -1;

        while (input != 0) {
            System.out.println("Select Environment: [0] QUIT, [1] Dungeon, [2] Swamp");
            String line = scanner.nextLine();

            try {
                input = Integer.parseInt(line);
            } catch (NumberFormatException e) {
                System.out.println(GlobalConstants.INVALID_CHOICE);
                continue;
            }

            System.out.println();
            LevelFactory factory;
            GameEngine gameEngine;

            switch (input) {
                case 1:
                    factory = new DungeonFactory();
                    gameEngine = new GameEngine(factory, scanner);
                    gameEngine.run();
                    System.out.println();
                    break;
                case 2:
                    factory = new SwampFactory();
                    gameEngine = new GameEngine(factory, scanner);
                    gameEngine.run();
                    System.out.println();
                    break;
                case 0:
                    System.out.println("You've quit the game!");
                    break;
                default:
                    System.out.println(GlobalConstants.INVALID_CHOICE);
                    break;
            }
        }

        scanner.close();
    }
}