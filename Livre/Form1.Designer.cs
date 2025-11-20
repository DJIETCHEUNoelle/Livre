namespace Livre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLivre = new ListBox();
            btnAjouter = new Button();
            txtTitre = new TextBox();
            txtDescription = new TextBox();
            labelTitre = new Label();
            labelDecription = new Label();
            lblNomAuteur = new Label();
            lblPrenom = new Label();
            label3 = new Label();
            txtNomAuteur = new TextBox();
            txtNomLivre = new TextBox();
            label4 = new Label();
            label1 = new Label();
            cbCategorie = new ComboBox();
            SuspendLayout();
            // 
            // lblLivre
            // 
            lblLivre.FormattingEnabled = true;
            lblLivre.Location = new Point(809, 44);
            lblLivre.Name = "lblLivre";
            lblLivre.Size = new Size(386, 424);
            lblLivre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(98, 370);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "AJOUTER Livres";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += button1_Click;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(194, 60);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(125, 27);
            txtTitre.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(194, 175);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 3;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Location = new Point(57, 56);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(39, 20);
            labelTitre.TabIndex = 4;
            labelTitre.Text = "Titre";
            // 
            // labelDecription
            // 
            labelDecription.AutoSize = true;
            labelDecription.Location = new Point(11, 178);
            labelDecription.Name = "labelDecription";
            labelDecription.Size = new Size(85, 20);
            labelDecription.TabIndex = 4;
            labelDecription.Text = "Description";
            // 
            // lblNomAuteur
            // 
            lblNomAuteur.AutoSize = true;
            lblNomAuteur.Location = new Point(45, 439);
            lblNomAuteur.Name = "lblNomAuteur";
            lblNomAuteur.Size = new Size(85, 20);
            lblNomAuteur.TabIndex = 4;
            lblNomAuteur.Text = "nom auteur";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(45, 562);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(64, 20);
            lblPrenom.TabIndex = 4;
            lblPrenom.Text = "Prenom ";
            lblPrenom.Click += lblPrenom_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 949);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Titre";
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.Location = new Point(222, 441);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(125, 27);
            txtNomAuteur.TabIndex = 3;
            // 
            // txtNomLivre
            // 
            txtNomLivre.Location = new Point(222, 562);
            txtNomLivre.Name = "txtNomLivre";
            txtNomLivre.Size = new Size(125, 27);
            txtNomLivre.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 1090);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 4;
            label4.Text = "Titre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 263);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "Choisir Categorie";
            // 
            // cbCategorie
            // 
            cbCategorie.FormattingEnabled = true;
            cbCategorie.Location = new Point(181, 263);
            cbCategorie.Name = "cbCategorie";
            cbCategorie.Size = new Size(151, 28);
            cbCategorie.TabIndex = 5;
            cbCategorie.SelectedIndexChanged += cbCategorie_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 733);
            Controls.Add(cbCategorie);
            Controls.Add(label1);
            Controls.Add(labelDecription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblPrenom);
            Controls.Add(lblNomAuteur);
            Controls.Add(txtNomLivre);
            Controls.Add(labelTitre);
            Controls.Add(txtNomAuteur);
            Controls.Add(txtDescription);
            Controls.Add(txtTitre);
            Controls.Add(btnAjouter);
            Controls.Add(lblLivre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lblLivre;
        private Button btnAjouter;
        private TextBox txtTitre;
        private TextBox txtDescription;
        private Label labelTitre;
        private Label labelDecription;
        private Label lblNomAuteur;
        private Label lblPrenom;
        private Label label3;
        private TextBox txtNomAuteur;
        private TextBox txtNomLivre;
        private Label label4;
        private Label label1;
        private ComboBox cbCategorie;
    }
}
