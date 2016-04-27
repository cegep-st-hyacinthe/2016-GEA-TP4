using VisualArrays;

namespace JeuEchecLibrarie
{
    public abstract class Piece : ImageSprite
    {
        public Piece()
        {
            throw new System.NotImplementedException();
        }

        public Couleurs Couleur
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Position Position
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Deplacer()
        {
            throw new System.NotImplementedException();
        }

        public bool ValiderDeplacement()
        {
            throw new System.NotImplementedException();
        }

        public abstract Position[] ObtenirPosibilites();
    }
}