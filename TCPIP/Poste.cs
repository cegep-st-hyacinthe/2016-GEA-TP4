using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationLib;

namespace TCPIP
{
    public class Poste
    {
        #region Champs

        Parametre _parametre;
        ClientTcpIp _client;
        ServeurTcpIp _serveur;

        #endregion

        #region Constructeurs

        public Poste(Parametre parametre)
        {
            _parametre = parametre;
        }

        #endregion
        #region Proprietes

        public delegate void RecevoirMessage(object donnee);

        #endregion

        #region Methods

        public void AttendreConnection()
        {
            if (_parametre.Mode == Parametre.Modes.Client)
            {
                _client = new ClientTcpIp();
                _client.NotifierMessages += IntercepterMessage;
                _client.Connecter(_parametre.AdresseIp, _parametre.Port);
            }
            else if (_parametre.Mode == Parametre.Modes.Serveur)
            {
                _serveur = new ServeurTcpIp();
                _serveur.Écouter(_parametre.AdresseIp, _parametre.Port);
            }
        }

        public void IntercepterMessage(object sender, MessageArgs e)
        {
            object obj = new object();
            
        }
        #endregion
    }
}
