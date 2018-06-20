using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget Itarget = new EmployeeAdapter();
            var client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadLine();
        }
    }
}
