using MyApplicationUsingApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationUsingApi.Services
{
    public interface IApiService
    {
        Task<TeamsList> GetCurrencyInformationAsync();
    }
}
