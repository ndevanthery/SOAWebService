using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPersonDB
    {
        Person AddPerson(Person newPerson);

        Person UpdatePersonQuota(int id,double quota);

        Person getPersonByUID(String UID);

        Person GetPersonByUsername(String username);
    }
}
