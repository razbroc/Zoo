using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Animals;

namespace Zoo.Workers
{
    public class Cleaner : Worker
    {
        public Cleaner(Area WorkArea)
        {
            this.WorkArea = WorkArea;
            this.WorkTime = 2;
        }
    }
}
