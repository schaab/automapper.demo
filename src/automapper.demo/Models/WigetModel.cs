using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace automapper.demo.Models
{
    public class WigetModel
    {
        public int Foo { get; set; }
        public DateTime Bar { get; set; }
        public int Property3 { get { return 1 + 1; } }
    }
}