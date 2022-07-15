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
    }
}
