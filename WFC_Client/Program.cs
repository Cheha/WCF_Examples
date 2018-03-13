using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";

            Uri address = new Uri("http://localhost:8733/IContract"); // ADDRESS

            BasicHttpBinding binding = new BasicHttpBinding(); // BINDING

            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<IContract> factory = new ChannelFactory<IContract>(binding, endpoint); // CONTRACT
            IContract channel = factory.CreateChannel();

            var message = Console.ReadLine();

            channel.Say(message);

            Console.WriteLine("Message sent");
            Console.ReadLine();
        }
    }


}
