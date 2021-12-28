using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Amphibia : Car
    {
        private const int UpperSpeedLimit = 100;
        private const int LowerSpeedLimit = 0;
        // Amphibia derived from Car
        // contains same fields
        public Amphibia() : base()
        { }

        public Amphibia(int speed):base()
        {
            if (!CheckLimits(speed, LowerSpeedLimit, UpperSpeedLimit))
            {
                throw new ArgumentOutOfRangeException($"Speed has value {speed}, but must be between {LowerSpeedLimit} and {UpperSpeedLimit}");
            }
            _maxSpeed = speed;
        }

        // overrides method of base class
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
            return "Amphibia";
        }

        override public OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.LAND, OperatingEnvironment.WATER };
        }
    }
}
