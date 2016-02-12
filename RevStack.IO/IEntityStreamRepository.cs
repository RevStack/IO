using System;
using RevStack.Pattern;

namespace RevStack.IO
{
    public interface IEntityStreamRepository : IRepository<EntityStream,string>
    {
        Byte[] Get(string id);
    }
}
