using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        //C
        void Add(Car entity);
        //R
        List<Car> GetAll();
        List<Car> GetAllById(int id);
        List<Car> GetAllByName(string name);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByModelYear(string modelYear);
        List<CarDetailDTO> GetCarDetails();
        //U
        void Update(Car entity);
        //D
        void Delete(Car entity);
    }
}