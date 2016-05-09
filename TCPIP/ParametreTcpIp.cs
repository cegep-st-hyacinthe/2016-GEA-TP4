using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TcpIp
{
    public class ParametreTcpIp
    {
        #region Énumérations

        public enum Modes
        {
            Client,
            Serveur
        }

        #endregion

        #region Constantes

         private const string FICHIER = "ParametreTcpIp.xml";

        #endregion

        #region Champs

        private string adresseIp = "";
        private int port = 0;

        #endregion

        #region Propriétés

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

        public ParametreTcpIp(string adresseIp, int port, Modes mode)
        {
            AdresseIp = adresseIp;
            Port = port;
            Mode = mode;
        }

        #endregion

        #region Méthodes

        public void Sauvegarder()
        {
            FileStream fichier = new FileStream(FICHIER, FileMode.Create);
            XmlSerializer serializeur = new XmlSerializer(typeof(ParametreTcpIp));
            serializeur.Serialize(fichier, this);
            fichier.Close();
        }

        public static ParametreTcpIp Charger()
        {
            ParametreTcpIp parametre = null;

            if (File.Exists(FICHIER))
            {
                FileStream fichier = new FileStream(FICHIER, FileMode.Open);
                XmlSerializer serializeur = new XmlSerializer(typeof(ParametreTcpIp));
                parametre = ((ParametreTcpIp)serializeur.Deserialize(fichier));
                fichier.Close();
            }

            return parametre;
        }

        #endregion
    }
}
