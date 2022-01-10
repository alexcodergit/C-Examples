using System;

namespace OOP
{
    // Car derived from Vehicle
    // contains same fields
    // _maxSpeed
    class Car : Vehicle
    {
        private const int UpperSpeedLimit = 500;
        private const int LowerSpeedLimit = 0;
        public Car()
        {}

        public Car(int speed)
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

        public override string GetClassName()
        {
            return "Car";
        }
        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[1] { OperatingEnvironment.Land };
        }
    }
}
