//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            16/09/2019
//####################################################################
namespace Doctus.DM.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate);
        TEntity FindById(object id);
        void Create(TEntity entity);
        void Delete(TEntity entity);
    }
}
