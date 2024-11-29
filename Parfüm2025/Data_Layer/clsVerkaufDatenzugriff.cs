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

        public static bool GetVerkaufDatenByID(int belegID, ref int parfümNummer, ref int kundeID, ref float verkaufsMenge,
             ref float lagerbestand, ref float normalPreis, ref float gesamtPreis, ref DateTime erstellungsDatum)
        {

            bool isfound = false;
            string abfrage = @"SELECT * From  Verkauf Where belegID= @belegID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@belegID", belegID);

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

        public static DataTable GetRecordAnzahlProSeite(int ZeileProseite, int SeiteNummer)
        {
            DataTable dt = new DataTable();
           using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand("Sp_GetVerkaufRecordsProSeite", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ZeileProSeite", ZeileProseite);
                        command.Parameters.AddWithValue("@SeiteNummer", SeiteNummer);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
                catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return dt;
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
            int belegID = -1;

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
                            belegID = InsertedID;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return belegID;
        }

        public static bool UpdateVerkaufDaten(int belegID, int parfümNummer, int kundeID, float verkaufsMenge,
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
                                          Where belegID = @belegID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@belegID", belegID);
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

        public static bool UpdateVerkaufDatenByKundeID(int belegID, int parfümNummer, int kundeID, float verkaufsMenge,
         float lagerbestand, float normalerPreis, float gesamtPreis, DateTime erstellungsDatum)
        {
            int RowAffected = 0;
            string abfrage = @"Update Verkauf  Set
                                                  belegID = @belegID,
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
                        command.Parameters.AddWithValue("@belegID", belegID);
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

     
        public static bool DeleteVerkaufDaten(int belegID)
        {
            int RowAffected = 0;

            string abfrage = @"Delete From Verkauf Where belegID = @belegID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@belegID", belegID);

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

