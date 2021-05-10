using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_of_differences_between_products_and_LCMs
{
    public class Logic
    {
        public static int SumOfDifferenceOfProduutsAndLcms(int[,] array,int arraylength)
        {
            int[] array1 = new int[arraylength];
            int[] array2 = new int[arraylength];
            int output = 0;
            for(int i=0;i<arraylength; i++)
            {
                int x, y;
                x = array[i,0];
                y = array[i,1];
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
                array1[i] = x * y;
                array2[i] = lcm;
                
            }
            for(int i=0;i< arraylength;i++)
            {
                output += array1[i] - array2[i];
            }
            return output;
        }
    }
}
