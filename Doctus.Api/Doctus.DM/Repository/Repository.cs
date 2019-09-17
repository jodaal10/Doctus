//####################################################################
// Project:         Doctus
// Author:          Jonathan Dávila A.
// DATA:            16/09/2019
//####################################################################
namespace Doctus.DM.Repository
{
    using DoctusDT;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected Doctus_BDHorasEntities Db = new Doctus_BDHorasEntities();
        protected DbSet<TEntity> Data;

        //Constructor
        public Repository(Doctus_BDHorasEntities _Db)
        {
            Db = _Db;
            Data = Db.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            Data.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Data.Remove(entity);
            Db.SaveChanges();
        }

        public TEntity FindById(object id)
        {
            return Data.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Data;
        }

        public IQueryable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = Data.Where(predicate);
            return query;
        }

    }
}
