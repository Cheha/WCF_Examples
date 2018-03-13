using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hello_WCF
{
    class Server
    {
        static void Main()
        {
            Console.Title = "SERVER";

            Uri address = new Uri("localhost:8733/IContract"); // ADDRESS

            BasicHttpBinding binding = new BasicHttpBinding(); // BINDING

            Type contract = typeof(IContract);

            ServiceHost host = new ServiceHost(typeof(Service));

            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Server is up and running. Waiting for messages");
            Console.ReadLine();
        }
    }
}
