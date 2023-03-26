using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.AirAnimals
{
    public class Owl : AirAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name}: Hooooo!");
        }
    }
}
