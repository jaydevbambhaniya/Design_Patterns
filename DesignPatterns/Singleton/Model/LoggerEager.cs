using Singleton.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Model
{
    public sealed class LoggerEager : ILogger
    {
        // Created an instance when class is loaded.
        private static readonly LoggerEager _Instance = new LoggerEager();
        private LoggerEager()
        {
            Console.WriteLine("Created Singleton Instance (Eager)");
        }

        public static LoggerEager GetInstance()
        {
            return _Instance;
        }

    }
}
