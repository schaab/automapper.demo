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

        public static FooBarDTO GetFooBarExampleOne()
        {
            return new FooBarDTO { Foo = "Inline assignment", Bar = "can get really long and messy." };
        }

        public static FooBarDTO GetFooBarExampleTwo()
        {
            return new FooBarDTO { Foo = "Constructor creation is a littel better", Bar = "but couples objects" };
        }

        public static FooBarDTO GetFooBarExampleThree()
        {
            return new FooBarDTO { Foo = "Serenity now", Bar = "mapping clean and simple" };
        }

        public static WidgetDTO GetWidget()
        {
            return new WidgetDTO { Property1 = "42", Property2 = "8/31/1981" };
        }
    }
}
