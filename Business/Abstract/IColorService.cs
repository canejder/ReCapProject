using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        //C
        void Add(Color entity);
        //R
        List<Color> GetAll();
        List<Color> GetAllById(int id);
        List<Color> GetAllByName(string name);
        //U
        void Update(Color entity);
        //D
        void Delete(Color entity);

    }
}