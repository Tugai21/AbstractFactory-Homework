using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExercise.Abstractions;
using AbstractFactoryExercise.Constants;
using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise.ConcreteFactories
{
    public class SwampFactory : LevelFactory
    {
        public override string[] GetAvailableEnemyNames()
        {
            return new string[]
                {
                "Mud Monster",
                "Hydra",
                };
        }
        public override Abstractions.Enemy CreateEnemy(string enemyName)
        {
            return enemyName switch
            {
                "Mud Monster" => new MudMonster(),
                "Hydra" => new Hydra(),
                _ => throw new ArgumentException(GlobalConstants.INVALID_CHOICE)
            };
        }
        public override Abstractions.Environment CreateEnvironment()
        {
            return new Products.MuddyLake();
        }
    }
}
