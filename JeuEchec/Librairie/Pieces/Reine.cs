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
        #region Champs

        private Deplacement[] _deplacementPermis = new Deplacement[]
                {
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, Vecteur.DirectionsVerticales.Haut)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, Vecteur.DirectionsVerticales.Haut)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, Vecteur.DirectionsVerticales.Bas)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, Vecteur.DirectionsVerticales.Bas)
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche)
                    }),
                };

        #endregion

        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_reine; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_reine; } }

        public override Deplacement[] DeplacementsPermis { get { return _deplacementPermis; } }

        #endregion

        #region Constructeurs

        public Reine(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Reine(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
        {

        }

        #endregion

        #region Méthodes

        #endregion
    }
}
