using JeuEchec.Librairie;
using JeuEchec.Librairie.Pieces;
using System;
using System.Linq;
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
        private Echiquier _echiquierInitial;
        private Joueur _joueurNoir = new Joueur("Joueur Noir", Couleurs.Noir);
        private Joueur _joueurBlanc = new Joueur("Joueur Blanc", Couleurs.Blanc);
        private Joueur _joueurCourant;

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

            _joueurCourant = _joueurBlanc;
        }

        #endregion

        #region Méthode(s)

        #endregion

        #region Événements

        private void frmEchiquier_Load(object sender, EventArgs e)
        {
            _echiquier = new Echiquier(viaEchiquier, new Piece[]
            {
                new Tour(new Position('A', 1), Couleurs.Noir),
                new Cavalier(new Position('B', 1), Couleurs.Noir),
                new Fou(new Position('C', 1), Couleurs.Noir),
                new Roi(new Position('D', 1), Couleurs.Noir),
                new Reine(new Position('E', 1), Couleurs.Noir),
                new Fou(new Position('F', 1), Couleurs.Noir),
                new Cavalier(new Position('G', 1), Couleurs.Noir),
                new Tour(new Position('H', 1), Couleurs.Noir),
                new Pion(new Position('A', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('B', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('C', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('D', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('E', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('F', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('G', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),
                new Pion(new Position('H', 2), Couleurs.Noir, Vecteur.DirectionsVerticales.Haut),

                new Tour(new Position('A', 8), Couleurs.Blanc, false),
                new Cavalier(new Position('B', 8), Couleurs.Blanc, false),
                new Fou(new Position('C', 8), Couleurs.Blanc, false),
                new Roi(new Position('D', 8), Couleurs.Blanc, false),
                new Reine(new Position('E', 8), Couleurs.Blanc, false),
                new Fou(new Position('F', 8), Couleurs.Blanc, false),
                new Cavalier(new Position('G', 8), Couleurs.Blanc, false),
                new Tour(new Position('H', 8), Couleurs.Blanc, false),
                new Pion(new Position('A', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('B', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('C', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('D', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('E', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('F', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('G', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
                new Pion(new Position('H', 7), Couleurs.Blanc, Vecteur.DirectionsVerticales.Bas, false),
            });

            _echiquierInitial = _echiquier.Cloner();
        }

        private void viaEchiquier_SpriteDragAndDropOccured(object sender, VisualArrays.SpriteDragAndDropEventArgs e)
        {
            bool deplacementValide = _joueurCourant.DeplacerPiece(
                 _echiquier[e.SourceAddress.Row, e.SourceAddress.Column],
                 new Position(e.DestinationAddress.Row, e.DestinationAddress.Column)
                 );

            if (deplacementValide)
            {
                _joueurCourant = _joueurCourant.Couleur == Couleurs.Blanc ? _joueurNoir : _joueurBlanc;
            }
        }

        private void itmAfficherBlancs_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Piece piece in (_echiquier.Pieces).Where(x => x.Couleur == Couleurs.Blanc && x.Mange == false))
            {
                piece.Visible = itmAfficherBlancs.Checked;
            }
            _echiquier.Rafraichir();
        }

        // À FAIRE
        private void itmReinitialiser_Click(object sender, EventArgs e)
        {
            _echiquier = _echiquierInitial;
            _echiquier.Rafraichir();
        }

        private void itmQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
