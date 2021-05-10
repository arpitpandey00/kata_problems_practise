using System;
using System.Collections.Generic;
using System.Text;

namespace TwoJoggers
{
    public class Logic
    {
        public Tuple<int,int> Kata(int x,int y)
        {
            int num1 = x, num2 = y;
            int lcm;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (x * y) / num1;

             int NoOfRoundForA, NoOfRoundForB;

            
                NoOfRoundForA = lcm / x;
                NoOfRoundForB = lcm / y;

             
            
            
            return new Tuple<int,int>(NoOfRoundForA, NoOfRoundForB);
            

            

        }
    }
}
