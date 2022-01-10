using System;

namespace OOP
{
    class Amphibia : Car
    {
        private const int UpperSpeedLimit = 100;
        private const int LowerSpeedLimit = 0;
        // Amphibia derived from Car
        // contains same fields
        public Amphibia()
        { }

        public Amphibia(int speed)
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
        public override string GetClassName()
        {
            return "Amphibia";
        }

        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.Land, OperatingEnvironment.Water };
        }
    }
}
