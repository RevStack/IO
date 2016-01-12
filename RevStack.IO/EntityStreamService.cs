using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RevStack.IO
{
    public class EntityStreamService : IEntityStreamService
    {
        private readonly IEntityStreamRepository _repository;
        public EntityStreamService(IEntityStreamRepository repository)
        {
            _repository = repository;
        }

        public byte[] Get(string id)
        {
            return _repository.Get(id);
        }

        public Task<byte[]> GetAsync(string id)
        {
            return Task.FromResult(Get(id));
        }

        public EntityStream Add(EntityStream entity)
        {
            throw new NotImplementedException();
        }

        public Task<EntityStream> AddAsync(EntityStream entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(EntityStream entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(EntityStream entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EntityStream> Find(Expression<Func<EntityStream, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<EntityStream>> FindAsync(Expression<Func<EntityStream, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityStream> Get()
        {
            throw new NotImplementedException();
        }

       

        public Task<IEnumerable<EntityStream>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public EntityStream Update(EntityStream entity)
        {
            throw new NotImplementedException();
        }

        public Task<EntityStream> UpdateAsync(EntityStream entity)
        {
            throw new NotImplementedException();
        }
    }
}
