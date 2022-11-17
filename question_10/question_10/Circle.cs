using System;
using System.Collections.Generic;
using System.Text;

namespace question_10
{
    class Circle:shape
    {
        private double Scope;
        public Circle(double size, double Scope) :base(size)
        {
            this.Scope = Scope;
        }
    }
}
