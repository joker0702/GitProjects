using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghosts
{
    public class Ghost
    {
        public Ghost(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int Size { get; set; }

        public virtual void Haunt()
        {
            Console.WriteLine("{0} sagt: \"Buh\"", this.Name);
        }
    }
}
