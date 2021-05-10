using System;
using System.Collections.Generic;
using System.Text;

namespace Enough_is_enough
{
    public class EntryClaass
    {

        public void entry()
        {

        int MaxOccurance;
        Console.WriteLine("Enter max occurance of element");
        MaxOccurance = Convert.ToInt32(Console.ReadLine());
        int length;
        Console.WriteLine("Enter number of element");
        length = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[length];
        
        Console.WriteLine("Enter elements of array");
            for (int i=0;i<length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
        LogicClass logicClass = new LogicClass();
            logicClass.Solution(array, MaxOccurance);
        }
    }
}
