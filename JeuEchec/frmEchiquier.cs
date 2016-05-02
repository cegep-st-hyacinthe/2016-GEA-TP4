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
                new Pion(new Position(0, 6), Couleurs.Noir),
                new Pion(new Position(1, 6), Couleurs.Noir),
                new Pion(new Position(2, 6), Couleurs.Noir),
                new Pion(new Position(3, 6), Couleurs.Noir),
                new Pion(new Position(4, 6), Couleurs.Noir),
                new Pion(new Position(5, 6), Couleurs.Noir),
                new Pion(new Position(6, 6), Couleurs.Noir),
                new Pion(new Position(7, 6), Couleurs.Noir),
                new Tour(new Position(0, 7), Couleurs.Noir),
                new Cavalier(new Position(1, 7), Couleurs.Noir),
                new Fou(new Position(2, 7), Couleurs.Noir),
                new Roi(new Position(3, 7), Couleurs.Noir),
                new Reine(new Position(4, 7), Couleurs.Noir),
                new Fou(new Position(5, 7), Couleurs.Noir),
                new Cavalier(new Position(6, 7), Couleurs.Noir),
                new Tour(new Position(7, 7), Couleurs.Noir),
            });
            _echiquier.AjouterPieces(new Piece[]
            {
                new Pion(new Position(0, 0), Couleurs.Blanc),
            });
        }

        private void itmQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void itmAfficherBlancs_Click(object sender, EventArgs e)
        {

        }
    }
}
