﻿using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Busnisse_Layer
{
    public class clsEinkauf
    {
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;

        public enum enUpdate { UpdateDurchParfümNummer = 0, UpdateDurchParfümName}

        public int parfümNummer { get; set; }
        public string parfümName { get; set; }
        public string hauptBatchNummer { get; set; }
        public string sekundäreBatchNummer { get; set; }
        public string parfümCode { get; set; }
        public float? lagerBestandHaupt { get; set; }
        public float? lagerBestandSekundär { get; set; } //für sekundäreBatchNummer falls vorhanden.
        public int preisKategorie { get; set; }
        public DateTime erstellungsDatum { get; set; }

        private clsEinkauf(int parfümNummer, string parfümName, string parfümCode, string hauptBatchNummer, float? lagerBestandHaupt,
            string sekundäreBatchNummer,float? lagerBestandSekundär, int preisKategorie, DateTime erstellungsDatum)
        {
            this.parfümNummer = parfümNummer;
            this.parfümName = parfümName;
            this.hauptBatchNummer = hauptBatchNummer;
            this.sekundäreBatchNummer = sekundäreBatchNummer;
            this.parfümCode = parfümCode;
            this.lagerBestandHaupt = lagerBestandHaupt;
            this.lagerBestandSekundär = lagerBestandSekundär; //lagerBestandHaupt für sekundäreBatchNummer falls vorhanden.
            this.preisKategorie = preisKategorie;
            this.erstellungsDatum = erstellungsDatum;

            _mode = enMode.update;
        }

        public clsEinkauf()
        {
            this.parfümNummer = -1;
            this.parfümName = string.Empty;
            this.parfümCode = null;
            this.hauptBatchNummer = null;
            this.sekundäreBatchNummer = null;
            this.lagerBestandHaupt = null;
            this.lagerBestandSekundär = null;
            this.preisKategorie = 1;
            this.erstellungsDatum = DateTime.Now;

            _mode = enMode.addnew;
        }

        public static clsEinkauf FindEinkaufDatenByParfümNummer(int parfümNummer)
        {
            string parfümName = string.Empty; string hauptBatchNummer = null; string sekundäreBatchNummer = null;
            string parfümCode = string.Empty; float? lagerBestandHaupt = null; float? lagerBestandSekundär = null;
            int preisKategorie = 1;  DateTime erstellungsDatum = DateTime.Now;

            if (clsEinkaufDatenzugriff.GetEinkaufDatenByParfümID(parfümNummer, ref parfümName, ref parfümCode,ref hauptBatchNummer,
                                   ref lagerBestandHaupt, ref sekundäreBatchNummer, ref lagerBestandSekundär, ref preisKategorie, ref erstellungsDatum))
            {
                return new clsEinkauf(parfümNummer, parfümName, parfümCode, hauptBatchNummer, lagerBestandHaupt,
                                                              sekundäreBatchNummer, lagerBestandSekundär, preisKategorie, erstellungsDatum);
            }
            else
                return null;
        }
        private bool _AddNewEinkaufDaten()
        {
            return clsEinkaufDatenzugriff.AddNewEinkaufDaten(this.parfümNummer, this.parfümName, this.parfümCode, this.hauptBatchNummer, this.lagerBestandHaupt
                ,this.sekundäreBatchNummer, this.lagerBestandSekundär,this.preisKategorie, this.erstellungsDatum);
        }

        //public bool _UpdateByParfümName()
        //{
        //    return clsEinkaufDatenzugriff.UpdateMengeByParfümName(this.parfümName, this.hauptBatchNummer, this.parfümCode,
        //                                                           this.lagerBestandHaupt, erstellungsDatum);
        //}

        public bool _UpdateByParfümNummer()
        {
            return clsEinkaufDatenzugriff.UpdateEinkaufDaten(this.parfümNummer, this.parfümName, this.parfümCode, this.hauptBatchNummer, this.lagerBestandHaupt
                , this.sekundäreBatchNummer, this.lagerBestandSekundär, this.preisKategorie, this.erstellungsDatum);
        }

        public static bool UpdateLagerBestandHaupt(int parfümNummer, float? lagerBestandHaup)
        {
            return clsEinkaufDatenzugriff.UpdateLagerBestandHaupt(parfümNummer, lagerBestandHaup);
        }
        public static bool UpdateLagerBestandSekundär(int parfümNummer, string sekundärBatchNummer, float? lagerBestandSekundär)
        {
            return clsEinkaufDatenzugriff.UpdateLagerbestandSekundäre(parfümNummer,sekundärBatchNummer, lagerBestandSekundär);
        }
        public bool Save()
        {
            switch(_mode)
            {
                case enMode.addnew:
                    if (_AddNewEinkaufDaten())
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;


                case enMode.update:
                    {
                        return _UpdateByParfümNummer();
                    }
            }
            return false;
        }

        public static bool istParfümNummerVerfügbar(int parfümNummer)
        {
            return clsEinkaufDatenzugriff.IstParfümNummerVerfügbar(parfümNummer);
        }

        public bool Delete()
        {
            return clsEinkaufDatenzugriff.DeleteEinkaufDaten(this.parfümNummer);
        }

  
        public static DataTable GetAllEinkaufDaten()
        {
            return clsEinkaufDatenzugriff.GetAllEinkaufDaten();
        }

    }
}
