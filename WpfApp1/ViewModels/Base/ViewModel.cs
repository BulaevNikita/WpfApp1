﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp1.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnProperrtyChanged([CallerMemberName] string PropertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));  
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null) 
        {
            if (Equals(field, value)) return false;
            field = value;
            OnProperrtyChanged(PropertyName);
            return true;
        } 
    }
}
