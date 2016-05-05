using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuEchec.Librairie
{
    public class Position
    {
        #region Énumérations

        private enum Colonnes
        {
            A, B, C, D, E, F, G, H
        }

        #endregion

        #region Champs

        private int _ligne;
        private int _colonne;

        #endregion

        #region Propriétés

        public int Index { get { return Echiquier.NB_COLONNES * Colonne + Ligne; } }

        public int Ligne
        {
            get
            {
                return _ligne;
            }
            set
            {
                if (value > Echiquier.NB_LIGNES) throw new Exception();

                _ligne = value;
            }
        }

        public int Colonne
        {
            get
            {
                return _colonne;
            }
            set
            {
                if (value > Echiquier.NB_COLONNES) throw new Exception();

                _colonne = value;
            }
        }

        #endregion

        #region Constructeurs

        public Position(int ligne, int colonne)
        {
            Ligne = ligne;
            Colonne = colonne;
        }

        public Position(char colonne, int ligne)
        {
            Ligne = (int)((Colonnes)(Enum.Parse(typeof(Colonnes), (colonne.ToString()).ToUpper())));
            Colonne = Echiquier.NB_LIGNES - ligne;
        }

        #endregion
    }
}