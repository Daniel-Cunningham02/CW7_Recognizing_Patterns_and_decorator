using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }

        virtual public void draw()
        {
            wid.draw();
        }

    }
}
