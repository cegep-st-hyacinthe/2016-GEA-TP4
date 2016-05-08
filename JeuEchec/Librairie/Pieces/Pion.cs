using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    public class Pion : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_pion; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_pion; } }

        public Vecteur.DirectionsVerticales DirectionVerticale { get; private set; }

        public override Deplacement[] DeplacementsPermis
        {
            get
            {
                List<Deplacement> deplacements = new List<Deplacement>();

                // Contenu de la position en haut
                Piece haut = Echichier[DisplayAddress.Row + (int)DirectionVerticale, DisplayAddress.Column ];
                // Si la position est vide
                if (haut == null)
                {
                    deplacements.Add(new Deplacement(new Vecteur[]
                    {
                        new Vecteur(DirectionVerticale, 1)
                    }));
                }

                // Si le pion se trouve sur sa ligne de départ
                if (DisplayAddress.Row == 1 || DisplayAddress.Row == Echiquier.NB_LIGNES - 2)
                {
                    // Il peut avancer de 2
                    deplacements.Add(new Deplacement(new Vecteur[]
                    {
                        new Vecteur(DirectionVerticale, 2)
                    }));
                }

                // Contenu de la position en diagonale à gauche du pion
                Piece diagonaleGauche = Echichier[DisplayAddress.Row + (int)DirectionVerticale, DisplayAddress.Column + (int)(Vecteur.DirectionsHorizontales.Gauche)];
                // Si la position en diagonale à gauche du pion contient une pièce ennemie
                if (diagonaleGauche != null && diagonaleGauche.Couleur != Couleur)
                {
                    // Il peut avancer en diagonale à gauche
                    deplacements.Add(new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, DirectionVerticale, 1)
                    }));
                }

                // Contenu de la position en diagonale à droite du pion
                Piece diagonaleDroite = Echichier[DisplayAddress.Row + (int)DirectionVerticale, DisplayAddress.Column + (int)(Vecteur.DirectionsHorizontales.Droite)];
                // Si la position en diagonale à droite du pion contient une pièce ennemie
                if (diagonaleDroite != null && diagonaleDroite.Couleur != Couleur)
                {
                    // Il peut avancer en diagonale à droite
                    deplacements.Add(new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, DirectionVerticale, 1)
                    }));
                }

                return deplacements.ToArray();
            }
        }

        #endregion

        #region Constructeurs

        public Pion(Position position, Couleurs couleur, Vecteur.DirectionsVerticales directionVerticale) : base(position, couleur)
        {
            DirectionVerticale = directionVerticale;
        }

        public Pion(Position position, Couleurs couleur, Vecteur.DirectionsVerticales directionVerticale, bool visible) : base(position, couleur, visible)
        {
            DirectionVerticale = directionVerticale;
        }

        #endregion

        #region Méthodes

        #endregion
    }
}
