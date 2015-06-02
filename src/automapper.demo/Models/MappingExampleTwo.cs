using System;
using automapper.demo.service.Models;

namespace automapper.demo.Models
{
    public class MappingExampleTwo
    {
        public MappingExampleTwo() { }

        public MappingExampleTwo(FooBarDTO foobarDto)
        {
            Foo = foobarDto.Foo;
            Bar = foobarDto.Bar;
        }

        public string Foo { get; set; }
        public string Bar { get; set; }
    }
}