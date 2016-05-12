using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadPixelDetection
{
    public class Setup
    {
        private bool mouseInput;
        private int timer;

        public Setup(bool mouseInput, int timer)
        {
            this.mouseInput = mouseInput;
            this.timer = timer;
        }

        public bool MouseInput
        {
            get
            {
                return mouseInput;
            }
            set
            {
                mouseInput = value;
            }
        }

        public int Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }
    }
}
