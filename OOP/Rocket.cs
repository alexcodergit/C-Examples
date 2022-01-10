using System;

namespace OOP
{
    class Rocket : Airplane
    {
        private const int UpperSpeedLimit = 100000;
        private const int LowerSpeedLimit = 0;

        public Rocket()
        { }
        public Rocket(int speed)
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
            return "Rocket";
        }

        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[2] { OperatingEnvironment.Air, OperatingEnvironment.Space };
        }
    }
}
