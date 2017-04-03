using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktion_Interfaces
{
    public abstract class Shape
    {
        public int Top { get; set; }
        public int Left { get; set; }

        public ConsoleColor Color { get; set; }

        public abstract void Draw();
    }
}
