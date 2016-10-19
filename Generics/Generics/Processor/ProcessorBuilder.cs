using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class ProcessorBuilder
    {
        static public Engine<TEngine> CreateEngine<TEngine>()
        {
            return new Engine<TEngine>();
        }
    }
}
