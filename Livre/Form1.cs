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
            string description = txtDescription.Text;
            int categorie = (int)cbCategorie.SelectedValue;


            Livre livreAjoute = new Livre(nom, categorie, description
                );

            connection.AddLivres(livreAjoute);


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
        {
            lblLivre.Items.Clear(); 
            List<Livre> livres = connection.GetAllLivres();

            lblLivre.DataSource = livres;
            
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
    }
}
