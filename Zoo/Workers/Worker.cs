using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.Workers
{
    public abstract class Worker
    {
        public Area WorkArea;
        public int WorkTime; //seconds
    }
}
