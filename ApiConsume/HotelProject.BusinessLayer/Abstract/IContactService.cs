using System;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IContactService : IGenericService<Contact>
	{
        List<Contact> GetListOutbox(string p);

        List<Contact> GetListInbox(string p);
    }
}

