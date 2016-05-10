using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TcpIp
{
    public class PosteTcpIp
    {
        #region Champs

        ParametreTcpIp _parametre;

        #endregion

        #region Propriétés

        public Action<object> RecevoirMessage;

        #endregion

        #region Constructeurs

        public PosteTcpIp(ParametreTcpIp parametre)
        {
            _parametre = parametre;
        }

        #endregion

        #region Methods

    //    public void AttendreConnection()
    //    {
    //        if (_parametre.Mode == ParametreTcpIp.Modes.Client)
    //        {
    //            _client = new ClientTcpIp();
    //            _client.NotifierMessages += IntercepterMessage;
    //            _client.Connecter(_parametre.AdresseIp, _parametre.Port);
    //        }
    //        else if (_parametre.Mode == ParametreTcpIp.Modes.Serveur)
    //        {
    //            _serveur = new ServeurTcpIp();
    //            _serveur.NotifierMessages += IntercepterMessage;
    //            _serveur.Écouter(_parametre.AdresseIp, _parametre.Port);
    //        }
    //    }

    //    public void IntercepterMessage(object sender, MessageArgs e)
    //    {
    //        XmlSerializer serializeurXml = new XmlSerializer(typeof(object));
    //        StringReader deserializeurTxt = new StringReader(e.Message);

    //        object messageObj = serializeurXml.Deserialize(deserializeurTxt);

    //        switch (e.Action)
    //        {
    //            case MessageArgs.enumActions.ENVOYÉ:
    //                break;
    //            case MessageArgs.enumActions.REÇU:
    //                RecevoirMessage(messageObj);
    //                break;
    //            case MessageArgs.enumActions.LOG:
    //                break;
    //            case MessageArgs.enumActions.CONNECTÉ:
    //                break;
    //            case MessageArgs.enumActions.DÉCONNECTÉ:
    //                break;
    //            case MessageArgs.enumActions.ATTENTE:
    //                break;
    //            case MessageArgs.enumActions.AUCUNE:
    //                break;
    //            default:
    //                break;
    //        }            
    //    }

    //    public void EnvoyerMessage<T>(T message)
    //    {
    //        XmlSerializer serializeurXml = new XmlSerializer(message.GetType());
    //        StringWriter serializeurTxt = new StringWriter();
    //        serializeurXml.Serialize(serializeurTxt, message);

    //        string messageTxt = serializeurTxt.ToString();
                 
    //        if (_parametre.Mode == ParametreTcpIp.Modes.Client)
    //        {
    //            _client.Envoyer(messageTxt);
    //        }
    //        else if (_parametre.Mode == ParametreTcpIp.Modes.Serveur)
    //        {
    //            _serveur.Envoyer(messageTxt);
    //        }
    //    }
     #endregion
    }
}
