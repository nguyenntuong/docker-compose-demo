using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetcore_service.Models;
using System.Net.Http;
using System.Text.Json;

namespace aspnetcore_service.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _http;

        public HomeController(ILogger<HomeController> logger, HttpClient http)
        {
            _logger = logger;
            this._http = http;
        }

        public async Task<IActionResult> Index()
        {
            var res = await _http.GetStreamAsync("http://stock-service");
            var json = await JsonSerializer.DeserializeAsync<StockModel>(res);
            return View(json);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
