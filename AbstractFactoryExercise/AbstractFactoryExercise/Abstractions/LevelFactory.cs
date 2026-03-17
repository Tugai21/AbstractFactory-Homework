using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExercise.Abstractions
{
    public abstract class LevelFactory
    {
        public abstract string[] GetAvailableEnemyNames();
        public abstract Enemy CreateEnemy(string enemyName);
        public abstract Environment CreateEnvironment();
    }
}
