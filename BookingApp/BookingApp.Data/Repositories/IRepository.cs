using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(int id);

        TEntity GetById(int id);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        // bu şekilde x.name gibi aramaları yapabiliyoruz predicate te parametre

        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);


    }
}
