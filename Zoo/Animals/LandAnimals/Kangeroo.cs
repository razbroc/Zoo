using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.LandAnimals
{
    public class Kangeroo : LandAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name}: Kangkangro!");
        }
    }
}
