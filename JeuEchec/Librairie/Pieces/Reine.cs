using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    class Reine : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_fou; } }
        protected override Image imageNoir { get { return Properties.Resources.noir_fou; } }

        #endregion

        #region Constructeurs

        public Reine(Position position, Couleurs couleur) : base(position, couleur)
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
