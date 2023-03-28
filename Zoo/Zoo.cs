using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
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
        public static object LandTour;
        public static object AirTour;
        public static object SeaTour;
        public static object MixTour;
        public List<Animal> Animals;
        public List<Worker> Workers;
        public int CurrentTime = 0; //seconds
        public const int SECONDS_IN_DAY = 120;

        public void ZooInit() {
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

            this.Animals = new List<Animal> { animalAir1, animalAir2, animalAir3,
                animalLand1, animalLand2, animalLand3, 
                animalMix1, animalMix2, animalMix3, 
                animalSea1, animalSea2, animalSea3};
            
            Worker worker1 = new Cleaner("Eyal", Area.Land);
            Worker worker2 = new Doctor("Avram", animalMix3);
            Worker worker3 = new Feeder("Shay", animalLand1);
            this.Workers = new List<Worker>{worker1, worker2, worker3 };
        }


        public void StartTour(string location, object objToLock, List<Person> visitors)
        {
            lock (objToLock)
            {
                Console.WriteLine($"Touring in the {location}!...");
                Thread.Sleep(10000);
                Console.WriteLine($"{location} tour is finished...");
            }
        }

        public void InitAllWorkers()
        {
            foreach (Worker worker in this.Workers)
            {
                worker.InitWorkingTimes();
            }
        }

        public void RunDayInZoo()
        {
            InitAllWorkers();
        }

        public void WorkTime()
        {
            Random rnd = new Random();
            int workerIndex = rnd.Next(this.Workers.Count() - 1);
            Worker worker = this.Workers[workerIndex];
            int maxWorkHour = SECONDS_IN_DAY - worker.WorkTime - this.CurrentTime;
            int timeToWork = rnd.Next(this.CurrentTime, maxWorkHour);

        }
    }
}
