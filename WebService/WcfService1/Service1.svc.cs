﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO;
using BLL;
using DAL;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Person AddAmount(string UID, double quotas)
        {
            Person p_m = null;

            try
            {
                IPersonDB personDB = new PersonDB();
                PersonManager manager = new PersonManager(personDB);
                Person p = manager.getPersonByUID(UID);
                if(p!=null)
                {
                    manager.UpdatePersonQuota(p.id, quotas + p.quota);
                    p_m = manager.getPersonByUID(UID);
                }
                
            }
            catch
            {
                Console.WriteLine("error occured");
            }
    
            return p_m;
            
        }

        public Person transferMoney(string username, double quotas)
        {
            Person p_m = null;

            try
            {
                IPersonDB personDB = new PersonDB();
                PersonManager manager = new PersonManager(personDB);
                Person p = manager.GetPersonByUsername(username);
                manager.UpdatePersonQuota(p.id, quotas + p.quota);
                p_m = manager.GetPersonByUsername(username);
            }
            catch
            {
                Console.WriteLine("error occured");
            }
            



            return p_m;

        }
    }
}
