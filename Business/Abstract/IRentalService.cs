using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        //C
        IResult Add(Rental rental);
        //R
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllById(int id);
        IDataResult<List<Rental>> GetAllByRentDate(DateTime date);
        IDataResult<List<Rental>> GetAllByReturnDate(DateTime date);
        IDataResult<List<Rental>> GetAllByCarId(int id);
        IDataResult<List<Rental>> GetAllByCustomerId(int id);
        //U
        IResult Update(Rental rental);
        //D
        IResult Delete(Rental rental);
    }
}