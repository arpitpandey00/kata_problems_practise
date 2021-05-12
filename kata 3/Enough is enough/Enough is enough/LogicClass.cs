using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enough_is_enough
{
    public class LogicClass
    {
        public void Solution(int[] array ,int count)
        {
            int max = 0;
            List<int> finalArray = new List<int>();
            
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]>max)
                {
                    max = array[i];
                }
            }
            int[] hashArray = new int[max + 1];
            for (int i = 0; i < hashArray.Length; i++)
            {
                hashArray[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                hashArray[array[i]]++;
                if (hashArray[array[i]] > count)
                {
                    hashArray[array[i]] = count;
                }
            }
            for(int i=0;i<array.Length;i++)
            {
                if(hashArray[array[i]]<1 )
                {
                    i++;
                }
                else if(hashArray[array[i]]<=count && hashArray[array[i]]>=1)
                {
                    finalArray.Add( array[i]);
                    hashArray[array[i]]--;
                }
               
            }
            Console.WriteLine("final output");
            finalArray.ForEach(elements => Console.WriteLine(elements));

          //  or-----------------
            //    foreach(int number in array)
            //{
            //    if(finalArray.Where(x=>x==number).Count()<count)
            //    {
            //        finalArray.Add(number);
            //    }
            //}
        }
    }
}
