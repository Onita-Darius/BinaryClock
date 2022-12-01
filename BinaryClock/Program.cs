using System;
using System.Collections.Generic;
using System.Configuration;
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
            int Ora = int.Parse(Convert.ToString(ora, 2));
            int Min = int.Parse(Convert.ToString(min, 2));
            int Sec = int.Parse(Convert.ToString(sec, 2)); 
            Console.WriteLine($"Current Time is : {now}");
            Console.WriteLine($"Current Time is : {Ora}:{Min}:{Sec}");

            Console.WriteLine();
            Console.WriteLine();
            /// aratam ora (+ este aprins / - este stins)

            if (Ora < 20 &&  Ora > 10) Console.WriteLine ("  H + -"); // Led H 1
            if (Ora > 20 || Ora == 20) Console.WriteLine("  H - +"); // Led H 2
            if (Ora == 0 || Ora < 10) Console.WriteLine("  H - -"); // Led H 0

            int hOra = Ora;
            while (hOra > 10)
            {
                hOra = hOra - 10;
            }
            if (hOra == 1 || hOra == 3 || hOra == 5 || hOra == 7 || hOra == 9) Console.Write("  h + "); else Console.Write("  h - ");
            if (hOra == 2 || hOra == 3 || hOra == 6 || hOra == 7) Console.Write("+ "); else Console.Write("- ");
            if (hOra == 4 || hOra == 5 || hOra == 6 || hOra == 7) Console.Write("+ "); else Console.Write("- ");
            if (hOra == 8 || hOra == 9) Console.Write("+ "); else Console.Write("- ");
            Console.WriteLine();

            /// aratam min

            int Hmin, hMin;

            Hmin = min / 10;
            
            if (Hmin == 1 || Hmin == 3 || Hmin == 5 || Hmin == 7 || Hmin == 9) Console.Write("  M + "); else Console.Write("  M - ");
            if (Hmin == 2 || Hmin == 3 || Hmin == 6 || Hmin == 7) Console.Write("+ "); else Console.Write("- ");
            if (Hmin == 4 || Hmin == 5 || Hmin == 6 || Hmin == 7) Console.Write("+ "); else Console.Write("- ");
            if (Hmin == 8 || Hmin == 9) Console.Write("+ "); else Console.Write("- ");
            Console.WriteLine();

            hMin = min;

            while (hMin > 10)
            {
                hMin = hMin - 10;
            }

            if (hMin == 1 || hMin == 3 || hMin == 5 || hMin == 7 || hMin == 9) Console.Write("  m + "); else Console.Write("  m - ");
            if (hMin == 2 || hMin == 3 || hMin == 6 || hMin == 7) Console.Write("+ "); else Console.Write("- ");
            if (hMin == 4 || hMin == 5 || hMin == 6 || hMin == 7) Console.Write("+ "); else Console.Write("- ");
            if (hMin == 8 || hMin == 9) Console.Write("+ "); else Console.Write("- ");
            Console.WriteLine();

            /// aratam sec

            int Hsec, hSec;

            Hsec = sec / 10;

            if (Hsec == 1 || Hsec == 3 || Hsec == 5 || Hsec == 7 || Hsec == 9) Console.Write("  S + "); else Console.Write("  S - ");
            if (Hsec == 2 || Hsec == 3 || Hsec == 6 || Hsec == 7) Console.Write("+ "); else Console.Write("- ");
            if (Hsec == 4 || Hsec == 5 || Hsec == 6 || Hsec == 7) Console.Write("+ "); else Console.Write("- ");
            if (Hsec == 8 || Hsec == 9) Console.Write("+ "); else Console.Write("- ");
            Console.WriteLine();

            hSec = sec;

            while (hSec > 10)
            {
                hSec = hSec - 10;
            }

            if (hSec == 1 || hSec == 3 || hSec == 5 || hSec == 7 || hSec == 9) Console.Write("  s + "); else Console.Write("  s - ");
            if (hSec == 2 || hSec == 3 || hSec == 6 || hSec == 7) Console.Write("+ "); else Console.Write("- ");
            if (hSec == 4 || hSec == 5 || hSec == 6 || hSec == 7) Console.Write("+ "); else Console.Write("- ");
            if (hSec == 8 || hSec == 9) Console.Write("+ "); else Console.Write("- ");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Main();
        }

    }
}
