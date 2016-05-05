using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    class Cavalier : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_cavalier; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_cavalier; } }

        public override Deplacement[] DeplacementsPermis { get { return null; } }

        #endregion

        #region Constructeurs

        public Cavalier(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Cavalier(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
        {

        }

        #endregion

        #region Méthodes



        #endregion
    }
}
