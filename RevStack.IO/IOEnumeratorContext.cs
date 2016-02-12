using System;
using System.Collections.Generic;
using System.IO;

namespace RevStack.IO
{
    public class IOEnumeratorContext
    {
        public IEnumerable<FileData> Get(string path, string searchPattern, SearchOption searchOption)
        {
            return FastDirectoryEnumerator.EnumerateFiles(path,searchPattern,searchOption);
        }
    }
}
