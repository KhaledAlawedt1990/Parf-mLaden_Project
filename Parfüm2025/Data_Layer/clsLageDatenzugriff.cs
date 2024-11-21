using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsLageDatenzugriff
    {

        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetLagerDatenByParfümID(int parfümNummer, ref string parfümName, ref string batchNummer,
                    ref string parfümCode, ref float lagerbestand, ref DateTime erstellungsDatum)
        {

            bool isfound = false;
            string abfrage = @"SELECT * From  Lager Where parfümNummer= @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                parfümName = (string)reader["parfümName"];
                                batchNummer = (string)reader["batchNummer"];
                                parfümCode = (string)reader["parfümCode"];
                                lagerbestand = (float)reader["lagerbestand"];
                                erstellungsDatum = (DateTime)reader["erstellungsDatum"];
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }

        public static bool GetLagerDatenByParfümName(ref int parfümNummer, string parfümName, ref string batchNummer,
                    ref string parfümCode, ref float lagerbestand, ref DateTime erstellungsDatum)
        {

            bool isfound = false;

            string abfrage = @"SELECT * From Lager Where parfümName = @parfümName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümName",parfümName);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                parfümNummer = (int)reader["parfümNummer"];
                                batchNummer = (string)reader["batchNummer"];
                                parfümCode = (string)reader["parfümCode"];
                                lagerbestand = (float)reader["lagerbestand"];
                                erstellungsDatum = (DateTime)reader["erstellungsDatum"];

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }



        public static DataTable GetAllLagerDaten()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select * From  Lager
                                                  Order by erstellungsDatum Desc";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            }
            catch (SqlException ex)
            {
                throw;
            }
            return dt;
        }


        //public static DataTable GetAllKunde_View()
        //{
        //    DataTable dt = new DataTable();

        //    string abfrage = @"select Kunde.kundeID, Kunde.personID,
        //                                (Person.Vorname + ' ' + Person.Nachname) as Vollname , 
        //                                Person.Geburtstag, Person.Geschlecht, Kunde.firmaName, Person.Email, Kunde.regestriertAm, Kunde.istAktive
        //                               from Person INNER JOIN Kunde ON
        //                               Person.PersonID = Kunde.personID ";
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ConnectionString))
        //        {
        //            using (SqlCommand command = new SqlCommand(abfrage, connection))
        //            {

        //                connection.Open();
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    if (reader.HasRows)
        //                        dt.Load(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw;
        //    }
        //    return dt;
        //}


        public static bool AddNewParfümMitMenge(int parfümNummer,string parfümName, string batchNummer,
                    string parfümCode,float lagerbestand, DateTime erstellungsDatum)
        {
            int rowAffected = 0;

            string abfrage = @"Insert into Lager(parfümNummer,parfümName,batchNummer,parfümCode,lagerbestand,erstellungsDatum)
                                        Values  (@parfümNummer, @parfümName, @batchNummer, @parfümCode, @lagerbestand, @erstellungsDatum)";
       
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@parfümName", parfümName);
                        command.Parameters.AddWithValue("@batchNummer", batchNummer);
                        command.Parameters.AddWithValue("@parfümCode", parfümCode);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return (rowAffected > 0);
        }

        public static bool UpdateMengeByParfümNummer(int parfümNummer, string batchNummer,
                    string parfümCode, float lagerbestand, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Lager  Set
                                                  batchNummer = @batchNummer,
                                                  parfümCode  = @parfümCode,
                                                  lagerbestand = @lagerbestand,
                                                  erstellungsDatum = GetDate()
                                            Where parfümNummer = parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@batchNummer", batchNummer);
                        command.Parameters.AddWithValue("@parfümCode", parfümCode);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);

                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool UpdateMengeByParfümName(string parfümName, string batchNummer,
                 string parfümCode, float lagerbestand, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Lager  Set
                                                  batchNummer = @batchNummer,
                                                  parfümCode  = @parfümCode,
                                                  lagerbestand = @lagerbestand,
                                                  erstellungsDatum = GetDate()
                                            Where parfümName = parfümName";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümName", parfümName);
                        command.Parameters.AddWithValue("@batchNummer", batchNummer);
                        command.Parameters.AddWithValue("@parfümCode", parfümCode);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);

                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }
        public static bool DeleteParfüm(int parfümNummer)
        {
            int RowAffected = 0;

            string abfrage = @"Delete From Lager Where ParfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();
                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool IstParfümNummerVerfügbar(int parfümNummer)
        {
            bool istVerfügbar = false;

            string abfrage = @"Select 1 From Lager where parfümNummer = @parfümNummer";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();

                        object result = command.ExecuteScalar();
                        istVerfügbar = (result != null && (int)result == 1);
                    }
                }
            }
            catch (SqlException ex)
            {
                istVerfügbar = false;
                throw;
            }
            return istVerfügbar;
        }
    }
}
