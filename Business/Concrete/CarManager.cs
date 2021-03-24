using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            _carDal.Add(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllById(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetAllByName(string name)
        {
            return _carDal.GetAll(c => c.Name == name);
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetAllByModelYear(string modelYear)
        {
            return _carDal.GetAll(c => c.ModelYear == modelYear);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }
    }
}