﻿using System;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
	{
        private readonly ISubscribeDal _subsribeDal;

        public SubscribeManager(ISubscribeDal subsribeDal)
        {
            _subsribeDal = subsribeDal;
        }

        public void TDelete(Subscribe t)
        {
            _subsribeDal.Delete(t);
        }

        public Subscribe? TGetByID(int id)
        {
            return _subsribeDal.GetByID(id);
        }

        public List<Subscribe>? TGetList()
        {
            return _subsribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subsribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subsribeDal.Update(t);
        }
    }
}

