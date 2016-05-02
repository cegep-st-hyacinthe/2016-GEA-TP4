using JeuEchec.Librairie.Pieces;
using System;
using System.Collections.Generic;

namespace JeuEchec.Librairie
{
    public class Joueur
    {
        #region Propriétés

        public string Nom { get; private set; }

        public Couleurs Couleur { get; private set; }

        public IEnumerable<Piece> Pieces { get; private set; }

        public IEnumerable<Piece> PiecesManges { get; private set; }

        #endregion

        #region Constructeurs

        public Joueur(string nom, Couleurs couleur)
        {
            Nom = nom;
            Couleur = couleur;
        }

        public Joueur(string nom, Couleurs couleur, Piece[] pieces) : this(nom, couleur)
        {
            foreach (var piece in pieces)
            {
                if (piece.Couleur != Couleur) throw new Exception();
            }
            Pieces = pieces;
        }

        #endregion
    }
}