﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}
