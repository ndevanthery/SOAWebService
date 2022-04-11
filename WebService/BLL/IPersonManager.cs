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
        Person AddPerson(Person newPerson);

        Person UpdatePersonQuota(int id, double quota);

        Person getPersonByUID(String UID);

        Person GetPersonByUsername(String username);
    }
}
