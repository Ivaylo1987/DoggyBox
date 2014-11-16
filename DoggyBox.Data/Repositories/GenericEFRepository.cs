namespace DoggyBox.Data.Repositories
{
    using Application.Models.Base;
    using DoggyBox.Data.Contracts;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Linq.Expressions;

    public class GenericEFRepository<T> : IGenericRepository<T> where T : class, IAuditInfo
    {
        private DbContext context;
        private IDbSet<T> set;

        public GenericEFRepository(DbContext context)
        {
            this.context = context;
            this.set = this.context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.set.Where(x => x.DeletedOn == null);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return this.set;
        }

        public T Find(object id)
        {
            return this.set.Find(id);
        }

        public void Add(T entity)
        {
            entity.CreatedOn = DateTime.Now;
            this.ChangeState(entity, EntityState.Added);
        }

        public void Update(T entity)
        {
            entity.ModifiedOn = DateTime.Now;
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Delete(T entity)
        {
            entity.DeletedOn = DateTime.Now;
            this.ChangeState(entity, EntityState.Modified);
        }

        public void Delete(object id)
        {
            var entity = this.Find(id);
            this.Delete(entity);
        }

        public void TotalDelete(T entity)
        {
            this.ChangeState(entity, EntityState.Deleted);
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private void ChangeState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }
    }
}
