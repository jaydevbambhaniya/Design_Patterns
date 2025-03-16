using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IMobileBuilder
    {
        IMobileBuilder AddMemory(int memory);
        IMobileBuilder AddSim();
        IMobileBuilder AddProcessor(string processorName);
        IMobileBuilder AddOperatingSystem(string osName);
        IMobileBuilder AddTouchScreen(bool enable);
        IMobileBuilder AddKeyPad(bool enable);
        Mobile CreateSystem();

    }
}
