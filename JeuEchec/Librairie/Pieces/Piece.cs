using System;
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
                if (_echiquier != null)
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

        public Deplacement[] DeplacementsPermis
        {
            get
            {
                return null;
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

                    if (DisplayIndex == positionFinale.Index) return;
                }
            }
        }

        private Position[] TrouverDeplacement(Position positionFinale)
        {
            foreach (Deplacement deplacement in DeplacementsPermis)
            {
                Position[] positionsPossibles = Echichier.ObtenirPositions(deplacement);

                // Si la position est contenu dans les positions possibles 
                if (positionsPossibles != null || Array.IndexOf(positionsPossibles, positionFinale) >= 0)
                {
                    // On a trouvé un déplacement valide
                    return positionsPossibles;
                }
            }
            return null;
        }

        #endregion
    }
}