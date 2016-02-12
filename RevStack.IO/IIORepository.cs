using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using RevStack.Pattern;


namespace RevStack.IO
{
    public interface IIORepository : IRepository<FileData,string>
    {
        IEnumerable<FileData> Get(string path, string searchPattern, SearchOption searchOption);
        Task<IEnumerable<FileData>> GetAsync(string path, string searchPattern, SearchOption searchOption);

    }
}
