using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class EntityAdder<TEngine> 
    {
        public LoggerAdder<TEngine, TEntity> For<TEntity>()
        {
            return new LoggerAdder<TEngine, TEntity>();
        }
    }
}
