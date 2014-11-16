namespace DoggyBox.Data.Contracts
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();

        void Add(T entity);

        T Find(object id);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);

        void TotalDelete(T entity);
    }
}
