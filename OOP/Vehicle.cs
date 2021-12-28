using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Vehicle
    {
        protected int _maxSpeed;

        public Vehicle()
        {
            _maxSpeed = 0;
        }

        public Vehicle(int speed)
        {
            _maxSpeed = speed;
        }

        public abstract void SetMaxSpeed(int speed);

        virtual public int GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public abstract OperatingEnvironment[] GetEnvironment();

        // this can be done with reflections, but this is not part of th task
        virtual public string GetClassName()
        {
            return "Vehicle";
        }

        public static bool CheckLimits(int val, int low, int high)
        {
            return (low <= val && val <= high);
        }
    }
}
