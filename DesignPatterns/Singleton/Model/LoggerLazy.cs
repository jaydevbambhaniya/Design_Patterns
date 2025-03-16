using Singleton.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Model
{
    public sealed class LoggerLazy : ILogger
    {
        // Thread safe & Lazy access, no need to handle explicit locking mechanism.
        private readonly static Lazy<LoggerLazy> _Instance = new(() => new LoggerLazy());

        private LoggerLazy()
        {
            Console.WriteLine("Created Singleton Instance (Lazy)");
        }
        public static LoggerLazy GetInstance()
        {
            return _Instance.Value;
        }
    }
}
