using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        List<User> IEntityRepo<User>.GetAll(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
