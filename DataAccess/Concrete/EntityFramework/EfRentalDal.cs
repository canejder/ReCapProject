using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,CarRentalContext>, IRentalDal
    {
        
    }
}