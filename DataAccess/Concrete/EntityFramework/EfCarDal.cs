using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                return
                    filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Add(Car entity)
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                if (entity.Name.Length >= 2 && entity.DailyPrice > 0)
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                else
                    Console.WriteLine("Hata: Araç ismi 2 karakterden kısa ve günlük bedeli 0'dan küçük olamaz!");
                    
                
            }
        }

        public void Update(Car entity)
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarDealershipContext context = new CarDealershipContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}