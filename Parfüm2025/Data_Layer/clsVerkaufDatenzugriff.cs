using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Data_Layer
{
    public class clsVerkaufDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetVerkaufDatenByID(int verkaufsID, ref int parfümNummer, ref int kundeID, ref float verkaufsMenge,
             ref float lagerbestand, ref float normalPreis, ref float gesamtPreis, ref DateTime erstellungsDatum)
        {

            bool isfound = false;
            string abfrage = @"SELECT * From  Verkauf Where verkaufsID= @verkaufsID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@verkaufsID", verkaufsID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                parfümNummer = (int)reader["parfümNummer"];
                                 kundeID = (int)reader["kundeID"];
                                verkaufsMenge = (float)reader["verkaufsMenge"];
                                lagerbestand = (float)reader["lagerbestand"];
                                normalPreis = (float)reader["normalPreis"];
                                gesamtPreis = (float)reader["gesamtPreis"];
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


        public static DataTable GetAllVerkaufsDaten()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select * From  Verkauf_View
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
        public static int AddNewVerakaufDaten(int parfümNummer, int kundeID, float verkaufsMenge,
             float lagerbestand, float normalerPreis, float gesamtPreis, DateTime erstellungsDatum)
        {
            int verkaufsID = -1;

            string abfrage = @"Insert into Verkauf (parfümNummer,kundeID,verkaufsMenge,lagerbestand, normalPreis, gesamtPreis, erstellungsDatum)
                                        Values  (@parfümNummer, @kundeID, @verkaufsMenge, @lagerbestand, @normalPreis, @gesamtPreis, @erstellungsDatum)
                                 Select Scope_Identity()";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@kundeID", kundeID);
                        command.Parameters.AddWithValue("@verkaufsMenge", verkaufsMenge);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);
                        command.Parameters.AddWithValue("@normalPreis", normalerPreis);
                        command.Parameters.AddWithValue("@gesamtPreis", gesamtPreis);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                            verkaufsID = InsertedID;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return verkaufsID;
        }

        public static bool UpdateVerkaufDaten(int verkaufsID, int parfümNummer, int kundeID, float verkaufsMenge,
             float lagerbestand, float normalerPreis, float gesamtPreis, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Verkauf  Set
                                                  parfümNummer = @parfümNummer,
                                                  kundeID  = @kundeID,
                                                  verkaufsMenge = @verkaufsMenge,
                                                  lagerbestand = @lagerbestand,
                                                  normalPreis  = @normalPreis,
                                                  gesamtPreis = @gesamtPreis,
                                                  erstellungsDatum = erstellungsDatum
                                          Where verkaufsID = @verkaufsID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@verkaufsID", verkaufsID);
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@kundeID", kundeID);
                        command.Parameters.AddWithValue("@verkaufsMenge", verkaufsMenge);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);
                        command.Parameters.AddWithValue("@normalPreis", normalerPreis);
                        command.Parameters.AddWithValue("@gesamtPreis", gesamtPreis);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

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

        public static bool UpdateVerkaufDatenByKundeID(int verkaufsID, int parfümNummer, int kundeID, float verkaufsMenge,
         float lagerbestand, float normalerPreis, float gesamtPreis, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Verkauf  Set
                                                  verkaufsID = @verkaufsID,
                                                  parfümNummer = @parfümNummer,
                                            
                                                  verkaufsMenge = @verkaufsMenge,
                                                  lagerbestand = @lagerbestand,
                                                  normalPreis  = @normalPreis,
                                                  gesamtPreis = @gesamtPreis,
                                                  erstellungsDatum = erstellungsDatum
                                      Where  kundeID  = @kundeID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@parfümNummer", parfümNummer);
                        command.Parameters.AddWithValue("@verkaufsID", verkaufsID);
                        command.Parameters.AddWithValue("@kundeID", kundeID);
                        command.Parameters.AddWithValue("@verkaufsMenge", verkaufsMenge);
                        command.Parameters.AddWithValue("@lagerbestand", lagerbestand);
                        command.Parameters.AddWithValue("@normalPreis", normalerPreis);
                        command.Parameters.AddWithValue("@gesamtPreis", gesamtPreis);
                        command.Parameters.AddWithValue("@erstellungsDatum", erstellungsDatum);

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

     
        public static bool DeleteVerkaufDaten(int verkaufsID)
        {
            int RowAffected = 0;

            string abfrage = @"Delete From Verkauf Where verkaufsID = @verkaufsID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@verkaufsID", verkaufsID);

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

    }
}

