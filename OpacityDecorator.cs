using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class OpacityDecorator : Decorator
    {
        public OpacityDecorator(Widget w) : base(w) { }

        override public void draw()
        {
            Console.WriteLine("I'm a opacity decorator, holding a: ");
            base.draw();
        }
    }
}
