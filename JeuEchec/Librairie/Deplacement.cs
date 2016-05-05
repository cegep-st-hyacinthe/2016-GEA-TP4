using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec.Librairie
{
    public class Deplacement
    {
        #region Propriétés

        public Vecteur[] Vecteurs { get; private set; }

        public bool IgnorerObstacles { get; private set; }

        #endregion

        #region Constructeurs

        public Deplacement(Vecteur[] vecteurs, bool ignorerObstacles = false)
        {
            Vecteurs = vecteurs;
            IgnorerObstacles = ignorerObstacles;
        }

        #endregion
    }
}
