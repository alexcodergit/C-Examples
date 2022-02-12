using System;

namespace Events_14
{
    class Program
    {
        static void Main()
        {
            var alex = new Person("Alex");
            alex.Handler += BalanceChanged;
            alex.TransferAmount(20);
            alex.Handler -= BalanceChanged;
            Console.WriteLine();

            var felix = new Person("Felix");
            felix.Handler += BalanceChanged;
            felix.TransferAmount(-50);
            felix.Handler -= BalanceChanged;
            Console.WriteLine();

            var an = new Employee("Antonio");
            an.Handler += DepartmentChanged;
            an.ChangeDepartment("Executive");
            an.Handler -= DepartmentChanged;
            Console.WriteLine();

            Console.WriteLine("Using Event Queue");
            var eq = new EventQueue(3);
            eq.ThresholdExceeded += QueueThreshhold;
            eq.Enqueue(1);
            eq.Enqueue(2);
            eq.Enqueue(3);
            eq.Enqueue(4);
            int x = eq.Dequeue();
            x = eq.Dequeue();
            x = eq.Dequeue();
            x = eq.Dequeue();

            var esr = new EventStreamReader(50);
            esr.DevEvent += DeviationEvent;
            esr.ReadStreamFromConsole();
            esr.DevEvent -= DeviationEvent;
        }

        static void BalanceChanged(Object sender, EventArgs e)
        {
            Console.WriteLine($"Balance of {((Person)sender).Name} changed. Old balance: {((BalanceChangedEventArgs)e).OldAmount}, new balance {((BalanceChangedEventArgs)e).NewAmount}");
        }
        static void DepartmentChanged(Object sender, EventArgs e)
        {
            Console.WriteLine($"Departmnet of {((Employee)sender).Name} changed. Old department: {((DepartmentChangedEventArgs)e).OldDepartment}, new department {((DepartmentChangedEventArgs)e).NewDepartment}");
        }
        static void QueueThreshhold(Object sender, EventArgs e)
        {
            if (((EventQueue)sender).Count > 0)
            {
                Console.WriteLine($"Queue contains {((EventQueue)sender).Count} elements.");
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }
        static void DeviationEvent(Object sender, EventArgs e)
        {
            Console.WriteLine($"Previous number: {((DeviatonEventArgs)e).PrevNum}, " +
                $"current number: {((DeviatonEventArgs)e).CurNum}, " +
                $"deviation: {((DeviatonEventArgs)e).Deviation}");
        }
    }
}
