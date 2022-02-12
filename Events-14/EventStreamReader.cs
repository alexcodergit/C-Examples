using System;

namespace Events_14
{
    public class DeviatonEventArgs : EventArgs
    {
        public int PrevNum { get; set; }
        public int CurNum { get; set; }
        public double Deviation { get; set; }
    }

    class EventStreamReader
    {
        private int PrevNumber = 1;
        private readonly double Deviation;

        public event EventHandler DevEvent;

        public EventStreamReader(int percent)
        {
            Deviation = percent;
        }

        public void ReadStreamFromConsole()
        {
            Console.WriteLine("Enter numbers. Enter 'q' ir 'Q' to quit.");
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                if (line == "q" || line == "Q")
                {
                    Console.WriteLine("exiting...");
                    return;
                }
                try
                {
                    int n = int.Parse(line);
                    double diff = n - PrevNumber;
                    if (Math.Abs(diff / PrevNumber) * 100 > Deviation)
                    {
                        DeviatonEventArgs dev = new();
                        dev.PrevNum = PrevNumber;
                        dev.CurNum = n;
                        dev.Deviation = diff / PrevNumber * 100;
                        DevEvent?.Invoke(this, dev);
                    }
                    PrevNumber = n;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
