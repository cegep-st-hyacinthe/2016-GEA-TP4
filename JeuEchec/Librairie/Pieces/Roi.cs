using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JeuEchec.Librairie.Pieces
{
    class Roi : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_roi; } }
        protected override Image imageNoir { get { return Properties.Resources.noir_roi; } }

        #endregion

        #region Constructeurs

        public Roi(Position position, Couleurs couleur) : base(position, couleur)
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
