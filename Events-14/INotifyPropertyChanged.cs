using System;

namespace Events_14
{
    interface INotifyPropertyChanged
    {
        public delegate void PropertyChangedEventHandler(Object sender, EventArgs e);
    }
}

