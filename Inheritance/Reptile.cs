using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public bool AreColdBlooded { get; set; }

        public bool LayEggs { get; set; }

        public string Habitat { get; set; }
    }
}
