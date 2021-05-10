using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_of_differences_between_products_and_LCMs
{
    public class EntryClass
    {
        public void EnterArray()
        {
            Console.WriteLine("enter length of 2D array");
            int Length_2DArray = Convert.ToInt32(Console.ReadLine());
            int[,] Array2D = new int[Length_2DArray,2];
            Console.WriteLine("enter 2D array");
            for (int i=0;i<Length_2DArray;i++)
            {
                for(int j=0;j<2;j++)
                {
                   Array2D[i,j]=Convert.ToInt32( Console.ReadLine());
                }
            }
            //Console.WriteLine(Array2D.Length);
            var number = Logic.SumOfDifferenceOfProduutsAndLcms(Array2D, Length_2DArray);
            Console.WriteLine($"Output is :{number}");
        }
    }
}
