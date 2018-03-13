using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serice = new ServiceReference.Service1Client();
            var factory = serice.ChannelFactory;
            var channel = factory.CreateChannel();

            var result = channel.GetData(5);
            Console.WriteLine($"Return message: {result}");
            Console.ReadLine();
        }
    }
}
