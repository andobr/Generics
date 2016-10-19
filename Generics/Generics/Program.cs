using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyEngine { }

    class MyEntity { }

    class MyLogger { }

    class Program
    {
        static void Main(string[] args)
        {
            var processor = ProcessorBuilder.CreateEngine<MyEngine>().For<MyEntity>().With<MyLogger>();
        }
    }
}
