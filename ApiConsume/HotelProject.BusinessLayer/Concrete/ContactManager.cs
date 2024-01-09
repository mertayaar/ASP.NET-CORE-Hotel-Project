using System;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
	{
        private readonly IContactDal _contactDal;
       
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetListInbox(string p)
        {
            return _contactDal.GetByFilter(x => x.ReceiverMail == p);
        }

        public List<Contact> GetListOutbox(string p)
        {
            return _contactDal.GetByFilter(x => x.SenderMail == p);
        }

        public void TDelete(Contact? t)
        {
            _contactDal.Delete(t);
        }

        public Contact? TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact>? TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}

