﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ArupConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ArupConsoleService.MathService));
            host.Open();
            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();
            host.Close();
        }
    }
}
