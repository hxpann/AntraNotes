using System;
using Assignment4;
using Repository;

public class GenericRepository<T> : IRepository<T> where T : class
{
    protected readonly PeopleContext context;
    public GenericRepository(PeopleContext context) 
    {
        this.context = context;
    }
    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
    }
    public void Remove(T entity)
    {
        context.Set<T>().Remove(entity);
    }
    public void Save()
    {
        context.SaveChanges();
    }
    public IEnumerable<T> GetAll()
    {
        return context.Set < T > ().ToList();
    }
    public Entity GetById(int id)
    {
        return context.Set < T > ().Find(id);
    }

}