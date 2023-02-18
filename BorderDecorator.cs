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
            base.draw();
            Console.WriteLine(this.GetType().Name + " has been drawn.");
        }
    }
}
