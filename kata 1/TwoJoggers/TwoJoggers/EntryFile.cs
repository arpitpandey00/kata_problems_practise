using System;
using System.Collections.Generic;
using System.Text;

namespace TwoJoggers
{
    public class EntryFile
    {
        public void  KataEntry()
        {
            int x, y;
            Console.WriteLine("Enter Length of ground 1:(bob is running)");
            x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Length of ground 2:(Charls is running)");
            y = Convert.ToInt32(Console.ReadLine());
            Logic logic = new Logic();
            var Output = logic.Kata(x, y);
            Console.WriteLine($"they must run respective rounds : {Output}");
            Console.ReadKey();
        }
    }
}
