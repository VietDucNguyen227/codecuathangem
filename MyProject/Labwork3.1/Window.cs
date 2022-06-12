using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork3._1
{
    class Window
    {
        protected int top;
        protected int left;

        //constructor
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top,left);
        }
    }
}
