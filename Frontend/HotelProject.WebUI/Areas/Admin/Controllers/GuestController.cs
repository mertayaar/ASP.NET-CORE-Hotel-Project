using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Areas.Admin.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class GuestController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GuestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Guest");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult AddGuest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuest(CreateGuestDto createGuestDto)
        {
            if (ModelState.IsValid)
            {
                using (var client = _httpClientFactory.CreateClient())
                {
                    var jsonData = JsonConvert.SerializeObject(createGuestDto);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:5009/api/Guest", stringContent);
                    if (response.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                 
                    return View();
                }

            }
            else
            {
                return View();
            }
         
        }


        public async Task<IActionResult> DeleteGuest(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5009/api/Guest/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> UpdateGuest(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/Guest/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);
                    return View(values);
                }
                return View();
            }

        }


        [HttpPost]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            if (ModelState.IsValid)
            {
                using (var client = _httpClientFactory.CreateClient())
                {
                    var jsonData = JsonConvert.SerializeObject(updateGuestDto);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://localhost:5009/api/Guest/", stringContent);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    return View();
                }
            }
            else
            {
                return View();
            }
          

        }
    }
}