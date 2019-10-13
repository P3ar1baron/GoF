using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new DocumentComponent("ComposableDocument");
            //var headerDocumentSection = new HeaderDocumentComponent();
            var body = new DocumentComponent("Body");
            //document.AddComponent(headerDocumentSection);
            document.AddComponent(body);

            var customerDocumentSection = new CustomerDocumentComponent(41);
            var orders = new DocumentComponent("Orders");
            //var orders0 = new OrderDocumentComponent(0);
            //orders.AddComponent(order0);
            body.AddComponent(customerDocumentSection);
            body.AddComponent(orders);
            string gatheredData = document.GatherData();
            Console.WriteLine(gatheredData);

        }
    }
}
