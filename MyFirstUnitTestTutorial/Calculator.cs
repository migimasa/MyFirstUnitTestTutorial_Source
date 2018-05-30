using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstUnitTestTutorial
{
    public class Calculator
    {
        public int Result { get; set; }

        public void Add(int x, int y)
        {
            this.Result = x + y;
        }
    }
}
