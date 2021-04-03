using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);

        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);
        IDataResult<List<User>> GetAllByFirstName(string first);
        IDataResult<List<User>> GetAllByLastName(string last);
        IDataResult<List<User>> GetAllByEmail(string email);
    }
}