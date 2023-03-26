﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.SeaAnimals
{
    public class Dolphin : SeaAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{this.Name}: Heeheee!");
        }
    }
}
