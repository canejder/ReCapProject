using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        //C
        IResult Add(Color entity);
        //R
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int id);
        IDataResult<List<Color>> GetAllByName(string name);
        //U
        IResult Update(Color entity);
        //D
        IResult Delete(Color entity);

    }
}