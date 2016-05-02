using System.Drawing;
using VisualArrays;

namespace JeuEchec.Librairie.Pieces
{
    public abstract class Piece : ImageSprite
    {
        #region Propriétés

        public Couleurs Couleur { get; }
        protected abstract Image imageBlanc { get; }
        protected abstract Image imageNoir { get; }

        #endregion

        #region Constructeurs

        public Piece(Position position, Couleurs couleur)
        {
            DisplayIndex = position.Index;
            Couleur = couleur;
            Size = new Size(50, 50);
            Image = Couleur == Couleurs.Blanc ? imageBlanc : imageNoir;
        }

        #endregion

        #region Méthodes

        public void Deplacer(Position position)
        {
            MoveTo(position.Ligne, position.Colonne);
        }

        public bool ValiderDeplacement()
        {
            return false;
        }

        public abstract Position[] ObtenirPosibilites();

        #endregion
    }
}