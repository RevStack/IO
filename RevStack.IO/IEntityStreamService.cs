using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;

namespace RevStack.IO
{
    public interface IEntityStreamService : IService<EntityStream,string>
    {
        Byte[] Get(string id);
        Task<Byte[]> GetAsync(string id);
    }
}
