using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ProcessorBuilder
    {
        static public EntityAdder<TEngine> CreateEngine<TEngine>()
        {
            return new EntityAdder<TEngine>();
        }
    }
}
