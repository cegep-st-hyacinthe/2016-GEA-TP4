using JeuEchec.Librairie;
using JeuEchec.Librairie.Pieces;
using System;
using System.Windows.Forms;

namespace JeuEchec
{
    /// <summary>
    /// Auteur:
    /// Description:
    /// Date:
    /// </summary>
    public partial class frmEchiquier : Form
    {
        #region Champs

        private Echiquier _echiquier;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Auteur:
        /// Description:
        /// Date
        /// </summary>
        public frmEchiquier()
        {
            InitializeComponent();
        }

        #endregion

        #region Méthode(s)

        #endregion

        #region Événements

        private void frmEchiquier_Load(object sender, EventArgs e)
        {
            _echiquier = new Echiquier(viaEchiquier, new Piece[]
            {
                new Pion(new Position(2, 2), Couleurs.Noir)
            });
        }

        private void itmQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
