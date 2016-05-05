namespace JeuEchec
{
    partial class frmEchiquier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEchiquier));
            this.viaEchiquier = new VisualArrays.VisualIntArray();
            this.imlCases = new System.Windows.Forms.ImageList(this.components);
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuPartie = new System.Windows.Forms.ToolStripMenuItem();
            this.itmReinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.itmQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAfficherBlancs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // viaEchiquier
            // 
            this.viaEchiquier.AllowDrag = true;
            this.viaEchiquier.AllowDrop = true;
            this.viaEchiquier.AllowSelfDrop = true;
            this.viaEchiquier.BackColor = System.Drawing.Color.Black;
            this.viaEchiquier.CellAppearance.Border = new System.Windows.Forms.Padding(0);
            this.viaEchiquier.CellAppearance.ImageList = this.imlCases;
            this.viaEchiquier.CellMargin = 0;
            this.viaEchiquier.CellSize = new System.Drawing.Size(80, 80);
            this.viaEchiquier.ColumnCount = 8;
            this.viaEchiquier.GridAppearance.LineSize = 0;
            this.viaEchiquier.Location = new System.Drawing.Point(12, 30);
            this.viaEchiquier.Name = "viaEchiquier";
            this.viaEchiquier.RowCount = 8;
            this.viaEchiquier.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaEchiquier.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.viaEchiquier.Size = new System.Drawing.Size(644, 644);
            this.viaEchiquier.TabIndex = 0;
            this.viaEchiquier.View = VisualArrays.enuIntView.ImageList;
            this.viaEchiquier.SpriteDragAndDropOccured += new System.EventHandler<VisualArrays.SpriteDragAndDropEventArgs>(this.viaEchiquier_SpriteDragAndDropOccured);
            // 
            // imlCases
            // 
            this.imlCases.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCases.ImageStream")));
            this.imlCases.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCases.Images.SetKeyName(0, "case_blanche.png");
            this.imlCases.Images.SetKeyName(1, "case_noir.png");
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPartie,
            this.mnuOptions});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Size = new System.Drawing.Size(669, 24);
            this.mnuGeneral.TabIndex = 1;
            this.mnuGeneral.Text = "menuStrip1";
            // 
            // mnuPartie
            // 
            this.mnuPartie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmReinitialiser,
            this.itmQuitter});
            this.mnuPartie.Name = "mnuPartie";
            this.mnuPartie.Size = new System.Drawing.Size(49, 20);
            this.mnuPartie.Text = "Partie";
            // 
            // itmReinitialiser
            // 
            this.itmReinitialiser.Name = "itmReinitialiser";
            this.itmReinitialiser.Size = new System.Drawing.Size(134, 22);
            this.itmReinitialiser.Text = "Réinitialiser";
            // 
            // itmQuitter
            // 
            this.itmQuitter.Name = "itmQuitter";
            this.itmQuitter.Size = new System.Drawing.Size(134, 22);
            this.itmQuitter.Text = "Quitter";
            this.itmQuitter.Click += new System.EventHandler(this.itmQuitter_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAfficherBlancs});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // itmAfficherBlancs
            // 
            this.itmAfficherBlancs.CheckOnClick = true;
            this.itmAfficherBlancs.Name = "itmAfficherBlancs";
            this.itmAfficherBlancs.Size = new System.Drawing.Size(170, 22);
            this.itmAfficherBlancs.Text = "Afficher les blancs";
            this.itmAfficherBlancs.Click += new System.EventHandler(this.itmAfficherBlancs_Click);
            // 
            // frmEchiquier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 686);
            this.Controls.Add(this.viaEchiquier);
            this.Controls.Add(this.mnuGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnuGeneral;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEchiquier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu d\'échec - déplacement de pièces";
            this.Load += new System.EventHandler(this.frmEchiquier_Load);
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualArrays.VisualIntArray viaEchiquier;
        private System.Windows.Forms.ImageList imlCases;
        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuPartie;
        private System.Windows.Forms.ToolStripMenuItem itmReinitialiser;
        private System.Windows.Forms.ToolStripMenuItem itmQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem itmAfficherBlancs;
    }
}

