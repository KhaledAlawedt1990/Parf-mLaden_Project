
using System;
using System.Data;
using ParfümDb_DataLayer;

namespace ParfümDb_BusinessLayer
{
    public class clsLieferungen
    {
       

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

              public int? LieferungID { get; set; }
        public int? ProduktID { get; set; }
        public clsProdukte ProdukteInfo { get; set; }
        public string Kunde { get; set; }
        public bool? HauptGechäft { get; set; }
        public bool? DezGeschäft { get; set; }
        public int? GelieferteMenge { get; set; }


        public clsLieferungen()
        {
            this.LieferungID = null;
            this.LieferungID = null;
            this.ProduktID = null;
            this.Kunde = null;
            this.HauptGechäft = false;
            this.DezGeschäft = false;
            this.GelieferteMenge = null;
     
            Mode = enMode.AddNew;
        }


        private clsLieferungen(
int? LieferungID,int? ProduktID, string Kunde,bool? HauptGeschäft, bool? DezGeschäft, int? GelieferteMenge)
        {
            this.LieferungID = LieferungID;
            this.ProduktID = ProduktID;
            this.ProdukteInfo = clsProdukte.FindByProduktID(ProduktID);
            this.Kunde = Kunde;
            this.HauptGechäft = HauptGechäft;
            this.DezGeschäft = DezGeschäft;
            this.GelieferteMenge = GelieferteMenge;
        
        
            Mode = enMode.Update;
        }


       private bool _AddNewLieferungen()
       {
        this.LieferungID = clsLieferungenData.AddNewLieferungen(
this.ProduktID, this.Kunde,this.HauptGechäft, this.DezGeschäft, this.GelieferteMenge);

            return (this.LieferungID != null);

       }


       public static bool AddNewLieferungen(
ref int? LieferungID,int? ProduktID, string Kunde, bool HauptGeschäft, bool DezGeschäft, int? GelieferteMenge)
        {
        LieferungID = clsLieferungenData.AddNewLieferungen(
ProduktID, Kunde, HauptGeschäft, DezGeschäft,  GelieferteMenge);

            return (LieferungID != null);

       }


       private bool _UpdateLieferungen()
       {
        return clsLieferungenData.UpdateLieferungenByID(
this.LieferungID, this.ProduktID, this.Kunde,this.HauptGechäft, this.DezGeschäft, this.GelieferteMenge       );
       }


       public static bool UpdateLieferungenByID(
int? LieferungID,int? ProduktID, string Kunde, bool HauptGeschäft, bool DezGeschäft, int? GelieferteMenge     )
        {
        return clsLieferungenData.UpdateLieferungenByID(
LieferungID, ProduktID, Kunde,HauptGeschäft, DezGeschäft, GelieferteMenge);

        }


       public static clsLieferungen FindByLieferungID(int? LieferungID)

        {
            if (LieferungID == null)
            {
                return null;
            }
            int? ProduktID = null;
            string Kunde = null;
            bool? HauptGeschäft = false;
            bool? DezGeschäft = false;
            int? GelieferteMenge = null;
            bool IsFound = clsLieferungenData.GetLieferungenInfoByID(LieferungID,
 ref ProduktID,  ref Kunde, ref HauptGeschäft, ref DezGeschäft, ref GelieferteMenge);

           if(IsFound)
               return new clsLieferungen(
 LieferungID,  ProduktID,  Kunde, HauptGeschäft, DezGeschäft, GelieferteMenge);
            else
                return  null;
        }


       public static DataTable GetAllLieferungen()
       {

        return clsLieferungenData.GetAllLieferungen();

       }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewLieferungen())
                    {
                        Mode = enMode.Update;
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLieferungen();

            }
        
            return false;
        }



       public static bool DeleteLieferungen(int LieferungID)
       {

        return clsLieferungenData.DeleteLieferungen(LieferungID);

       }


   


    }
}
