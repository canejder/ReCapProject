using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        
    }
}