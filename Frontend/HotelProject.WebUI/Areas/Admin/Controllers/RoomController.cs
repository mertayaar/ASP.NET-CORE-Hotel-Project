using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Areas.Admin.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Room");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDto createRoomDto)
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(createRoomDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5009/api/Room", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                return View();
            }
        }


        public async Task<IActionResult> DeleteRoom(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5009/api/room/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/room/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<UpdateRoomDto>(jsonData);
                    return View(values);
                }
                return View();
            }

        }


        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (ModelState.IsValid)
            {
                using (var client = _httpClientFactory.CreateClient())
                {
                    var jsonData = JsonConvert.SerializeObject(updateRoomDto);
                    StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync("http://localhost:5009/api/Room/", stringContent);

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