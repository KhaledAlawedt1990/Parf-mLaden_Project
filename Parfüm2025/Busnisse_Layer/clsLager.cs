using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Busnisse_Layer
{
    public class clsLager
    {
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;

        public enum enUpdate { UpdateDurchParfümNummer = 0, UpdateDurchParfümName}
        private enUpdate _update = enUpdate.UpdateDurchParfümNummer;
        public int parfümNummer { get; set; }
        public string parfümName { get; set; }
        public string batchNummer { get; set; }
        public string parfümCode { get; set; }
        public float lagerbestand { get; set; }
        public DateTime erstellungsDatum { get; set; }

        private clsLager(int parfümNummer, string parfümName, string batchNummer, string parfümCode,
            float lagerbestand, DateTime erstellungsDatum)
        {
            this.parfümNummer = parfümNummer;
            this.parfümName = parfümName;
            this.batchNummer = batchNummer;
            this.parfümCode = parfümCode;
            this.lagerbestand = lagerbestand;
            this.erstellungsDatum = erstellungsDatum;

            _mode = enMode.update;
        }

        public clsLager()
        {
            this.parfümNummer = -1;
            this.parfümName = string.Empty;
            this.batchNummer = string.Empty;
            this.parfümCode = string.Empty;
            this.lagerbestand = 0;
            this.erstellungsDatum = DateTime.Now;

            _mode = enMode.addnew;
        }

        public static clsLager FindLagerDatenByParfümNummer(int parfümNummer)
        {
            string parfümName = string.Empty; string batchNummer = string.Empty;
            string parfümCode = string.Empty; float lagerbestand = 0; DateTime erstellungsDatum = DateTime.Now;

            if (clsLageDatenzugriff.GetLagerDatenByParfümID(parfümNummer, ref parfümName, ref batchNummer,
                                                         ref parfümCode, ref lagerbestand, ref erstellungsDatum))
            {
                return new clsLager(parfümNummer, parfümName, batchNummer, parfümCode, lagerbestand, erstellungsDatum);
            }
            else
                return null;
        }

        public static clsLager FindLagerDatenByParfümName(string parfümName)
        {
            int parfümNummer = -1; string batchNummer = string.Empty;
            string parfümCode = string.Empty; float lagerbestand = 0; DateTime erstellungsDatum = DateTime.Now;

            if (clsLageDatenzugriff.GetLagerDatenByParfümName(ref parfümNummer, parfümName, ref batchNummer,
                                                         ref parfümCode, ref lagerbestand, ref erstellungsDatum))
            {
                return new clsLager(parfümNummer, parfümName, batchNummer, parfümCode, lagerbestand, erstellungsDatum);
            }
            else
                return null;
        }

        private bool _AddNewParfümMitMenge()
        {
            return clsLageDatenzugriff.AddNewParfümMitMenge(this.parfümNummer, this.parfümName, this.batchNummer,
                                                                         this.parfümCode, this.lagerbestand, this.erstellungsDatum);
        }

        public bool _UpdateByParfümName()
        {
            return clsLageDatenzugriff.UpdateMengeByParfümName(this.parfümName, this.batchNummer, this.parfümCode,
                                                                   this.lagerbestand, erstellungsDatum);
        }

        public bool _UpdateByParfümNummer()
        {
            return clsLageDatenzugriff.UpdateMengeByParfümNummer(this.parfümNummer, this.batchNummer, this.parfümCode,
                                                                   this.lagerbestand, erstellungsDatum);
        }

        public bool Save()
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_AddNewParfümMitMenge())
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;


                case enMode.update:
                    {
                        switch(_update)
                        {
                            case enUpdate.UpdateDurchParfümNummer:
                                return _UpdateByParfümNummer();

                            case enUpdate.UpdateDurchParfümName:
                                return _UpdateByParfümName();
                        }
                        break;
                    }
            }
            return false;
        }

        public static bool istParfümNummerVerfügbar(int parfümNummer)
        {
            return clsLageDatenzugriff.IstParfümNummerVerfügbar(parfümNummer);
        }

        public bool Delete()
        {
            return clsLageDatenzugriff.DeleteParfüm(this.parfümNummer);
        }

        public static DataTable GetAllLagerDaten()
        {
            return clsLageDatenzugriff.GetAllLagerDaten();
        }
    }
}
