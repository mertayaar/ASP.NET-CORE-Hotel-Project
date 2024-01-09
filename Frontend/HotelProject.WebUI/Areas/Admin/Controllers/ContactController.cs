using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Areas.Admin.Dtos.ContactDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Contact");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                    ViewBag.v = values.Count();
                    return View(values);
                }

                return View();
            }
        }

        public async Task<IActionResult> Outbox()
        {

            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync("http://localhost:5009/api/Contact/OutboxListContact");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);

                    return View(values);
                }

                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> AddSendMessage(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/Contact/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<GetMessageByIDDto>(jsonData);
                    values.Message = "";
                    return View(values);
                }
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateContactDto createContactDto)
        {

            createContactDto.SenderMail = "mertayaar@gmail.com";
            createContactDto.SenderName = "Admin2";
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            using (var client = _httpClientFactory.CreateClient())
            {
                var jsonData = JsonConvert.SerializeObject(createContactDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5009/api/contact/SendMessage", stringContent);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("OutBox");
                }
                return View();
            }
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.DeleteAsync($"http://localhost:5009/api/Contact/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Inbox");
                }
                return View();
            }

        }
        public async Task<IActionResult> MessageDetails(int id)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                var response = await client.GetAsync($"http://localhost:5009/api/Contact/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<GetMessageByIDDto>(jsonData);
                    return View(values);
                }
                return View();
            }
        }
    }
}