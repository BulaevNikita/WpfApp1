using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.ViewModels.Base;

namespace WpfApp1.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        public string Title 
        {
            get => _Title;
            // set 
            //{
            //if (Equals(_Title, value)) return;
            //_Title = value;
            //OnProperrtyChanged();
            //}
            set => Set(ref _Title, value);
        }
        #endregion
    }
}
