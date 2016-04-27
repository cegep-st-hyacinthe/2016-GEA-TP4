using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuEchecLibrarie
{
    public abstract class Piece
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