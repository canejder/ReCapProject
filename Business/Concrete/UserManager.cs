using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.User.Added);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.User.Updated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.User.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.User.Listed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserId == id),Messages.User.Listed);
        }

        public IDataResult<List<User>> GetAllByFirstName(string first)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.FirstName == first),Messages.User.Listed);
        }

        public IDataResult<List<User>> GetAllByLastName(string last)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.LastName == last),Messages.User.Listed);
        }

        public IDataResult<List<User>> GetAllByEmail(string email)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Email == email),Messages.User.Listed);

        }
    }
}