using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color entity)
        {
            _colorDal.Add(entity);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetAllById(int id)
        {
            return _colorDal.GetAll(c => c.Id == id);
        }

        public List<Color> GetAllByName(string name)
        {
            return _colorDal.GetAll(c => c.Name == name);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
        }
    }
}