using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExercise.Products
{
    public class CastleWall : Abstractions.Environment
    {
        public override void Describe()
        {
            Console.WriteLine("You see a sturdy castle wall, built to withstand sieges and " +
                "\nprotect the inhabitants within.");
        }
    }
}
