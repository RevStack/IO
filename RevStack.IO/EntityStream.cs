using System;
using System.IO;
using RevStack.Pattern;

namespace RevStack.IO
{
    public class EntityStream : IEntity<string>
    {
        public string Id { get; set; }
    }
}
