using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10
{
    public class class1
    {
        public class ExampleClass
        {
            public int returnSquare(int irNumber)
            {
                return irNumber * irNumber;
            }

            private int threesquare(int gg)
            {
                return gg * gg * gg;
            }

            public int callThreeSquare(int cc)
            {
                return threesquare(cc);

            }

        }
    }

}
