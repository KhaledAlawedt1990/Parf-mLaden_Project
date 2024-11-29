using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busnisse_Layer
{
    public class clsProduktKey
    {
       
        public static bool AddnewProduktKay(string key)
        {
            return clsProductSchlüsselDatenzugriff.AddnewSchluessl(key);
        }

        public static DataTable GetDatumAndAblaufdatumBySchluessel(string key)
        {
            return clsProductSchlüsselDatenzugriff.GetDatumUndStatusByProduktSchluessel(key);
        }
    }
}
