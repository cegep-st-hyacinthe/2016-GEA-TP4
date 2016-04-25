using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualArrays;

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
        /// <summary>
        /// Auteur:
        /// Description:
        /// Date
        /// </summary>
        private void AfficherEchiquierDamier()
        {
            // Programmer l'affichage de l'échiquier.

        }
        #endregion

        #region Événements
        private void frmEchiquier_Load(object sender, EventArgs e)
        {
            // Afficher l'échiquier.
            AfficherEchiquierDamier();

            // Placer les pièces à la position de départ.
        }
        #endregion
    }
}
