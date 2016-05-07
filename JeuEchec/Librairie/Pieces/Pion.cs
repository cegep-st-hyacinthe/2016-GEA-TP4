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

        public Vecteur.DirectionsVerticales DirectionVerticale { get; private set; }

        public override Deplacement[] DeplacementsPermis
        {
            get
            {
                return new Deplacement[]
                {
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(DirectionVerticale, 1)
                    })
                };
            }
        }

        #endregion

        #region Constructeurs

        public Pion(Position position, Couleurs couleur, Vecteur.DirectionsVerticales directionVerticale) : base(position, couleur)
        {
            DirectionVerticale = directionVerticale;
        }

        public Pion(Position position, Couleurs couleur, Vecteur.DirectionsVerticales directionVerticale, bool visible) : base(position, couleur, visible)
        {
            DirectionVerticale = directionVerticale;
        }

        #endregion

        #region Méthodes

        #endregion
    }
}
