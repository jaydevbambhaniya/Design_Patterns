using Builder;

// Fluent Builder (as we are doing chaining of operatins)
IMobileBuilder builder = new MobileBuilder();
Mobile mobile = builder.AddOperatingSystem("IOS")
                        .AddProcessor("A14")
                        .AddMemory(8192)
                        .AddKeyPad(true)
                        .AddSim()
                        .CreateSystem();

Console.WriteLine("Mobile Created with OS: " + mobile.OperatingSystem);