using JeuEchec.Librairie.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JeuEchec.Librairie
{
    public class Joueur
    {
        #region Propriétés

        public string Nom { get; private set; }

        public Couleurs Couleur { get; private set; }

        #endregion

        #region Constructeurs

        public Joueur(string nom, Couleurs couleur)
        {
            Nom = nom;
            Couleur = couleur;
        }

        #endregion

        #region Méthodes

        public void DeplacerPiece(Piece piece)
        {
            if (piece.Couleur == Couleur)
            {

            }
        }

        #endregion
    }
}