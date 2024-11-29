using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busnisse_Layer
{
    public class clsBackup
    {
        public static bool IsBackupSuccessfulByHostname()
        {
            return clsBackupDatenzugriff.BackupDatabaseByHostname() ;
        }
        public static bool IsBackupSuccessfulByMacAdresse()
        {
            return clsBackupDatenzugriff.BackupDatabaseByMacAdresse();
        }
    }
}
