using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Epson : PrinterWindows
    {
        internal override void Show()
        {
            Console.WriteLine("Epson Display dimension : 10*12");
        }

        internal override void Print()
        {
            Console.WriteLine("Epson pirnter printing..");
        }
    }
}
