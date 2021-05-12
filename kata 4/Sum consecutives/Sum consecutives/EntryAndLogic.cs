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
            for (int i = 0; i < array.Length  ; i++)
            {
                int temp=array[i];
                for( int j=i+1;j<array.Length;j++)
                {
                    if(array[j]==array[i])
                    {
                        temp += array[j];
                        i = j;
                    }
                   
                }
                array2.Add(temp);
            }
            array2.ForEach(element => Console.WriteLine(element));
        }
    }
}
