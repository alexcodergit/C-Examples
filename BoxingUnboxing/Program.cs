using System;
using System.Diagnostics;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasureBoxingTime();
            MeasureUnboxingTime();
            Console.ReadLine();
        }
        static void MeasureBoxingTime()
        {
            var dm = 1.0M;
            Stopwatch sw = new();
            sw.Start();
            object o = dm;  // boxing
            sw.Stop();
            var ts = sw.Elapsed;

            Console.WriteLine($"Boxing of decimal has taken {ts.Ticks} ticks");

            var sw2 = Stopwatch.StartNew();
            decimal d = dm; // assignment
            sw2.Stop();
            var ts2 = sw2.Elapsed;

            Console.WriteLine($"Simple assignment takes {ts2.Ticks} ticks");
            // to keep compiler happy
            Console.WriteLine((decimal)o);
            Console.WriteLine(d);
        }
        static void MeasureUnboxingTime()
        {
            var dm = 1.0M;
            var o = dm;
            Stopwatch sw = new();
            sw.Start();
            decimal d = o;  // unboxing
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            Console.WriteLine($"Unboxing of decimal has taken {ts.Ticks} ticks");

            var sw2 = Stopwatch.StartNew();
            var y = dm; // assignment
            sw2.Stop();
            var ts2 = sw2.Elapsed;

            Console.WriteLine($"Simple assignment takes {ts2.Ticks} ticks");
            // to keep compiler happy
            Console.WriteLine(d);
            Console.WriteLine(y);
        }
    }
}
