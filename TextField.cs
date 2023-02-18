using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("TextField(" + width + ", " + height + ") has been drawn.");
        }
    }
}
