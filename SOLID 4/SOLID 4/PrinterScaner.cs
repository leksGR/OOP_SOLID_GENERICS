using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4
{
    internal class PrinterScaner : IPrinterScaner
    {
        public void Print(string document)
        {
            Console.WriteLine($"Печать документа: {document}");
        }
        public void Scan(string document)
        {
            Console.WriteLine($"Сканировать документ: {document}");
        }
    }
}
