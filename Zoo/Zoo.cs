using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;
using Zoo.Animals.AirAnimals;
using Zoo.Animals.LandAnimals;
using Zoo.Animals.MixedAnimals;
using Zoo.Animals.SeaAnimals;
using Zoo.Workers;

namespace Zoo
{
    public class Zoo
    {
        public static void ZooInit() {
            Animal animalAir1 = new Eagle("Moshe");
            Animal animalAir2 = new Hawk("Yoram");
            Animal animalAir3 = new Owl("Yakov");
            Animal animalLand1 = new Elephant("Raanan");
            Animal animalLand2 = new Jiraff("Yoav");
            Animal animalLand3 = new Kangeroo("David");
            Animal animalMix1 = new Alligator("Brit");
            Animal animalMix2 = new Duck("Avraham");
            Animal animalMix3 = new Frog("Gaon");
            Animal animalSea1 = new Dolphin("Arik");
            Animal animalSea2 = new GoldFish("Kora");
            Animal animalSea3 = new Shark("Mike");

            List<Animal> animals = new List<Animal> { animalAir1, animalAir2, animalAir3,
                animalLand1, animalLand2, animalLand3, 
                animalMix1, animalMix2, animalMix3, 
                animalSea1, animalSea2, animalSea3};
            
            Worker worker1 = new Cleaner(Area.Land);
            Worker worker2 = new Doctor(animalMix3);
            Worker worker3 = new Feeder(animalLand1);
            List<Worker> workers = new List<Worker>{worker1, worker2, worker3 };
            }
    }
}
