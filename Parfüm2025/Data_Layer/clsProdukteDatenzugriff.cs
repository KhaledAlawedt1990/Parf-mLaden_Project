
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ParfümDb_DataLayer
{
    public class clsProdukteData
    {

        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static bool GetProdukteInfoByID(int? ProduktID , ref string ProduktName, ref int? GekaufteMenge,ref int? Total)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Produkte WHERE ProduktID = @ProduktID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProduktID", ProduktID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                ProduktName = reader["ProduktName"] != DBNull.Value ? reader["ProduktName"].ToString() : null;
                                GekaufteMenge = reader["GekaufteMenge"] != DBNull.Value ? (int?)reader["GekaufteMenge"] : null;
                            Total = reader["Total"] != DBNull.Value ? (int?)reader["Total"] : null;


                        }
                        }

                    }
                }
                return isFound;

            }
        public static bool GetProdukteInfoByName(ref int? ProduktID, string ProduktName, ref int? GekaufteMenge, ref int? Total)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Produkte WHERE ProduktName = @ProduktName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProduktName", ProduktName);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            // The record was found
                            isFound = true;

                            ProduktID = (int)reader["ProduktID"];
                            GekaufteMenge = reader["GekaufteMenge"] != DBNull.Value ? (int?)reader["GekaufteMenge"] : null;
                            Total = reader["Total"] != DBNull.Value ? (int?)reader["Total"] : null;


                        }
                    }

                }
            }
            return isFound;

        }

        public static DataTable GetAllProdukte()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = "SELECT * FROM Produkte";

        using (SqlCommand command = new SqlCommand(query, connection))
        {

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    dt.Load(reader);
            }
        }
    }
    return dt;

}

         public static int? AddNewProdukte(string ProduktName, int? GekaufteMenge, int? Total)
        {
            int? ProduktID = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Insert Into Produkte ([ProduktName],[GekaufteMenge], [Total])
                            Values (@ProduktName,@GekaufteMenge, @Total)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProduktName", ProduktName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GekaufteMenge", GekaufteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Total", Total ??(object)DBNull.Value);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        ProduktID = insertedID;
                    }
                }

            }
            return ProduktID;

        }


         public static bool UpdateProdukteByID(int? ProduktID, string ProduktName, int? GekaufteMenge, int? Total)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Update Produkte
                                    set 
                                         [ProduktName] = @ProduktName,
                                         [GekaufteMenge] = @GekaufteMenge,
                                         [Total] = @Total
                                  where [ProduktID]= @ProduktID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProduktID", ProduktID);
                    command.Parameters.AddWithValue("@ProduktName", ProduktName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GekaufteMenge", GekaufteMenge ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Total", Total ?? (object)DBNull.Value);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeleteProdukte(int ProduktID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = @"Delete Produkte 
                        where ProduktID = @ProduktID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ProduktID", ProduktID);


            connection.Open();
            
            rowsAffected = command.ExecuteNonQuery();


        }

    }
    
    return (rowsAffected > 0);

}
        
        public static DataTable SearchData(string ColumnName, string Data)
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = $@"select * from Produkte
                    where {ColumnName} Like '' + @Data + '%';";

        using (SqlCommand Command = new SqlCommand(query, connection))
        {
            Command.Parameters.AddWithValue("@Data", Data);


            connection.Open();

            using (SqlDataReader reader = Command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
        }
        
    }

    return dt;
}
    }
}
