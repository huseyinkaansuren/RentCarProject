﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
        public void Add(Car car)
        {
            if (car.CarName.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("CarAdded");
            }
            else
            {
                Console.WriteLine("!!!!!");
            }
        }
        
    }
}
