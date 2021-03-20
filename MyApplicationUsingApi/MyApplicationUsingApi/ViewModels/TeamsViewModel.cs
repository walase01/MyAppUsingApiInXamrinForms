using MyApplicationUsingApi.Models;
using MyApplicationUsingApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MyApplicationUsingApi.ViewModels
{
    public class TeamsViewModel : BaseViewModel
    {
        public Standard referencia { get; set; }
        public ObservableCollection<String> Teams { get; } = new ObservableCollection<String>(); 
        public String Selected { get; set; }

        private IApiService apiService;
        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public TeamsViewModel(IApiService TeamsApiService)
        {
           this.apiService = TeamsApiService;
           LoadTeams();
        }

        async Task LoadTeams()
        {
            IsBusy = true;

            var teamsinformation = await apiService.GetCurrencyInformationAsync();
            var Info = teamsinformation.League.Standard;

            if((Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                if (teamsinformation != null)
                {

                    foreach (Standard team in Info)
                    {

                        Teams.Add(team.FullName.ToString());

                    }
                    Selected = Teams[0];
                }
                IsBusy = false;

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error","No tiene Acceso a internet","cancel");
            }


        }

    }
}
