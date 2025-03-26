
using System;
using System.Data;
using System.Runtime.CompilerServices;
using ParfümDb_DataLayer;

namespace ParfümDb_BusinessLayer
{
    public class clsProdukte
    {
     

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

              public int? ProduktID { get; set; }
        public string ProduktName { get; set; }
        public int? GekaufteMenge { get; set; }
        public int? Total { get; set; }

        public clsProdukte()
        {
            this.ProduktID = null;
            this.ProduktID = null;
            this.ProduktName = null;
            this.GekaufteMenge = null;
            this.Total = 0;
            Mode = enMode.AddNew;
        }


        private clsProdukte(
int? ProduktID,string ProduktName, int? GekaufteMenge, int? Total       )
        {
            this.ProduktID = ProduktID;
            this.ProduktName = ProduktName;
            this.GekaufteMenge = GekaufteMenge;
            this.Total = Total;
            Mode = enMode.Update;
        }


       private bool _AddNewProdukte()
       {
        this.ProduktID = clsProdukteData.AddNewProdukte(
this.ProduktName, this.GekaufteMenge, this.Total);

            return (this.ProduktID != null);

       }


       public static bool AddNewProdukte(
ref int? ProduktID,string ProduktName, int? GekaufteMenge, int Total)
        {
        ProduktID = clsProdukteData.AddNewProdukte(
ProduktName, GekaufteMenge, Total);

            return (ProduktID != null);

       }


       private bool _UpdateProdukte()
       {
        return clsProdukteData.UpdateProdukteByID(
this.ProduktID, this.ProduktName, this.GekaufteMenge,this.Total       );
       }


       public static bool UpdateProdukteByID(
int? ProduktID,string ProduktName, int? GekaufteMenge, int? Total  )
        {
        return clsProdukteData.UpdateProdukteByID(
ProduktID, ProduktName, GekaufteMenge, Total);

        }


       public static clsProdukte FindByProduktID(int? ProduktID)

        {
            if (ProduktID == null)
            {
                return null;
            }
            string ProduktName = null;
            int? GekaufteMenge = null;
            int? Total = null;
            bool IsFound = clsProdukteData.GetProdukteInfoByID(ProduktID,
 ref ProduktName,  ref GekaufteMenge, ref Total);

           if(IsFound)
               return new clsProdukte(
 ProduktID,  ProduktName,  GekaufteMenge, Total);
            else
                return  null;
        }

        public static clsProdukte FindByProduktName(string ProduktName)

        {
            if (string.IsNullOrEmpty(ProduktName))
                return null;

            int ? ProduktID = null;
            int? GekaufteMenge = null;
            int? Total = null;
            bool IsFound = clsProdukteData.GetProdukteInfoByName(ref ProduktID,
        ProduktName, ref GekaufteMenge, ref Total);

            if (IsFound)
                return new clsProdukte(
  ProduktID, ProduktName, GekaufteMenge, Total);
            else
                return null;
        }
        public static DataTable GetAllProdukte()
       {

        return clsProdukteData.GetAllProdukte();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewProdukte())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateProdukte();

            }
        
            return false;
        }



       public static bool DeleteProdukte(int ProduktID)
       {

        return clsProdukteData.DeleteProdukte(ProduktID);

       }


        public enum enProdukteColumns
         {
            ProduktID,
            ProduktName,
            GekaufteMenge
         }


        //public static DataTable SearchData(enProdukteColumns enChose, string Data)
        //{
        //    if(!SqlHelper.IsSafeInput(Data))
        //        return null;
            
        //    return clsProdukteData.SearchData(enChose.ToString(), Data);

        //}        



    }
}
