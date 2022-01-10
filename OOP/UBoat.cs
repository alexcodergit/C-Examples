using System;

namespace OOP
{
    class UBoat : Boat
    {
        private const int UpperSpeedLimit = 50;
        private const int LowerSpeedLimit = 0;
        // UBoat derived from Boat
        // contains same fields,
        // _maxSpeed
        public UBoat()
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
        public override string GetClassName()
        {
            return "UBoat";
        }
        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.Water, OperatingEnvironment.UnderWater };
        }
    }
}
