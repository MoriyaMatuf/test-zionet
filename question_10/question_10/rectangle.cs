using System;
using System.Collections.Generic;
using System.Text;

namespace question_10
{
    class rectangle:shape
    {
        private double Length;
        public rectangle(double size, double Length) : base(size)
        {
            this.Length = Length;
        }
    }
}
