using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsProductSchlüsselDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool AddnewSchluessl(string Key)
        {
            int ProduktID = -1;

            string verschüsseltesKey = clsVerschlüsselungHelfer.Encrypt(Key);

            // SQL-Abfrage zum Einfügen des verschlüsselten Schlüssels
            string query = @"INSERT INTO Produktschluessel (Schluessel, erstellungsdatum, ablaufdatum, verwendet)
                                      VALUES (@Schluessel, @erstellungsdatum, @ablaufdatum, @verwendet)
                                Select Scope_Identity() ";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Schluessel", verschüsseltesKey);
                    command.Parameters.AddWithValue("@erstellungsdatum", DateTime.Now);
                    command.Parameters.AddWithValue("@ablaufdatum", DateTime.Now.AddMonths(1));
                    command.Parameters.AddWithValue("@verwendet", true);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                        ProduktID = ID;

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (ProduktID != -1);
        }

        public static DataTable GetDatumUndStatusByProduktSchluessel(string ProduktSchluessel)
        {
            DataTable dt = new DataTable();

            string VerschlüsselProduktSchluessel = clsVerschlüsselungHelfer.Encrypt(ProduktSchluessel);
            string abfrage = @"Select * From ProduktSchluessel Where Schluessel = @Schluessel";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@Schluessel", VerschlüsselProduktSchluessel);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
    }
}
