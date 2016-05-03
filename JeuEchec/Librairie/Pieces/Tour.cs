using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    class Tour : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_tour; } }
        protected override Image imageNoir { get { return Properties.Resources.noir_tour; } }

        #endregion

        #region Constructeurs

        public Tour(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Tour(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
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
