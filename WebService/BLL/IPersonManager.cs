using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public interface IPersonManager
    {
        public Person AddPerson(Person newPerson);

        public Person UpdatePersonQuota(int id, float quota);

        public Person getPersonByUID(String UID);

        public Person GetPersonByUsername(String username);
    }
}
