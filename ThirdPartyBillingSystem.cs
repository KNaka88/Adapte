using System;

namespace Adapter
{
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            var employee = employeeSource.GetEmployeeList();

            Console.WriteLine("**** Employee List ****");
            foreach(var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}