using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w) { }

        override public void draw()
        {
            Console.WriteLine("I'm a scroll decorator, holding a: ");
            base.draw();
        }
    }
}
