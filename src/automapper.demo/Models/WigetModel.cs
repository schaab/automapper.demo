using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace automapper.demo.Models
{
    public class WigetModel
    {
        public int Property1 { get; set; }
        public DateTime Property2 { get; set; }
        public int Property3 { get { return 1 + 1; } }
    }
}