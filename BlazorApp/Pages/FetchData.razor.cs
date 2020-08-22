using Shared.BusinessLogic.Interfaces;
using Shared.BusinessLogic.Services;
using Shared.Model.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class FetchData : ComponentBase
    {
        private WeatherForecast[] forecasts;

        [Inject]
        public IWeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
