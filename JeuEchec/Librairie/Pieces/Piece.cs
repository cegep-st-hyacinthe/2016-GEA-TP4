﻿using System;
using System.Collections.Generic;
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

        public abstract Deplacement[] DeplacementsPermis { get; }

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
                if (_echiquier == null && value != null)
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
                Echichier.Rafraichir();

                _mange = value;
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
            Duration = 300;
            Image = Couleur == Couleurs.Blanc ? imageBlanc : imageNoir;
        }

        public Piece(Position position, Couleurs couleur, bool visible) : this(position, couleur)
        {
            Visible = visible;
        }

        #endregion

        #region Méthodes

        public bool DeplacerVers(Position positionFinale)
        {
            List<Position> deplacement = TrouverDeplacement(positionFinale);
            Piece pieceMangee = Echichier[positionFinale];

            // Si il y a une pièce à la destination et que cette pièce est de la même couleur ou que c'est un roi, le déplacement est invalide
            if (pieceMangee != null && pieceMangee.Couleur == Couleur || pieceMangee is Roi) return false;

            if (deplacement != null && deplacement.Count > 0)
            {
                foreach (Position position in deplacement)
                {
                    MoveTo(position.Ligne, position.Colonne);

                    // Si la position finale est atteinte
                    if (DisplayAddress.Row == positionFinale.Ligne && DisplayAddress.Column == positionFinale.Colonne)
                    {
                        // Si il y a une pièce à manger 
                        if (pieceMangee != null)
                        {
                            // Mange la pièce
                            Manger(pieceMangee);
                        }

                        // Arrête le déplacement
                        return true;
                    }
                }
            }
            return false;
        }

        public void Manger(Piece piece)
        {
            if (piece.Couleur == Couleur) throw new Exception();

            piece.Mange = true;
        }

        protected virtual List<Position> LimiterDeplacement(List<Position> deplacement)
        {
            List<Position> nouveauDeplacement = new List<Position>();

            foreach (Position position in deplacement)
            {
                Piece contenuPosition = Echichier[position];

                // Si la position ne contient pas de pièce
                if (contenuPosition == null)
                {
                    // Ajoute la position à la liste
                    nouveauDeplacement.Add(position);
                }

                // Si la position contient une pièce, arrête la boucle
                if (contenuPosition != null) break;
            }

            return nouveauDeplacement;
        }

        private List<Position> TrouverDeplacement(Position positionFinale)
        {
            foreach (Deplacement deplacement in DeplacementsPermis)
            {
                // Obtenir les postions pour le déplacement 
                List<Position> deplacementPossible = Echichier.ObtenirPositions(this, deplacement);

                // Retirer les positions impossibles du déplacement
                deplacementPossible = LimiterDeplacement(deplacementPossible);

                // Si la position finale est contenu dans les positions possibles 
                if (deplacementPossible.Find(x => x.Ligne == positionFinale.Ligne && x.Colonne == positionFinale.Colonne) != null)
                {
                    // On a trouvé un déplacement correspondant
                    return deplacementPossible;
                }
            }
            return null;
        }



        #endregion
    }
}