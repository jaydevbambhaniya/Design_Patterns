using Singleton.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Model
{
    public sealed class Logger : ILogger
    {
        private static Logger _Instance;
        private static readonly object _objLock = new object();
        private Logger() 
        {
            Console.WriteLine("Created Singleton Instance (Thread safe)");
        }

        public static Logger GetInstance()
        {
            if (_Instance == null)
            {
                lock (_objLock)
                {
                    return _Instance ??= new Logger();
                }
            }
            return _Instance;
        }
    }
}
