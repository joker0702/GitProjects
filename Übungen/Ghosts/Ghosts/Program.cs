using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Ghost ghost1 = new Ghost("Spooky");
            ghost1.Haunt();

            Ghost ghost2 = new SlimeGhost("Slimey");
            Console.WriteLine("Slime Ghost Name is: {0}", ghost2.Name);
            ghost2.Haunt();

            Ghost ghost3 = new SlimeGhost("Smeargol");
            ghost3.Size = 5;
            ghost3.Haunt();

            CannibalGhost hungryGhost = new CannibalGhost("Hungry Boy");
            hungryGhost.Size = 1;
            hungryGhost.Eat(ref ghost3);
            Console.WriteLine("Die Größe von {0}: {1}", hungryGhost.Name, hungryGhost.Size);

            Console.ReadLine();
        }
    }
}
