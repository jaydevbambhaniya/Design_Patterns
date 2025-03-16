using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MobileBuilder : IMobileBuilder
    {
        private Mobile _mobile = new();
        public IMobileBuilder AddKeyPad(bool enable)
        {
            _mobile.HasKeyPad = enable;
            return this;
        }

        public IMobileBuilder AddMemory(int memory)
        {
            _mobile.MemorySize = memory;
            return this;
        }

        public IMobileBuilder AddOperatingSystem(string osName)
        {
            _mobile.OperatingSystem = osName;
            return this;
        }

        public IMobileBuilder AddProcessor(string processorName)
        {
            _mobile.ProcessorName = processorName;
            return this;
        }

        public IMobileBuilder AddSim()
        {
            _mobile.HasSimCard = true;
            return this;
        }

        public IMobileBuilder AddTouchScreen(bool enable)
        {
            _mobile.HasTouchScreen = enable;
            return this;
        }

        public Mobile CreateSystem()
        {
            return _mobile;
        }
    }
}
