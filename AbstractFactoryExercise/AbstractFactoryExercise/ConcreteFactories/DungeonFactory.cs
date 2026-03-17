using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExercise.Abstractions;
using AbstractFactoryExercise.Constants;
using AbstractFactoryExercise.Products;

namespace AbstractFactoryExercise.ConcreteFactories
{
    public class DungeonFactory : Abstractions.LevelFactory
    {
        public override string[] GetAvailableEnemyNames()
        {
            return new string[]
                {
                "Knight",
                "Archer",
                };
        }
        public override Abstractions.Enemy CreateEnemy(string enemyName)
        {
            return enemyName switch
            {
                "Knight" => new Knight(),
                "Archer" => new Archer(),
                _ => throw new ArgumentException(GlobalConstants.INVALID_CHOICE)
            };
        }
        public override Abstractions.Environment CreateEnvironment()
        {
            return new CastleWall();
        }
    }
}
