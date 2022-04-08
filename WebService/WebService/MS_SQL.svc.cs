using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MS_SQL" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MS_SQL.svc or MS_SQL.svc.cs at the Solution Explorer and start debugging.
    public class MS_SQL : IMS_SQL
    {
        public float AddAmount(string UID, float quotas)
        {
            Console.WriteLine(UID + quotas);
            return quotas;
        }

        public float transferMoney(string username, float quotas)
        {
            Console.WriteLine(username + quotas);
            return quotas;
        }
    }
}
