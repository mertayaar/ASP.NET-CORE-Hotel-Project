using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _AddBooking(CreateBookingDto createBookingDto )
        {
            createBookingDto.Status = "Waiting for approval";
            createBookingDto.Description = "Add Description";
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            using (var client = _httpClientFactory.CreateClient())
            {
                createBookingDto.Status = "Waiting for approval";
                var jsonData = JsonConvert.SerializeObject(createBookingDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5009/api/Booking", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "Default");
                }
                return View();
            }
        }

    }
}