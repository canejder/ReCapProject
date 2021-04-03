using System;
using System.Collections.Generic;
using Business.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        //C
        IResult Add(Car entity);
        //R
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetAllByName(string name);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<Car>> GetAllByModelYear(DateTime modelYear);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        //U
        IResult Update(Car entity);
        //D
        IResult Delete(Car entity);
    }
}