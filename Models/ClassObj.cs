using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadmeGenerator.Models
{
    internal class ClassObj
    {
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public List<MethodObj>? Methods { get; set; }
        public List<PropertyObj>? Properties { get; set; }
        public List<EventObj>? Events { get; set; }

        public ClassObj()
        {
            Name = "";
            Summary = "";
            Methods = new List<MethodObj>();
            Properties = new List<PropertyObj>();
            Events = new List<EventObj>();
        }
    }
}
