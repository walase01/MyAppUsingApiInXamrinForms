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

        public ObservableCollection<TeamsList> Teams { get; } = new ObservableCollection<TeamsList>();
        public TeamsList Selected { get; set; }

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
                foreach (var teams in Teams)
                {

                    Teams.Add(teams);

                }
                Selected = Teams.FirstOrDefault();
            }
            IsBusy = false;
        }

    }
}
