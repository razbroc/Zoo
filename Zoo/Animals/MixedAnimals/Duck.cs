using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.MixedAnimals
{
    public class Duck : MixedAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name}: Quak!");
        }
    }
}
