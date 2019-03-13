﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car : IAccelerate
    {

        private int speed;
        private string name;

        public Car(string _name)
        {
            name = _name;
        }
        public Boolean accelerate(int _speed)
        {
            if (_speed > 0)
            {
                speed += speed;
                return true;
            }
            else
            {
                return false;
            }
        }



        public override string ToString()
        {
            return name;
        }
    }



}
