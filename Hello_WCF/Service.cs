using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Hello_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IContract
    {
        public void Say(string input)
        {
            Console.WriteLine($"Message accepted. Message: '{input}'");
        }
    }
}
