using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        //C
        IResult Add(Brand entity);
        //R
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int id);
        IDataResult<List<Brand>> GetAllByName(string name);
        //U
        IResult Update(Brand entity);
        //D
        IResult Delete(Brand entity);
    }
}