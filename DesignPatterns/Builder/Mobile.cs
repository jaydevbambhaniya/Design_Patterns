using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Mobile
    {
        public int MemorySize { get; set; }

        public string? ProcessorName { get; set; }

        public string? OperatingSystem { get; set; }

        public int StorageSize { get; set; }

        public bool HasKeyPad { get; set; }

        public bool HasTouchScreen { get; set; }

        public bool HasSimCard { get; set; }
    }
}
