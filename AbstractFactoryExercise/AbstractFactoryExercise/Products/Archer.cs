using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExercise.Abstractions;
using AbstractFactoryExercise.Constants;

namespace AbstractFactoryExercise.Products
{
    public class Archer : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine(GlobalConstants.ATTACK, "Archer");
        }
    }
}
