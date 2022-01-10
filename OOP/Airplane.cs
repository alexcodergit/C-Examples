using System;

namespace OOP
{
    class Airplane : Vehicle
    {
        private const int UpperSpeedLimit = 1000;
        private const int LowerSpeedLimit = 0;

        public Airplane()
        { }

        public Airplane(int speed)
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
            return "Airplane";
        }

        public override OperatingEnvironment[] GetEnvironment()
        {
            return new OperatingEnvironment[1] { OperatingEnvironment.Air };
        }
    }
}
