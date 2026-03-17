using System;
using AbstractFactoryExercise.Abstractions;
using AbstractFactoryExercise.Constants;

namespace AbstractFactoryExercise.Client
{
    public class GameEngine
    {
        private LevelFactory _levelFactory;
        private Enemy _currentEnemy;
        private Abstractions.Environment _currentEnvironment;

        public GameEngine(LevelFactory levelFactory)
        {
            _levelFactory = levelFactory;
        }
        public void LoadEnvironvment()
        {
            _currentEnvironment = _levelFactory.CreateEnvironment();
            _currentEnvironment.Describe();
            Console.WriteLine();
        }
        public void ListEnvironmentEnemies()
        {
            string[] availableEnemies = _levelFactory.GetAvailableEnemyNames();
            Console.WriteLine("Select a monster to fight:");
            for (int i = 0; i < availableEnemies.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {availableEnemies[i]}");
            }
        }

        public void Run()
        {
            LoadEnvironvment();

            string[] availableEnemies = _levelFactory.GetAvailableEnemyNames();
            Console.WriteLine("Select a monster to fight:");
            for (int i = 0; i < availableEnemies.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {availableEnemies[i]}");
            }

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine(GlobalConstants.INVALID_CHOICE);
                return;
            }

            if (choice < 1 || choice > availableEnemies.Length)
            {
                Console.WriteLine(GlobalConstants.INVALID_CHOICE);
                return;
            }
            else
                {
                string selectedEnemyName = availableEnemies[choice - 1];

            _currentEnemy = _levelFactory.CreateEnemy(selectedEnemyName);
            
            Console.WriteLine($"\nYou engage the {selectedEnemyName}!");
            _currentEnemy.Attack();
                }
        }
    }
}