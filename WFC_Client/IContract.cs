using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WFC_Client
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}
