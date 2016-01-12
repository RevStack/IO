﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;

namespace RevStack.IO
{
    public interface IEntityStreamRepository : IRepository<EntityStream,string>
    {
        Byte[] Get(string id);
    }
}