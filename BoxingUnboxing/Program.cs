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
            decimal dm = 1.0M;
            Stopwatch sw = new();
            sw.Start();
            object o = dm;  // boxing
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            Console.WriteLine($"Boxing of decimal has taken {ts.Ticks.ToString()} ticks");

            Stopwatch sw2 = Stopwatch.StartNew();
            decimal d = dm; // assignment
            sw2.Stop();
            TimeSpan ts2 = sw2.Elapsed;

            Console.WriteLine($"Simple assignment takes {ts2.Ticks.ToString()} ticks");
            // to keep compiler happy
            Console.WriteLine((decimal)o);
            Console.WriteLine(d);
        }
        static void MeasureUnboxingTime()
        {
            decimal dm = 1.0M;
            object o = dm;
            Stopwatch sw = new();
            sw.Start();
            decimal d = (decimal)o;  // unboxing
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            Console.WriteLine($"Unboxing of decimal has taken {ts.Ticks.ToString()} ticks");

            Stopwatch sw2 = Stopwatch.StartNew();
            decimal y = dm; // assignment
            sw2.Stop();
            TimeSpan ts2 = sw2.Elapsed;

            Console.WriteLine($"Simple assignment takes {ts2.Ticks.ToString()} ticks");
            // to keep compiler happy
            Console.WriteLine(d);
            Console.WriteLine(y);
        }
    }
}
