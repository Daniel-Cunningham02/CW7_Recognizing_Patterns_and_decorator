using System;

namespace DecoratorPattern
{
    public class Program
    {


        public static void Main(string[] args)
        {
            TextField t = new TextField(20, 30);
            OpacityDecorator o = new OpacityDecorator(t);
            BorderDecorator border = new BorderDecorator(o);
            ScrollDecorator scroll = new ScrollDecorator(border);
            BorderDecorator border2 = new BorderDecorator(scroll);
            ScrollDecorator scroll2 = new ScrollDecorator(border2);
            ScrollDecorator scroll3 = new ScrollDecorator(scroll2);

            scroll3.draw();

        }
    }
}
