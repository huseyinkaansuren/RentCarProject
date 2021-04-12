using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 3)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Brand Added");
            }
            else
            {
                Console.WriteLine("!!!!!");
            }
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
    }
}
