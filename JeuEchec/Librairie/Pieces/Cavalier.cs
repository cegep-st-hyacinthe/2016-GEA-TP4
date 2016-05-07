﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie.Pieces
{
    class Cavalier : Piece
    {
        #region Propriétés

        protected override Image imageBlanc { get { return Properties.Resources.blanc_cavalier; } }

        protected override Image imageNoir { get { return Properties.Resources.noir_cavalier; } }

        public override Deplacement[] DeplacementsPermis
        {
            get
            {
                return new Deplacement[]
                {
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut, 1),
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, 2),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut, 2),
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, 1),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut, 2),
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, 1),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Haut, 1),
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, 2),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas, 1),
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, 2),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas, 2),
                        new Vecteur(Vecteur.DirectionsHorizontales.Droite, 1),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas, 2),
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, 1),
                    }),
                    new Deplacement(new Vecteur[]
                    {
                        new Vecteur(Vecteur.DirectionsVerticales.Bas, 1),
                        new Vecteur(Vecteur.DirectionsHorizontales.Gauche, 2),
                    }),
                };
            }
        }

        #endregion

        #region Constructeurs

        public Cavalier(Position position, Couleurs couleur) : base(position, couleur)
        {

        }

        public Cavalier(Position position, Couleurs couleur, bool visible) : base(position, couleur, visible)
        {

        }

        #endregion

        #region Méthodes

        #endregion
    }
}
