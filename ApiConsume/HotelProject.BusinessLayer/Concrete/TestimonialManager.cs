using System;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
	{
        private readonly ITestimonialDal _testimonailDal;

        public TestimonialManager(ITestimonialDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonailDal.Delete(t);
        }

        public Testimonial? TGetByID(int id)
        {
            return _testimonailDal.GetByID(id);
        }

        public List<Testimonial>? TGetList()
        {
            return _testimonailDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonailDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonailDal.Update(t);
        }
    }
}

