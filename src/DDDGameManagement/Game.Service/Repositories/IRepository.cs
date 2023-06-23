namespace Game.Service.Repositories
{
    public interface IRepository<T, K>  where T : class  
    {
        T Find(K id);
        T FindByName(string name);
        void Add(T entity);
        void Delete(K id);
        void Update(K id, T entity);
    }
}