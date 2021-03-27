using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>,IUserDal
    {
        
    }
}