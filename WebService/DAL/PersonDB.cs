using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class PersonDB : IPersonDB
    {
        //---------------------------------------------------
        // CONFIGURATION
        //---------------------------------------------------

        private string connectionString = null;
        public PersonDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
        }





        public Person AddPerson(Person newPerson)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "Insert into Person(UID,username,quota) values(@UID,@username,@quota); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", newPerson.UID);
                    cmd.Parameters.AddWithValue("@username", newPerson.username);
                    cmd.Parameters.AddWithValue("@quota", newPerson.quota);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Person();

                            result.id = (int)dr["id"];
                            result.UID = (string)dr["UID"];
                            result.username = (string)dr["username"];
                            result.quota = (float)dr["quota"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public Person DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person getPersonByUID(string UID)
        {
            throw new NotImplementedException();
        }

        public Person GetPersonByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Person UpdatePerson(Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
