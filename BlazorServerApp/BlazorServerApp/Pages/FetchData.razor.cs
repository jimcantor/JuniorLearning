using System;
using System.Threading.Tasks;
using BlazorServerApp.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
    {
    public partial class FetchData
        {
		public WeatherForecast[]? forecasts { get; private set; }
		[Inject] WeatherForecastService? ForecastService { get; set; } // WeatherForecast [] forecasts; }

        protected override async Task OnInitializedAsync()
            {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
            }
        }

    }