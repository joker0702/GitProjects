using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghosts
{
    public class CannibalGhost : Ghost
    {
        public CannibalGhost(string name)
            : base (name)
        {

        }

        public CannibalGhost()
            : base("")
        {

        }

        public void Eat(ref Ghost ghost)
        {
            IncreaseSize(ghost.Size);
            ghost = null;
        }

        public void Eat(ref SlimeGhost slimeGhost)
        {
            IncreaseSize(slimeGhost.Size);
            slimeGhost = null;
        }

        public void Eat(ref CannibalGhost cannibalGhost)
        {
            IncreaseSize(cannibalGhost.Size);
            cannibalGhost = null;
        }

        public void IncreaseSize(int size)
        {
            this.Size = size;
        }
    }
}
