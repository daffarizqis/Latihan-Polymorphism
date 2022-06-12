using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    internal class PrinterWindows
    {
        internal virtual void Show()
        {
            Console.WriteLine("Shows the dimensions");
        }

        internal virtual void Print()
        {
            Console.WriteLine("is Printing...");
        }
    }
}
