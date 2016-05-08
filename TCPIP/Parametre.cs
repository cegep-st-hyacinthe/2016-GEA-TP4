using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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

        #region Constantes

         private const string FICHIER = "ParametreTCPIP.xml";

        #endregion

        #region Champs

        private string adresseIp = "";
        private int port = 0;

        #endregion

        #region Properties

        public string AdresseIp
        {
            get
            {
                return adresseIp;
            }

            set
            {
                Regex rgx = new Regex(@"^([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])\.([01]?\d{1,2}|2[0-4]\d|25[0-5])$");
                if (!rgx.IsMatch(value)) value = "";

                adresseIp = value;
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

        #region Constructeurs

        public Parametre(string adresseIp, int port, Modes modes)
        {
            AdresseIp = adresseIp;
            Port = port;
            Mode = modes;
        }

        #endregion

        #region Methods

        public void Sauvegarder()
        {
            FileStream file = new FileStream(FICHIER, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Parametre));
            serializer.Serialize(file, this);
            file.Close();
        }

        public static Parametre Charger()
        {
            Parametre parametre = null;

            if (File.Exists(FICHIER))
            {
                FileStream file = new FileStream(FICHIER, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Parametre));
                parametre = ((Parametre)serializer.Deserialize(file));
                file.Close();
            }

            return parametre;
        }

        #endregion
    }
}
