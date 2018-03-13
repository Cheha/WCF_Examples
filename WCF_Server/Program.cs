using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";

            Uri address = new Uri("http://localhost:8733/IContract"); // ADDRESS

            BasicHttpBinding binding = new BasicHttpBinding(); // BINDING

            Type contract = typeof(IContract); // CONTRACT

            ServiceHost host = new ServiceHost(typeof(Service));

            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Server is up and running. Waiting for messages");
            Console.ReadLine();
        }
    }
}
