using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars = new List<Car>
        {
            new Car {CarId = 1, BrandId = 1, ColorId = 1, Description = "Sedan aile arabası", ModelYear = new DateTime(1993,1,1)},
            new Car {CarId = 2, BrandId = 1, ColorId = 2, Description = "Sedan aile arabası", ModelYear = new DateTime(2000,1,1)},
            new Car {CarId = 3, BrandId = 2, ColorId = 2, Description = "Coupe 3 kapı spor araba", ModelYear = new DateTime(2010,1,1)},
            new Car {CarId = 4, BrandId = 2, ColorId = 3, Description = "S Segment Supercar", ModelYear = new DateTime(2020,1,1)}
        };
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
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
            Car carToupdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToupdate.BrandId = car.BrandId;
            carToupdate.ColorId = car.ColorId;
            carToupdate.ModelYear = car.ModelYear;
            carToupdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}