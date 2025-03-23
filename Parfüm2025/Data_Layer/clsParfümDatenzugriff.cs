using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace Data_Layer
{
    public class clsParfümDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

       public static DataTable GetAllParfüms()
        {
            DataTable dt = new DataTable(); ;

            string abfrage = @"select distinct parfümNummer, Marke, Name,Kategorie, Duftrichtung, Jahreszeiten
                             from Parfüms   Order by parfümNummer Desc";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }
        public static DataTable GetAllParfuemByName(string filterdName)
        {
            DataTable dt = new DataTable(); ;

            string abfrage = @"select *
                             From Parfüms
                              Where Name Like @ParfuemFullTextCatalog OR Freetext(Name, @filterdName) ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@filterdName", filterdName);
                        command.Parameters.AddWithValue("@ParfuemFullTextCatalog", "%" + filterdName + "%");
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }
        public static DataTable GetAllParfuemByMarke(string filterdMarke)
        {
            DataTable dt = new DataTable(); ;

            string abfrage = @"select *
                             From Parfüms
                              Where Marke Like @ParfuemFullTextCatalog OR Freetext(Marke, @filterdMarke)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@filterdMarke", filterdMarke);
                        command.Parameters.AddWithValue("@ParfuemFullTextCatalog", "%" + filterdMarke + "%");

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }
        public static DataTable GetAllHerrenParfüms()
        {
            DataTable dt = new DataTable(); ;

            string abfrage = @"
                               select* from Parfüms where Kategorie Like 'Herrenduft%' 
                                order by parfümNummer Desc";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }

        public static DataTable GetAllDamenParfüms()
        {
            DataTable dt = new DataTable(); ;

            string abfrage = @"select * from Parfüms where Kategorie Like 'Damenduft%'
                                 Order by parfümNummer Desc";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }

        public static bool AddNewPerfum(int parfümNummer, string marke, string name,string kategorie,
              string duftrichtung, string jahreszeiten )
        {
            int rowAffected = 0;

            string abfrage = @"Insert into Parfüms (parfümNummer,Marke, Name, Kategorie, Duftrichtung, Jahreszeiten)
                                          Values(@parfümNummer, @marke, @name, @kategorie, @duftrichtung, @jahreszeiten)";
                              
                      
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@marke", marke);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@kategorie", kategorie);

                        if (string.IsNullOrEmpty(duftrichtung))
                            command.Parameters.AddWithValue("@duftrichtung", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@duftrichtung",duftrichtung);

                        if (string.IsNullOrEmpty(jahreszeiten))
                            command.Parameters.AddWithValue("@jahreszeiten", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@jahreszeiten", jahreszeiten);

                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            return (rowAffected > 0);
        }

        public static bool UpdatePerfum(int neuParfümNummer, int parfümNummer, string marke, string name, string kategorie,
              string duftrichtung, string jahreszeiten)
        {
            int rowAffected = 0;

            string abfrage = @"Update Parfüms 
                                        Set  parfümNummer = @neuParfümNummer,
                                             Marke        = @marke,
                                             Name         = @name,
                                             Kategorie    = @kategorie,
                                             Duftrichtung = @duftrichtung,
                                             Jahreszeiten = @jahreszeiten
                                       Where parfümNummer = @parfümNummer";


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        //die neue ParfümNummer.
                        command.Parameters.AddWithValue("@neuParfümNummer", neuParfümNummer);
                        command.Parameters.AddWithValue("@marke", marke);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@kategorie", kategorie);

                        if (string.IsNullOrEmpty(duftrichtung))
                            command.Parameters.AddWithValue("@duftrichtung", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@duftrichtung", duftrichtung);

                        if (string.IsNullOrEmpty(jahreszeiten))
                            command.Parameters.AddWithValue("@jahreszeiten", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@jahreszeiten", jahreszeiten);

                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return (rowAffected > 0);
        }
        public static bool Delete(int parfümNummer)
        {
            int rowAffected = 0;
            string abfrage = @"Delete From Parfüms Where parfümNummer = @parfümNummer";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        connection.Open();
                       
                        rowAffected = command.ExecuteNonQuery();    
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return (rowAffected > 0);
        }

        public static bool Find(int parfümNummer, ref string marke, ref string name,
              ref string kategorie, ref string duftrichtung, ref string jahreszeiten)
        {
            bool isfound = false;
            string abfrage = @"Select * From Parfüms Where parfümNummer = @parfümNummer";

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isfound = true;

                                marke = (string)reader["Marke"];
                                name = (string)reader["Name"];
                                kategorie = (string)reader["Kategorie"];
                                duftrichtung = (string)reader["Duftrichtung"].ToString();                           
                                jahreszeiten = (string)reader["Jahreszeiten"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return isfound;
        }

        public static bool _IstParfümNummerVergeben(int parfümNummer)
        {
            int rowAffected = 0;
            string abfrage = @"Select Find = 1 From Parfüms  Where parfümNummer = @parfümNummer";

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            rowAffected = (int)result;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return (rowAffected > 0);
        }
    }
  
}

