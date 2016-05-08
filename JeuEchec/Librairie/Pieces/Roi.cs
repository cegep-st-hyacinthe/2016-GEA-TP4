using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JeuEchec.Librairie.Pieces
{
    public class Roi : Piece
    {
        #region Champs

        private Deplacement[] _deplacementPermis = new Deplacement[]
                {
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, Vecteur.DirectionsVerticales.Haut, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, Vecteur.DirectionsVerticales.Haut, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, Vecteur.DirectionsVerticales.Bas, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, Vecteur.DirectionsVerticales.Bas, 1)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, 1)
                    }),
                };

        #endregion

        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_roi; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_roi; } }

        public override Deplacement[] DeplacementsPermis { get { return _deplacementPermis; } }

        #endregion

        #region Constructeurs

        public Roi(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Roi(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
        {

        }

        #endregion

        #region Méthodes

        #endregion
    }
}
