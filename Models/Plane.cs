using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Models
{
    class Plane : IRise, IAccelerate
    {
        public bool accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public bool rise(int change)
        {
            throw new NotImplementedException();
        }
    }
}
