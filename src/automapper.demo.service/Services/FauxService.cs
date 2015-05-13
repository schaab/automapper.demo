using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using automapper.demo.service.Models;

namespace automapper.demo.service.Services
{
    public static class FauxService
    {

        public static FooBarDTO GetFooBar()
        {
            return new FooBarDTO { Foo = "Bar", Bar = "Foo" };
        }
    }
}
