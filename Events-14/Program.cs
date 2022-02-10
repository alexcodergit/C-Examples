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
        }

        static void BalanceChanged(Object sender, EventArgs e)
        {
            Console.WriteLine($"Balance of {((Person)sender).Name} changed. Old balance: {((BalanceChangedEventArgs)e).OldAmount}, new balance {((BalanceChangedEventArgs)e).NewAmount}");
        }
        static void DepartmentChanged(Object sender, EventArgs e)
        {
            Console.WriteLine($"Departmnet of {((Employee)sender).Name} changed. Old department: {((DepartmentChangedEventArgs)e).OldDepartment}, new department {((DepartmentChangedEventArgs)e).NewDepartment}");
        }
    }
}
