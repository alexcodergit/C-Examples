using System;

namespace Events_14
{
    public class DepartmentChangedEventArgs : EventArgs
    {
        public string OldDepartment { get; set; }
        public string NewDepartment { get; set; }
    }

    class Employee : INotifyPropertyChanged
    {
        public string Name { get; init; }
        private string _department;

        public event INotifyPropertyChanged.PropertyChangedEventHandler Handler;

        public Employee(string n)
        {
            Name = n;
            _department = "General";
        }

        public void ChangeDepartment(string department)
        {
            DepartmentChangedEventArgs args = new();
            args.OldDepartment = _department;
            _department = department;
            args.NewDepartment = _department;
            NotifyPropertyChanged(args);
        }
        public void NotifyPropertyChanged(EventArgs e)
        {
            Handler?.Invoke(this, e);
        }
    }
}
