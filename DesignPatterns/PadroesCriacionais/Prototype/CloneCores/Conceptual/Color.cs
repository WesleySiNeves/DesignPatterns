using System;

namespace Conceptual
{
    public class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;


        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype ShallowCopy()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}", red, green, blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
