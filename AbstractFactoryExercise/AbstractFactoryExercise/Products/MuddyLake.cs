using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExercise.Products
{
    public class MuddyLake : Abstractions.Environment
    {
        public override void Describe()
        {
            Console.WriteLine("You see a muddy lake, its murky waters hiding what lies beneath." +
                "\nThe air is thick with the scent of damp earth and decaying vegetation.");
        }
    }
}
