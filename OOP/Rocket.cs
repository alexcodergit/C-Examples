using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rocket : Airplane
    {
        private const int UpperSpeedLimit = 100000;
        private const int LowerSpeedLimit = 0;

        public Rocket() : base()
        { }
        public Rocket(int speed):base()
        {
            if (!CheckLimits(speed, LowerSpeedLimit, UpperSpeedLimit))
            {
                throw new ArgumentOutOfRangeException($"Speed has value {speed}, but must be between {LowerSpeedLimit} and {UpperSpeedLimit}");
            }
            _maxSpeed = speed;
        }

        public override void SetMaxSpeed(int speed)
        {
            if (!CheckLimits(speed, LowerSpeedLimit, UpperSpeedLimit))
            {
                throw new ArgumentOutOfRangeException($"Speed has value {speed}, but must be between {LowerSpeedLimit} and {UpperSpeedLimit}");
            }
            _maxSpeed = speed;
        }

        // overrides method of base class
        override public string GetClassName()
        {
            return "Rocket";
        }

        override public OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.AIR, OperatingEnvironment.SPACE };
        }
    }
}
