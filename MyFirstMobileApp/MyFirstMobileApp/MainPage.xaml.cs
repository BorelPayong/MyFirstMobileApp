using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstMobileApp
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
        }
    }
}
