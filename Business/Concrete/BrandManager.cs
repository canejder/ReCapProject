using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllById(int id)
        {
            return _brandDal.GetAll(b => b.Id == id);
        }

        public List<Brand> GetAllByName(string name)
        {
            return _brandDal.GetAll(b => b.Name == name);

        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }
    }
}