using VisualArrays;

namespace JeuEchec.Librarie
{
    public class Echiquier : VisualIntArray
    {

        public void AfficherCases()
        {
            bool estNoir = false;
            for (int ligne = 0; ligne < RowCount; ligne++)
            {
                estNoir = ligne == 0 || ligne % 2 == 0 ? false : true;
                for (int colonne = 0; colonne < ColumnCount; colonne++)
                {
                    if (estNoir)
                    {
                        this[ligne, colonne] = 1;
                    }
                    estNoir = !estNoir;
                }
            }
        }
    }
}