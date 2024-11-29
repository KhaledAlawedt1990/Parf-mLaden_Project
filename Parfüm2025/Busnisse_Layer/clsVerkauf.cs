using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Busnisse_Layer
{
    public class clsVerkauf
    {
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;

        public enum enUpdate { UpdateDurchParfümNummer = 0, UpdateDurchParfümName }

        public int belegID { get; set; }
        public int parfümNummer { get; set; }
        public int kundeID { get; set; }
        public clsKunde kundeInfos
        {
            get { return clsKunde.FindKundeByID(this.kundeID); }
        }
        public float verkaufsMenge{ get; set; }
        public float lagerbestand { get; set; }
        public float normalPreis { get; set; }
        public float gesamtPreis { get; set; }
        public DateTime erstellungsDatum { get; set; }

        private clsVerkauf(int belegID, int parfümNummer, int kundeID, float verkaufsMenge,
            float lagerbestand, float normalPreis, float gesamtPreis, DateTime erstellungsDatum)
        {
            this.belegID = belegID;
            this.parfümNummer = parfümNummer;
            this.kundeID = kundeID;
            this.verkaufsMenge = verkaufsMenge;
            this.lagerbestand = lagerbestand;
            this.normalPreis = normalPreis;
            this.gesamtPreis = gesamtPreis;
            this.erstellungsDatum = erstellungsDatum;

            _mode = enMode.update;
        }

        public clsVerkauf()
        {
            this.belegID = -1;
            this.parfümNummer = -1;
            this.kundeID = -1;
            this.verkaufsMenge = 0;
            this.lagerbestand = 0;
            this.normalPreis = 0;
            this.gesamtPreis = 0;
            this.erstellungsDatum = DateTime.Now;
        }

        public static clsVerkauf Find(int belegID)
        {
            int parfümNummer = -1, kundeID = -1; float verkaufsMenge = 0, lagerbestand = 0;
            float normalPreis = 0, gesamtPreis = 0; DateTime erstellungsDatum = DateTime.Now;

            if (clsVerkaufDatenzugriff.GetVerkaufDatenByID(belegID, ref parfümNummer, ref kundeID, ref verkaufsMenge,
                                                  ref lagerbestand, ref normalPreis, ref gesamtPreis, ref erstellungsDatum))
                return new clsVerkauf(belegID, parfümNummer, kundeID, verkaufsMenge, lagerbestand, normalPreis, gesamtPreis, erstellungsDatum);
            else
                return null;
        }

        private bool _AddnewVerkaufDaten()
        {
            this.belegID = clsVerkaufDatenzugriff.AddNewVerakaufDaten(this.parfümNummer, this.kundeID, this.verkaufsMenge,
                                       this.lagerbestand, this.normalPreis, this.gesamtPreis, this.erstellungsDatum);

            return (this.belegID != -1);
        }

        private bool _UpdateVerkaufDaten()
        {
            return clsVerkaufDatenzugriff.UpdateVerkaufDaten(this.belegID, this.parfümNummer, this.kundeID, this.verkaufsMenge,
                                                        this.lagerbestand, this.normalPreis, this.gesamtPreis, this.erstellungsDatum);
        }

       public bool Save()
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_AddnewVerkaufDaten())
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;

                case enMode.update:
                    return _UpdateVerkaufDaten();
            }
            return false;
        }

        public bool Delete()
        {
            return clsVerkaufDatenzugriff.DeleteVerkaufDaten(this.belegID);
        }

        public static DataTable GetAllVerkaufDaten()
        {
            return clsVerkaufDatenzugriff.GetAllVerkaufsDaten();  
        }

        public static DataTable GetVerkaufsRecordProSeite(int zeileProSeite, int seiteNummer)
        {
            return clsVerkaufDatenzugriff.GetRecordAnzahlProSeite(zeileProSeite, seiteNummer);
        }
    }
}
