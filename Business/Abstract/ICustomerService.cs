using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllById(int id);
        IDataResult<List<Customer>> GetAllByUserId(int id);
        IDataResult<List<Customer>> GetAllByCompanyName(string name);
    }
}