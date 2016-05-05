using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie
{
    public class Vecteur
    {
        #region Énumérations

        public enum DirectionsHorizontales
        {
           Gauche = -1,
           Droite = 1
        }

        public enum DirectionsVerticales
        {
            Haut = -1,
            Bas = 1
        }

        #endregion

        #region Propriétés

        public DirectionsHorizontales DirectionHorizontale { get; private set; } = 0;

        public DirectionsVerticales DirectionVerticale { get; private set; } = 0;

        public int Distance { get; private set; }

        #endregion

        #region Constructeurs

        public Vecteur(DirectionsHorizontales directionHorizontale, DirectionsVerticales directionVerticale, int distance = -1)
        {
            DirectionHorizontale = directionHorizontale;
            DirectionVerticale = directionVerticale;
            Distance = distance;
        }

        public Vecteur(DirectionsHorizontales directionHorizontale, int distance = -1)
        {
            DirectionHorizontale = directionHorizontale;
            Distance = distance;
        }

        public Vecteur(DirectionsVerticales directionVerticale, int distance = -1)
        {
            DirectionVerticale = directionVerticale;
            Distance = distance;
        }

        #endregion
    }
}
