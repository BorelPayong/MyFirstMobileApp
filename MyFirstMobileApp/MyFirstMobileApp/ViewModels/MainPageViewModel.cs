using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MyFirstMobileApp.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        #region Properties
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FormattedName));
            }
        }
        public string FormattedName => !string.IsNullOrEmpty(Name) ? $"My name is {Name}" : "";

        private int count;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands
        public Command DownCommand { get; }
        public Command UpCommand { get; }
        #endregion

        public MainPageViewModel()
        {
            Name = "Unknow";
            DownCommand = new Command(OnDownCommand);
            UpCommand = new Command(OnUpCommand);
        }

        private void OnUpCommand(object obj)
        {
            Count++;
        }

        private void OnDownCommand(object obj)
        {
            Count--;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
