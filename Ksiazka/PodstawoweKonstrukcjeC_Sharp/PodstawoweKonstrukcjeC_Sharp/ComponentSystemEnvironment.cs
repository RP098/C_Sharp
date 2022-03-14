using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class ComponentSystemEnvironment
    {
        public void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}",drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processor: {0}", Environment.ProcessorCount);
            Console.WriteLine("NET Version: {0}", Environment.Version);
            Console.WriteLine("Machine Name: {0}", Environment.MachineName);
            Console.WriteLine("Exit Code: {0}", Environment.ExitCode);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("System Directory: {0}", Environment.SystemDirectory);

        }

    }
}
