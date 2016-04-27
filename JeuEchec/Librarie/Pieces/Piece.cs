using VisualArrays;

namespace JeuEchec.Librarie
{
    public class Piece : ImageSprite
    {
        #region Propriétés

        public Couleurs Couleur { get; set; }

        #endregion

        #region Constructeurs

        public Piece(Position position, Couleurs couleur)
        {
            Deplacer(position);
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

        //public abstract Position[] ObtenirPosibilites();

        #endregion
    }
}