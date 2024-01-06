using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Areas.Admin.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;


namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Staff");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel model)
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5009/api/Staff", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                var errorContent = await response.Content.ReadAsStringAsync();
                return View();
            }
        }


        public async Task<IActionResult> DeleteStaff(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5009/api/Staff/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/Staff/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<UpdateStaffViewModel>(jsonData);
                    return View(values); 
                }
                return View();
            }

        }


        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel model)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PutAsync("http://localhost:5009/api/Staff/",stringContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }
    }
}