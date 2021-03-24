using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllById(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByModelYear(string modelYear);
        
    }
}