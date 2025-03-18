using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Busnisse_Layer
{ 
    public class clsRechnungsdetails
    {
        // VerkaufsdatenRepository.cs

        private static readonly string _connectionString = clsRechnungsdetailsDatenzugriff.connectionString;
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;

        public int detailID { get; set; }
        public int belegID { get; set; }
        public int parfümNummer { get; set; }    
        public float verkaufsMenge{ get; set; }
        public float lagerBestandHaupt { get; set; }
        public float normalPreis { get; set; }
        public float gesamtPreis { get; set; }
        public bool lagerbestandAktualisiert { get; set; }
        public clsEinkauf einkaufInofs { get; set; }
        private clsRechnungsdetails(int detailID, int belegID, int parfümNummer, float verkaufsMenge,
            float lagerbestandHaupt, float normalPreis, float gesamtPreis, bool lagerbestandAktualisiert)
        {
            this.detailID = detailID;
            this.belegID = belegID;
            this.parfümNummer = parfümNummer;
            this.einkaufInofs = clsEinkauf.FindEinkaufDatenByParfümNummer(parfümNummer);
            if (this.einkaufInofs != null)
            {
                string sekundärBatchNummer = this.einkaufInofs.sekundäreBatchNummer;
            }
            else
            {
                // Fehlerbehandlung oder Standardwert setzen
                string sekundärBatchNummer = "Nicht vorhanden";
            }
            this.verkaufsMenge = verkaufsMenge;
            this.lagerBestandHaupt = lagerbestandHaupt;
            this.normalPreis = normalPreis;
            this.gesamtPreis = gesamtPreis;
            this.lagerbestandAktualisiert = lagerbestandAktualisiert;

            _mode = enMode.update;
        }

        public clsRechnungsdetails()
        {
            this.detailID = -1;
            this.belegID = -1;
            this.parfümNummer = -1;
            this.verkaufsMenge = 0;
            this.lagerBestandHaupt = 0;
            this.normalPreis = 0;
            this.gesamtPreis = 0;
            this.lagerbestandAktualisiert = false;

            _mode = enMode.addnew;
        }
        public static List<clsRechnungsdetails> LadeRechnungsDetails(int belegID)
        {
            string query = @"SELECT detailID, belegID, parfümNummer, 
                                                 verkaufsMenge,
                                                 lagerBestandHaupt,
                                                 normalPreis,
                                                 gesamtPreis,
                                                 lagerbestandAktualisiert
                                         FROM RechnungsDetails WHERE belegID = @belegID";

            var detailsListe = new List<clsRechnungsdetails>();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@belegID", belegID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detailsListe.Add(new clsRechnungsdetails
                            {
                                detailID = (int)reader["detailID"],
                                belegID = (int)reader["belegID"],
                                parfümNummer = (int)reader["parfümNummer"],
                                verkaufsMenge = (float)reader["verkaufsMenge"],
                                lagerBestandHaupt = (float)reader["lagerBestandHaupt"],
                                normalPreis = (float)reader["normalPreis"],
                                gesamtPreis = (float)reader["gesamtPreis"],
                                lagerbestandAktualisiert = (bool)reader["lagerbestandAktualisiert"]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Laden der Rechnungsdetials " + ex.Message);
            }
            return detailsListe;
        }
        public static clsRechnungsdetails Find(int detailID)
        {
            int belegID = -1;  int parfümNummer = -1; float verkaufsMenge = 0, lagerbestandHaupt = 0;
            float normalPreis = 0, gesamtPreis = 0; bool lagerbestandAktualisiert = false;

            if (clsRechnungsdetailsDatenzugriff.GetRechnungsDetailsByID(detailID, ref belegID, ref parfümNummer, ref verkaufsMenge,
                                                  ref lagerbestandHaupt, ref normalPreis, ref gesamtPreis, ref lagerbestandAktualisiert))
                return new clsRechnungsdetails(detailID, belegID, parfümNummer, verkaufsMenge, lagerbestandHaupt, normalPreis, gesamtPreis, lagerbestandAktualisiert);
            else
                return null;
        }

        private bool _AddNewRechnungsdetails()
        {
            this.detailID = clsRechnungsdetailsDatenzugriff.AddNewRechnungsDetailsDaten(this.belegID,this.parfümNummer, this.verkaufsMenge,
                                       this.lagerBestandHaupt, this.normalPreis, this.gesamtPreis, this.lagerbestandAktualisiert);

            return (this.detailID != -1);
        }

        private bool _UpdateRechnungsdetails()
        {
            return clsRechnungsdetailsDatenzugriff.UpdateRechnungsDetails(this.detailID,this.belegID, this.parfümNummer, this.verkaufsMenge,
                                                        this.lagerBestandHaupt, this.normalPreis, this.gesamtPreis, this.lagerbestandAktualisiert);
        }

       public bool Save()
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_AddNewRechnungsdetails())
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;

                case enMode.update:
                    return _UpdateRechnungsdetails();
            }
            return false;
        }

        public bool Delete()
        {
            return clsRechnungsdetailsDatenzugriff.DeleteRechnungsDetails(this.detailID);
        } 
        public static DataTable GetRechnungsdetailsZeilenProSeite(int zeileProSeite, int seiteNummer)
        {
            return clsRechnungsdetailsDatenzugriff.GetRecordAnzahlProSeite(zeileProSeite, seiteNummer);
        }
        
        public static bool SetzeLagerbestandAktualisiert(int detailID, float lagerBestandHaupt, bool lagerbestandAktualisiert)
        {
            return clsRechnungsdetailsDatenzugriff.SetzeLagerbestandAktualisiert(detailID, lagerBestandHaupt, lagerbestandAktualisiert);
        }
    }
}
