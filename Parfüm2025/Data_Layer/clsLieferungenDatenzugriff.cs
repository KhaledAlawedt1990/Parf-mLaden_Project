
using System;
using System.Data.SqlClient;
using System.Data;

using System.Configuration;

namespace ParfümDb_DataLayer
{
    public class clsLieferungenData
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetLieferungenInfoByID(int? LieferungID , ref int? ProduktID, ref string Kunde,
            ref bool? HauptGeschäft , ref bool? DezGeschäft, ref int? GelieferteMenge)
            {
                bool isFound = false;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Lieferungen WHERE LieferungID = @LieferungID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LieferungID", LieferungID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {

                                // The record was found
                                isFound = true;

                                ProduktID = reader["ProduktID"] != DBNull.Value ? (int?)reader["ProduktID"] : null;
                              Kunde  = reader["KundeName"] != DBNull.Value ? reader["KundeName"].ToString() : null;
                             HauptGeschäft = reader["HauptGeschäft"] != DBNull.Value ? (bool?)reader["HauptGeschäft"] : null;
                             DezGeschäft = reader["DezGeschäft"] != DBNull.Value ? (bool?)reader["DezGeschäft"] : null;
                            GelieferteMenge = reader["GelieferteMenge"] != DBNull.Value ? (int?)reader["GelieferteMenge"] : null;

                                



                            }
                        }

                    }
                }
                return isFound;

            }

        public static DataTable GetAllLieferungen()
{
    DataTable dt = new DataTable();

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = @"Select L.LieferungID, P.ProduktName, L.KundeName, L.HauptGeschäft, L.DezGeschäft,
                     L.GelieferteMenge, P.Total, L.Lieferdatum
                     From Lieferungen as L 
                     Inner Join Produkte as P
                     On L.ProduktID = P.ProduktID
                     Order by L.LieferungID Desc";

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

         public static int? AddNewLieferungen(int? ProduktID, string KundeName, bool? HauptGeschäft, bool? DezGeschäft, int? GelieferteMenge)
        {
            int? LieferungID = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Insert Into Lieferungen ([ProduktID],[KundeName],[HauptGeschäft],[DezGeschäft],[GelieferteMenge],[Lieferdatum])
                            Values (@ProduktID,@KundeName, @HauptGeschäft,@DezGeschäft ,@GelieferteMenge,@Lieferdatum)
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProduktID", ProduktID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@KundeName", KundeName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@HauptGeschäft", HauptGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DezGeschäft", DezGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GelieferteMenge", GelieferteMenge ?? (object)DBNull.Value);
                   
                    command.Parameters.AddWithValue("@Lieferdatum", DateTime.Now.Date);


                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LieferungID = insertedID;
                    }
                }

            }
            return LieferungID;

        }


         public static bool UpdateLieferungenByID(int? LieferungID, int? ProduktID, string KundeName,
              bool? HauptGeschäft, bool? DezGeschäft , int? GelieferteMenge)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"Update Lieferungen
                                    set 
                                         [ProduktID] = @ProduktID,
                                         [KundeName] = @KundeName,
                                         [HauptGeschäft]  = @HauptGeschäft,
                                          [ezGeschäft] =@DezGeschäft ,
                                         [GelieferteMenge] = @GelieferteMenge,
                                       
                                         [Lieferdatum] = @Lieferdatum
                                  where [LieferungID]= @LieferungID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LieferungID", LieferungID);
                    command.Parameters.AddWithValue("@ProduktID", ProduktID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@KundeName", KundeName ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@HauptGeschäft", HauptGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DezGeschäft", DezGeschäft ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GelieferteMenge", GelieferteMenge ?? (object)DBNull.Value);
              
                    command.Parameters.AddWithValue("@Lieferdatum", DateTime.Now.Date);


                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }

            }

            return (rowsAffected > 0);
        }


        public static bool DeleteLieferungen(int LieferungID)
{
    int rowsAffected = 0;

    using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        string query = @"Delete Lieferungen 
                        where LieferungID = @LieferungID";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@LieferungID", LieferungID);


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
        string query = $@"select * from Lieferungen
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
