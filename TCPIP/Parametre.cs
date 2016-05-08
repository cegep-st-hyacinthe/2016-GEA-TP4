using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TCPIP
{
    public class Parametre
    {
        #region Enumerations

        public enum Modes
        {
            Client,
            Serveur
        }

        #endregion

        #region Properties




        private string ipAddress = "";
        private int port = 0;
        public string IpAddress
        {
            get
            {
                return ipAddress;
            }

            set
            {
                Regex rgx = new Regex(@"^([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])$");
                if (!rgx.IsMatch(value)) value = "";

                ipAddress = value;
            }
        }
        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                if (value < 0 || value >= 65535) value = 0;

                port = value;
            }
        }
        public Modes Mode { get; set; }

        #endregion
    }
}
