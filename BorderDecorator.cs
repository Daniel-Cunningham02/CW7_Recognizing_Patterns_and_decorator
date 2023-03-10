using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class  BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w) { }
        
        override public void draw()
        {
            Console.WriteLine("I'm a border decorator, holding a: ");
            base.draw();
        }
    }
}
