using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class CustomerDocumentComponent : IDocumentComponent
    {
        int CustomerIdToGatherData { get; set;}
        public CustomerDocumentComponent(int customerIdToGatherData)
        {
            CustomerIdToGatherData = customerIdToGatherData;
        }

        public string GatherData()
        {
            string customerData;
            switch (CustomerIdToGatherData)
            {
                case 41:
                    customerData = "Vladyslav Rozanov";
                    break;
                default:
                    customerData = "Who else";
                    break;
            }
            return string.Format("<Customer>{0}</Customer>", customerData);
        }
        public void AddComponent(IDocumentComponent documentComponent)
        {
            Console.WriteLine("Cannot add to leaf...");
        }
    }
}
