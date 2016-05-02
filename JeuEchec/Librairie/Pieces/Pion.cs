using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    public class Pion : Piece
    {

        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_pion; } }
        protected override Image imageNoir { get { return Properties.Resources.noir_pion; } }

        #endregion

        #region Constructeurs

        public Pion(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        #endregion

        #region Méthodes

        public override Position[] ObtenirPosibilites()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
