using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hello_WCF
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}
