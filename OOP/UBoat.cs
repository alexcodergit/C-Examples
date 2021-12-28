using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class UBoat : Boat
    {
        private const int UpperSpeedLimit = 50;
        private const int LowerSpeedLimit = 0;
        // UBoat derived from Boat
        // contains same fields,
        // _maxSpeed
        public UBoat() : base()
        { }

        public UBoat(int speed)
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
            return "UBoat";
        }
        override public OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.WATER, OperatingEnvironment.UNDER_WATER };
        }
    }
}
