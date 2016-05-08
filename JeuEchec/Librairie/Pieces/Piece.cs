using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VisualArrays;

namespace JeuEchec.Librairie.Pieces
{
    public abstract class Piece : ImageSprite
    {
        #region Champs

        private Echiquier _echiquier;
        private bool _mange;

        #endregion

        #region Propriétés

        public Couleurs Couleur { get; }

        public abstract Deplacement[] DeplacementsPermis { get; }

        protected abstract Image imageBlanc { get; }

        protected abstract Image imageNoir { get; }

        public Echiquier Echichier
        {
            get
            {
                return _echiquier;
            }
            set
            {
                if (_echiquier == null && value != null)
                {
                    _echiquier = value;
                }
            }
        }

        public bool Mange
        {
            get
            {
                return _mange;
            }
            set
            {
                Visible = false;

                _mange = value;
            }
        }


        #endregion

        #region Constructeurs

        public Piece(Position position, Couleurs couleur)
        {
            DisplayIndex = position.Index;
            Couleur = couleur;
            Size = new Size(75, 75);
            Animated = true;
            AllowDrag = true;
            Duration = 300;
            Image = Couleur == Couleurs.Blanc ? imageBlanc : imageNoir;
        }

        public Piece(Position position, Couleurs couleur, bool visible) : this(position, couleur)
        {
            Visible = visible;
        }

        #endregion

        #region Méthodes

        public void DeplacerVers(Position positionFinale)
        {
            Position[] deplacement = TrouverDeplacement(positionFinale);

            if (deplacement != null && deplacement.Length > 0)
            {
                foreach (Position position in deplacement)
                {
                    MoveTo(position.Ligne, position.Colonne);

                    // Arrête le déplacement lorsqu'on atteind la position finale
                    if (DisplayAddress.Row == positionFinale.Ligne && DisplayAddress.Column == positionFinale.Colonne) return;
                }
            }
        }

        private Position[] TrouverDeplacement(Position positionFinale)
        {
            foreach (Deplacement deplacement in DeplacementsPermis)
            {
                List<Position> positionsPossibles = Echichier.ObtenirPositions(this, deplacement);

                // Si la position finale est contenu dans les positions possibles 
                if (positionsPossibles.Find(x => x.Ligne == positionFinale.Ligne && x.Colonne == positionFinale.Colonne) != null)
                {
                    // On a trouvé un déplacement valide
                    return positionsPossibles.ToArray();
                }
            }
            return null;
        }

        #endregion
    }
}