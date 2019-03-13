using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car : IAccelerate
    {

        private int speed;

        public void accelerate(int _speed)
        {
            speed += speed;
        }
    }
}
