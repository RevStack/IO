using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RevStack.IO
{
    public class IOFileRespository : IIORepository
    {
        private readonly IOEnumeratorContext _context;
        public IOFileRespository(IOEnumeratorContext context)
        {
            _context = context;
        }

        public FileData Add(FileData entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FileData entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FileData> Find(Expression<Func<FileData, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileData> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileData> Get(string path, string searchPattern, SearchOption searchOption)
        {
            return _context.Get(path, searchPattern, searchOption);
        }

        public Task<IEnumerable<FileData>> GetAsync(string path, string searchPattern, SearchOption searchOption)
        {
            return Task.FromResult(Get(path, searchPattern, searchOption));
        }

        public FileData Update(FileData entity)
        {
            throw new NotImplementedException();
        }
    }
}
