using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork3._1
{
    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        { 
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n,", top,left);
        }
    }
}
