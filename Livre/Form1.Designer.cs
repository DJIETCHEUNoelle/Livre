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
            Isbn = new Label();
            txbIsbn = new TextBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            SuspendLayout();
            // 
            // lblLivre
            // 
            lblLivre.FormattingEnabled = true;
            lblLivre.ItemHeight = 15;
            lblLivre.Location = new Point(708, 33);
            lblLivre.Margin = new Padding(3, 2, 3, 2);
            lblLivre.Name = "lblLivre";
            lblLivre.Size = new Size(338, 319);
            lblLivre.TabIndex = 0;
            lblLivre.SelectedIndexChanged += lblLivre_SelectedIndexChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(86, 278);
            btnAjouter.Margin = new Padding(3, 2, 3, 2);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(147, 28);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "AJOUTER Livres";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += button1_Click;
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(170, 45);
            txtTitre.Margin = new Padding(3, 2, 3, 2);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(110, 23);
            txtTitre.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(170, 131);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 3;
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Location = new Point(50, 42);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(31, 15);
            labelTitre.TabIndex = 4;
            labelTitre.Text = "Titre";
            // 
            // labelDecription
            // 
            labelDecription.AutoSize = true;
            labelDecription.Location = new Point(24, 134);
            labelDecription.Name = "labelDecription";
            labelDecription.Size = new Size(67, 15);
            labelDecription.TabIndex = 4;
            labelDecription.Text = "Description";
            // 
            // lblNomAuteur
            // 
            lblNomAuteur.AutoSize = true;
            lblNomAuteur.Location = new Point(39, 329);
            lblNomAuteur.Name = "lblNomAuteur";
            lblNomAuteur.Size = new Size(69, 15);
            lblNomAuteur.TabIndex = 4;
            lblNomAuteur.Text = "nom auteur";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(39, 422);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(52, 15);
            lblPrenom.TabIndex = 4;
            lblPrenom.Text = "Prenom ";
            lblPrenom.Click += lblPrenom_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 712);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Titre";
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.Location = new Point(194, 331);
            txtNomAuteur.Margin = new Padding(3, 2, 3, 2);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(110, 23);
            txtNomAuteur.TabIndex = 3;
            // 
            // txtNomLivre
            // 
            txtNomLivre.Location = new Point(194, 422);
            txtNomLivre.Margin = new Padding(3, 2, 3, 2);
            txtNomLivre.Name = "txtNomLivre";
            txtNomLivre.Size = new Size(110, 23);
            txtNomLivre.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 818);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Titre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 200);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Choisir Categorie";
            // 
            // cbCategorie
            // 
            cbCategorie.FormattingEnabled = true;
            cbCategorie.Location = new Point(158, 197);
            cbCategorie.Margin = new Padding(3, 2, 3, 2);
            cbCategorie.Name = "cbCategorie";
            cbCategorie.Size = new Size(133, 23);
            cbCategorie.TabIndex = 5;
            cbCategorie.SelectedIndexChanged += cbCategorie_SelectedIndexChanged;
            // 
            // Isbn
            // 
            Isbn.AutoSize = true;
            Isbn.Location = new Point(39, 101);
            Isbn.Name = "Isbn";
            Isbn.Size = new Size(32, 15);
            Isbn.TabIndex = 7;
            Isbn.Text = "ISBN";
            // 
            // txbIsbn
            // 
            txbIsbn.Location = new Point(170, 93);
            txbIsbn.Margin = new Padding(3, 2, 3, 2);
            txbIsbn.Name = "txbIsbn";
            txbIsbn.Size = new Size(110, 23);
            txbIsbn.TabIndex = 6;
            txbIsbn.TextChanged += textBox1_TextChanged;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(812, 423);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 8;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += button1_Click_1;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(358, 272);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 550);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(Isbn);
            Controls.Add(txbIsbn);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label Isbn;
        private TextBox txbIsbn;
        private Button btnSupprimer;
        private Button btnModifier;
    }
}
