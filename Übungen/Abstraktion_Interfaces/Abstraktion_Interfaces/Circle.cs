using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktion_Interfaces
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Zeichne Kreis");
        }
    }
}
