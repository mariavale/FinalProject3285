using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Pants : Article
    {
        public Pants()
        {

        }
        public Pants(string Name, string Type, string Description)
        {
            this.Name = Name;
            this.Type = Type;
            this.Description = " ";
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public override string Description { get; set; }
    }
}
