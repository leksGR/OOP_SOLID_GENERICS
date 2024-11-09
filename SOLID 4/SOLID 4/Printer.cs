using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4
{
    internal class Printer : IPrinter
    {
        public void Print (string document) 
        {
            Console.WriteLine($"Печать документа: {document}");
        }
    }
}
