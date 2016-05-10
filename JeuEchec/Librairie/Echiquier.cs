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

        public List<Piece> Pieces { get { return (_tableau.Sprites).Cast<Piece>().ToList(); } }

        #endregion

        #region Indexeurs

        public Piece this[int ligne, int colonne]
        {
            get
            {
                return Pieces.Find(x => x.DisplayAddress.Row == ligne && x.DisplayAddress.Column == colonne && x.Visible);
            }
        }

        public Piece this[Position position]
        {
            get
            {
                return Pieces.Find(x => x.DisplayAddress.Row == position.Ligne && x.DisplayAddress.Column == position.Colonne && x.Visible);
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
                // Si il existe déjà une pièce à cette position
                if (this[piece.DisplayAddress.Row, piece.DisplayAddress.Column] != null) throw new Exception();

                piece.Echichier = this;
            }

            _tableau.Sprites.AddRange(pieces);
        }

        #endregion

        #region Méthodes

        public List<Position> ObtenirPositions(Piece piece, Deplacement deplacement)
        {
            List<Position> positions = new List<Position>();
            int ligneObservee = piece.DisplayAddress.Row;
            int colonneObservee = piece.DisplayAddress.Column;

            foreach (var vecteur in deplacement.Vecteurs)
            {
                int distanceParcourue = 0;

                // Tant qu'on ne parcourt pas la même distance que la distance du vecteur
                while(distanceParcourue < vecteur.Distance || vecteur.Distance == -1)
                {
                    // Observe la prochaine ligne
                    ligneObservee += (int)(vecteur.DirectionVerticale);
                    // Observe la prochaine colonne
                    colonneObservee += (int)(vecteur.DirectionHorizontale);

                    try
                    {
                        // Crée une position sur la ligne et la colonne observée et l'ajoute à la liste de positons
                        positions.Add(new Position(ligneObservee, colonneObservee));
                    }
                    // Quand la création de la position renvoie une erreur
                    catch (Exception)
                    {
                        // Arrête l'exécution de la boucle
                        break;
                    }
                    // Ajoute 1 à la distance parcourue
                    distanceParcourue++;
                }
            }

            return positions;
        }

        public Echiquier Cloner()
        {
            return (Echiquier)MemberwiseClone();
        }


        //Rafraichir la grille
        public void Rafraichir()
        {
            _tableau.Refresh();
        }

        #endregion
    }
}