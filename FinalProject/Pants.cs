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
        public Pants(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public override string Name { get; set; }

        public override string Description { get; set; }
    }
}
