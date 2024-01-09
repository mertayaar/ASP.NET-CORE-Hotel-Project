﻿using System;
using HotelProject.WebUI.Areas.Admin.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
	public class _ServicePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/service");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }
    }
}

