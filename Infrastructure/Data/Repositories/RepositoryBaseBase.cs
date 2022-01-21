namespace Infrastructure.Data.Repositories
{
    public abstract class RepositoryBaseBase
    {
        protected USAPropertysContext Db = new USAPropertysContext();

        public abstract void Add(TEntity obj);
        public abstract void Dispose();
        public abstract IEnumerable<TEntity> GetAll();
        public abstract TEntity GetById(int id);
        public abstract void Remove(TEntity obj);
        public abstract void Update(TEntity obj);
    }
}