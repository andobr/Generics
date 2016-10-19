using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Engine<TEngine>
    {
        public Entity<TEngine, TEntity> For<TEntity>()
        {
            return new Entity<TEngine, TEntity>();
        }
    }
}
