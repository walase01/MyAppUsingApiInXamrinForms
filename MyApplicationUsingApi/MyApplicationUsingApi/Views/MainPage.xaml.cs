using MyApplicationUsingApi.Services;
using MyApplicationUsingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApplicationUsingApi.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new TeamsViewModel(new ApiService());
        }
    }
}
