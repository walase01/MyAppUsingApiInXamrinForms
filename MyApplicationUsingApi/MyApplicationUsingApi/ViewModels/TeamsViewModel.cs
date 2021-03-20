using MyApplicationUsingApi.Models;
using MyApplicationUsingApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationUsingApi.ViewModels
{
    public class TeamsViewModel : BaseViewModel
    {
        public ObservableCollection<Standard> Teams { get; } = new ObservableCollection<Standard>(); 
        public Standard Selected { get; set; }

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

            if (teamsinformation != null)
            {
                
                foreach(var team in teamsinformation.League.Standard)
                {

                    Teams.Add(team);

                }
                Selected = Teams.FirstOrDefault();
            }
            IsBusy = false;
        }

    }
}
