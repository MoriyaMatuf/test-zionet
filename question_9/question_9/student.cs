using System;
using System.Collections.Generic;
using System.Text;

namespace question_9
{
    class student: person
    {
        private string Course;
        private char clas;
        private int mark;
        public student(int i, int a, string n, string c,char clas,int m) : base(i,a,n)
        { 
            this.Course = c;
            this.clas = clas;
            this.mark = m;


        } 
        public int getSomething()
        {
            return mark;
        }

    }
}
