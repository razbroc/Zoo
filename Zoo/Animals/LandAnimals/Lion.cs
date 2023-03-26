﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.LandAnimals
{
    public class Lion : LandAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Raaarrrrr!");
        }
    }
}
