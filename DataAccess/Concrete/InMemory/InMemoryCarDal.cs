using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars = new List<Car>
        {
            new Car {Id = 1, BrandId = 1, ColorId = 1, Description = "Sedan aile arabası", ModelYear = "1995"},
            new Car {Id = 2, BrandId = 1, ColorId = 2, Description = "Sedan aile arabası", ModelYear = "2000"},
            new Car {Id = 3, BrandId = 2, ColorId = 2, Description = "Coupe 3 kapı spor araba", ModelYear = "2010"},
            new Car {Id = 4, BrandId = 2, ColorId = 3, Description = "S Segment Supercar", ModelYear = "2020"}
        };
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToupdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToupdate.BrandId = car.BrandId;
            carToupdate.ColorId = car.ColorId;
            carToupdate.ModelYear = car.ModelYear;
            carToupdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}