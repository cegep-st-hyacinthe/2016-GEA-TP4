using JeuEchec.Librarie;
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

            _echiquier = (Echiquier)viaEchiquier;

        }

        #endregion

        #region Méthode(s)

        #endregion

        #region Événements

        private void viaEchiquier_Load(object sender, EventArgs e)
        {
            _echiquier.AfficherCases();
        }

        private void itmQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
