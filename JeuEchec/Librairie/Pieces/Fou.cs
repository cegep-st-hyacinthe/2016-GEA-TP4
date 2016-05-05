using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    class Fou : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_fou; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_fou; } }

        #endregion

        #region Constructeurs

        public Fou(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Fou(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
        {

        }

        #endregion

        #region Méthodes



        #endregion
    }
}
