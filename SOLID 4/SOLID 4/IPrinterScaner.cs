using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4
{
    internal interface IPrinterScaner
    {
        void Print(string document);
        void Scan(string document);
    }
}
