﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_5
{
    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Регестрация в файле: {message}");
        }
    }
}