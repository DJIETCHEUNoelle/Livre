namespace Livre
{
    public partial class Form1 : Form
    {
        ConnexionMySql connection;
        public Form1()
        {
            InitializeComponent();
            connection = new();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNomLivre.Text;
            string ISBN = txbIsbn.Text;
            string description = txtDescription.Text;
            int categorie = (int)cbCategorie.SelectedValue;

            if (nom== null && ISBN ==null && description ==null && categorie == null)
            {
                MessageBox.Show("entrez toutes les informations");
            }
           
                Livre livreAjoute = new Livre(nom, ISBN, categorie, description);
                connection.AddLivres(livreAjoute);
                MessageBox.Show("Livres ajouter avec succee");
        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        public void RefreshCategory()
        {
            cbCategorie.Items.Clear();
            List<Categorie> categories = connection.GetAllCategorie();

            cbCategorie.DataSource = categories;
            cbCategorie.DisplayMember = "Nom_Categorie";
            cbCategorie.ValueMember = "Id";
        }

        public void RefreshLivre()
         {List<Livre> livres = connection.GetAllLivres();
            lblLivre.Items.Clear();

            foreach (var item in livres)
            {
                lblLivre.Items.Add(item);
            }

            
            
           // lblLivre.DataSource = null;
           // lblLivre.DataSource = livres;
           // lblLivre.DisplayMember = "Titre";

        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            RefreshCategory();
            RefreshLivre();

        }

        private void lblLivre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lblLivre.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un livre à supprimer.");
                return;
            }

            Livre livre = (Livre)(lblLivre.SelectedItem);

            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le livre : {livre.Titre} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    connection.DeleteLivre(livre.Id);
                    RefreshLivre();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lblLivre.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un livre à modifier.");
                return;
            }

            Livre livre = (Livre)lblLivre.SelectedItem;


            livre.Titre = txtNomLivre.Text;
            livre.Isbn = txbIsbn.Text;
            livre.Description = txtDescription.Text;
            livre.IdCategorie = (int)cbCategorie.SelectedValue;

            
            DialogResult confirm = MessageBox.Show(
                $"Voulez-vous vraiment modifier le livre : {livre.Titre} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    connection.UpdateLivre(livre);  
                    RefreshLivre();                 
                    MessageBox.Show("Livre modifié avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }
        }
    }
}
