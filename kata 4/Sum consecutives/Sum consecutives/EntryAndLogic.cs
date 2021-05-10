using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_consecutives
{
    public class EntryAndLogic
    {
        public static void entry()
        {
            int length;
            Console.WriteLine("Enter number of element");
            length = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[length];
            List<int> array2 = new List<int> ();
            Console.WriteLine("Enter elements of array");
            for (int i=0;i< length;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i< length-1;i++)
            {
                if (array[i] == array[i + 1])
                {
                    int j = i;
                    int temp = array[j];
                    while (array[j] == array[j + 1])
                    {
                        temp += array[j + 1];
                        j++;
                    }
                    array2.Add(temp);
                    i = j;
                }
                else
                {
                    array2.Add(array[i]);
                        
                };
            }
            if ((array[length - 2] != array[length-1]))
            {
                array2.Add(array[length - 1]);
            }
            array2.ForEach(element => Console.WriteLine(element));
        }
    }
}
