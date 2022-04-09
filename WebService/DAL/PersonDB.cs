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
    public class PersonDB : IPersonDB
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

        
        public Person getPersonByUID(string UID)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person WHERE UID = @UID;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UID", UID);
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

        public Person GetPersonByUsername(string username)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Person WHERE username = @username;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
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

        public Person UpdatePersonQuota(int id, float quota)
        {
            Person result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Person SET Quota = @quota WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quota", quota);
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
    }
}
