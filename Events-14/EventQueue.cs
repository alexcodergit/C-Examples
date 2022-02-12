using System;
using System.Collections.Generic;

namespace Events_14
{
    class EventQueue
    {
        private readonly Queue<int> EQueue;
        private readonly int _threshhold;

        public int Count
        {
            get { return EQueue.Count; }
        }
        public event EventHandler ThresholdExceeded;

        public EventQueue(int eventThreshhold)
        {
            EQueue = new Queue<int>();
            _threshhold = eventThreshhold;
        }
        public void Enqueue(int n)
        {
            EQueue.Enqueue(n);
            if (EQueue.Count > _threshhold)
            {
                ThresholdExceeded?.Invoke(this, EventArgs.Empty);
            }
        }

        public int Dequeue()
        {
            int ret = EQueue.Dequeue();
            if (EQueue.Count < 1)
            {
                ThresholdExceeded?.Invoke(this, EventArgs.Empty);
            }
            return ret;
        }
    }
}
