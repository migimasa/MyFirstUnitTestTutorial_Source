using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstUnitTestTutorial
{
    public class Calculator
    {
        public int Result { get; set; } = 0;
        public Calculator()
        {
               
        }

        public void Add(int x, int y)
        {
            Result += x + y;
        }
    }
}
