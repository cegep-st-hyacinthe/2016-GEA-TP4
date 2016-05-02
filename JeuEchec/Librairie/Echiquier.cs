using JeuEchec.Librairie.Pieces;
using VisualArrays;

namespace JeuEchec.Librairie
{
    public class Echiquier
    {
        #region Champs

        private VisualIntArray _tableau;

        #endregion

        #region Constructeurs

        public Echiquier(VisualIntArray tableau)
        {
            _tableau = tableau;

            // Colore chaque case du tableau
            for (dynamic ligne = 0, estNoir = false; ligne < _tableau.RowCount; ligne++)
            {
                estNoir = ligne == 0 || ligne % 2 == 0 ? false : true;
                for (int colonne = 0; colonne < _tableau.ColumnCount; colonne++)
                {
                    if (estNoir)
                    {
                        _tableau[ligne, colonne] = 1;
                    }
                    estNoir = !estNoir;
                }
            }
        }

        public Echiquier(VisualIntArray tableau, Piece[] pieces) : this (tableau)
        {
            _tableau.Sprites.AddRange(pieces);
        }

        #endregion

        #region Méthodes

        #endregion
    }
}