using System;
using System.Collections.Generic;
using System.Text;

namespace Labwork3._1
{
    class ListBox : Window
    {
        private string ListBoxContent;
        public ListBox(int top, int left, string contents) : base(top, left) //call base constructor
        {
            ListBoxContent = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox: {0}", ListBoxContent);
        }
    }
}
