using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock
{
    internal class Program
    {
        static void Main()
        {       
            string now = string.Format("{0:HH:mm:ss}", DateTime.Now);
            char[] separator = new char[] { ' ', ',', ':' };
            string[] x = now.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int ora, min, sec;
            ora = int.Parse(x[0]);
            min = int.Parse(x[1]);
            sec = int.Parse(x[2]);
            string Ora = Convert.ToString(ora, 2);
            string Min = Convert.ToString(min, 2);
            string Sec = Convert.ToString(sec, 2); 
            Console.WriteLine($"Current Time is : {now}");
            Console.WriteLine($"Current Time is : {Ora}:{Min}:{Sec}");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Main();
        }
    }
}
