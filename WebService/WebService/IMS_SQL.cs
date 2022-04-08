using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMS_SQL" in both code and config file together.
    [ServiceContract]
    public interface IMS_SQL
    {
        [OperationContract]
        float AddAmount(string UID , float quotas);

        [OperationContract]
        float transferMoney(String username, float quotas);
       
        
    }
}
