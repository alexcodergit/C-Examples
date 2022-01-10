using System;

namespace OOP
{
    // Boat derived from Vehicle
    // contains same fields,
    // _maxSpeed
    // and additionally some constants
    class Boat : Vehicle
    {
        private const int UpperSpeedLimit = 50;
        private const int LowerSpeedLimit = 0;

        public Boat()
        { }

        public Boat(int speed)
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

        public override string GetClassName()
        {
            return "Boat";
        }

        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[1] { OperatingEnvironment.Water };
        }
    }
}
