using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDealershipContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.Id
                    join cl in context.Colors on c.ColorId equals cl.Id
                    select new CarDetailDTO
                    {
                        CarId = c.Id,
                        CarName = c.Name,
                        BrandName = b.Name,
                        DailyPrice = c.DailyPrice,
                        ColorName = cl.Name
                    };
                return result.ToList();
            }
        }
    }
}