using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Models
{
    class Submarine : IAccelerate, IDive
    {
        public bool accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public bool dive(int change)
        {
            throw new NotImplementedException();
        }
    }
}
