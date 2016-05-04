using JeuEchec.Librairie.Pieces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VisualArrays;

namespace JeuEchec.Librairie
{
    public class Echiquier
    {
        #region Constantes

        public const int NB_LIGNES = 8;
        public const int NB_COLONNES = 8;

        #endregion

        #region Champs

        private VisualIntArray _tableau;

        #endregion

        #region Propriétés

        public IEnumerable<Piece> Pieces { get { return (_tableau.Sprites).Cast<Piece>(); } }

        #endregion

        #region Indexeurs

        public Piece this[Position position]
        {
            get
            {
                return Pieces
                    .Where(x => x.DisplayIndex == position.Index && x.Visible)
                    .FirstOrDefault();
            }
        }

        #endregion

        #region Constructeurs

        public Echiquier(VisualIntArray tableau)
        {
            _tableau = tableau;

            if (_tableau.RowCount != NB_LIGNES || _tableau.ColumnCount != NB_COLONNES) throw new Exception();

            // Initialise la couleur des cases de l'échiquier
            for (dynamic ligne = 0, estNoir = false; ligne < NB_LIGNES; ligne++)
            {
                estNoir = ligne == 0 || ligne % 2 == 0 ? false : true;
                for (int colonne = 0; colonne < NB_COLONNES; colonne++)
                {
                    if (estNoir)
                    {
                        _tableau[ligne, colonne] = 1;
                    }
                    estNoir = !estNoir;
                }
            }
        }

        public Echiquier(VisualIntArray tableau, Piece[] pieces) : this(tableau)
        {
            foreach (Piece piece in pieces)
            {
                piece.Echichier = this;
            }

            _tableau.Sprites.AddRange(pieces);
        }

        #endregion

        #region Méthodes

        public Position[] ObtenirPositions(Deplacement deplacement)
        {
            return null;
        }

        #endregion
    }
}