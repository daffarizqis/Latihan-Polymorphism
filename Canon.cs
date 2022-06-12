using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Canon : PrinterWindows
    {
        internal override void Show()
        {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }

        internal override void Print()
        {
            Console.WriteLine("Canon pirnter printing..");
        }
    }
}
