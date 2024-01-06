using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Areas.Admin.Models.Staff;
using HotelProject.WebUI.Areas.Admin.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TestimonialController : Controller
    {
      
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Testimonial");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult AddTestimonal()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestimonal(AddStaffViewModel model)
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5009/api/Testimonial", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                var errorContent = await response.Content.ReadAsStringAsync();
                return View();
            }
        }


        public async Task<IActionResult> DeleteTestimonal(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5009/api/Testimonial/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonal(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/Testimonial/{id}");
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
        public async Task<IActionResult> UpdateTestimonal(UpdateStaffViewModel model)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PutAsync("http://localhost:5009/api/Testimonial/", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }
    }
}