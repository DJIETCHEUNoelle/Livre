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

            Livre livreAjoute = new Livre(nom, description);

            connection.AddLivres(livreAjoute);
            

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        public void RefreshCategory()
        {
            cbCategorie.Items.Clear();
            List<Categorie> categories = connection.GetAllCategorie();

            foreach (Categorie categorie in categories)
            {
                cbCategorie.Items.Add(categorie);
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {   
            
            RefreshCategory();
            
        }
    }
}
