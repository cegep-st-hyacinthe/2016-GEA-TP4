﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuEchec.Librairie
{
    public class Position
    {
        #region Propriétés

        public int Ligne { get; private set; }
        public int Colonne { get; private set; }

        public int Index
        {
            get
            {
                return 8 * Colonne + Ligne;
            }
        }

        #endregion

        #region Constructeurs

        public Position(int ligne, int colonne)
        {
            Ligne = ligne;
            Colonne = colonne;
        }

        #endregion
    }
}