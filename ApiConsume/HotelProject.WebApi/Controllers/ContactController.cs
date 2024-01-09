using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost("AddContact")]
        public IActionResult AddContact(Contact contact)
        {
            contact.ReceiverMail = "mertayaar@gmail.com";
            contact.ReceiverName = "Admin";
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }

        [HttpPost("SendMessage")]
        public IActionResult SendMessage(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.GetListInbox("mertayaar@gmail.com");
            return Ok(values);
        }

        [HttpGet("OutboxListContact")]
        public IActionResult OutboxListContact()
        {
            var values = _contactService.GetListOutbox("mertayaar@gmail.com");
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _contactService.TGetByID(id);
            return Ok(values);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var values = _contactService.TGetByID(id);
            _contactService.TDelete(values);
            return Ok();
        }


    }
}
