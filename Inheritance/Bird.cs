using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; }

        public bool HasWings { get; set; }

        public double WingSpan { get; set; }

        public double BeakLength { get; set; }

        public void printBirdInfo()
        {
            Console.WriteLine($"Can Fly:{CanFly} ");
            Console.WriteLine($"Has Wings: {HasWings}");
            Console.WriteLine($"Beak Length: {BeakLength}");
            Console.WriteLine($"Wing Span: {WingSpan}");
        }
    }
}
