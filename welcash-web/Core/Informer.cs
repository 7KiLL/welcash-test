using System;
using System.IO;
using System.Text.Json;

namespace welcash_web.Core
{
    public class Informer
    {
        public string computerNane => getComputerName();
        public string diskCfreeSpace => getFreeSpace();
        public string updateTimestamp => getUpdateTime();

        public string getUpdateTime()
        {
            return string.Format("{0:O}", DateTime.Now.ToUniversalTime());
        }

        public string getFreeSpace()
        {
            // There is no PS in my IDE or installed packages, so this is how we do it
            DriveInfo cDrive = new DriveInfo("C");
            // To MB
            return (Convert.ToDouble(cDrive.AvailableFreeSpace)  / (1024 * 1024))
                .ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public string getComputerName()
        {
            return Environment.MachineName.ToString();
        }

        public string toJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}