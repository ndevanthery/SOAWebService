using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PersonManager : IPersonManager
    {
        private IPersonDB PersonDb { get; }

        public PersonManager(IPersonDB personDb)
        {
            PersonDb = personDb;
        }

        public Person AddPerson(Person newPerson)
        {
            return PersonDb.AddPerson(newPerson);
        }

        public Person getPersonByUID(string UID)
        {
            return PersonDb.getPersonByUID(UID);
        }

        public Person GetPersonByUsername(string username)
        {
            return PersonDb.GetPersonByUsername(username);
        }

        public Person UpdatePersonQuota(int id, double quota)
        {
            return PersonDb.UpdatePersonQuota(id, quota);
        }
    }
}
