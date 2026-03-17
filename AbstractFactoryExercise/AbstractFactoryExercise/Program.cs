using AbstractFactoryExercise.Abstractions;
using AbstractFactoryExercise.Client;
using AbstractFactoryExercise.ConcreteFactories;
using AbstractFactoryExercise.Constants;


Console.WriteLine("Welcome to the game!");

int? input = null;
GameEngine gameEngine;

Console.WriteLine();

while(input != 0)
{
    LevelFactory? factory = null;
    Console.WriteLine("Select Environment: [0] QUIT, [1] Dungeon, [2] Swamp");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine(GlobalConstants.INVALID_CHOICE);
            continue;
        }
    input = choice;
    Console.WriteLine();
    switch(input)
    {
        case 1:
            factory = new DungeonFactory();
            gameEngine = new GameEngine(factory);
            gameEngine.Run();
            Console.WriteLine();
            break;
        case 2:
            factory = new SwampFactory();
                    gameEngine = new GameEngine(factory);
        gameEngine.Run();
        Console.WriteLine();
            break;
        case 0:
            Console.WriteLine("You've quit the game!");
            break;
            default:
            Console.WriteLine(GlobalConstants.INVALID_CHOICE);
            break;
    }
}