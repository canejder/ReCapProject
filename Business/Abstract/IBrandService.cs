using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        //C
        void Add(Brand entity);
        //R
        List<Brand> GetAll();
        List<Brand> GetAllById(int id);
        List<Brand> GetAllByName(string name);
        //U
        void Update(Brand entity);
        //D
        void Delete(Brand entity);
    }
}