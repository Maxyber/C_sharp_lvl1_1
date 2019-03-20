using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConsoleInOut
{
    public class ClassConsole
    {
        static public void ConsolePause()
        {
            Console.ReadKey();
        }

        static public void ConsolePrint(string str)
        {
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
