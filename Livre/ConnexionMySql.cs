
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Livre
{
    internal class ConnexionMySql
    {

        static string connectionString = "Server=localhost;Database=livres;Uid=livres;Pwd=livres;";


        public List<Livre> GetAllLivres()
        {
            List<Livre> livres = new List<Livre>();

            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("SELECT Id_Book, ISBN, Titre, Description, Id_Categorie FROM Book", connection))

                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livre newlivre = new Livre()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id_Book")),
                                Titre = reader.GetString(reader.GetOrdinal("Titre")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                            };

                            livres.Add(newlivre);
                        }
                    }
                }

                connection.Close();
            }

            return livres;
        }
        public void UpdateLivre(Livre livre)
        {
            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Book 
                         SET Titre = @Titre, 
                             ISBN = @ISBN,
                             Description = @Description,
                             Id_Categorie = @IdCategorie
                         WHERE Id_Book = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titre", livre.Titre);
                    command.Parameters.AddWithValue("@ISBN", livre.Isbn);
                    command.Parameters.AddWithValue("@Description", livre.Description);
                    command.Parameters.AddWithValue("@IdCategorie", livre.IdCategorie);
                    command.Parameters.AddWithValue("@Id", livre.Id);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddLivres(Livre livre)
        {
            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Book (Titre, ISBN, Description, Id_Categorie)
                         VALUES (@Titre, @ISBN, @Description, @IdCategorie)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Titre", livre.Titre);
                    cmd.Parameters.AddWithValue("@ISBN", livre.Isbn);
                    cmd.Parameters.AddWithValue("@Description", livre.Description);
                    cmd.Parameters.AddWithValue("@IdCategorie", livre.IdCategorie);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateLivres(Livre livre)
        {
            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                string query = @"UPDATE livres 
                         SET Titre = @Titre, 
                             Description = @Description,
                             ID_Categorie = @ID_Categorie
                         WHERE ID_Livre = @ID_Livre";

                using (MySqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Titre", livre.Titre);
                    command.Parameters.AddWithValue("@Description", livre.Description);
                    command.Parameters.AddWithValue("@ID_Categorie", livre.IdCategorie);
                    command.Parameters.AddWithValue("@ID_Livre", livre.Id);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

      



        public List<Categorie> GetAllCategorie()
        {
            List<Categorie> categories = new List<Categorie>();

            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("select Id_Categorie, Nom_Categorie FROM CATEGORY", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categorie newCategorie = new Categorie()
                            {
                                Id = (int)reader["Id_Categorie"],
                                Nom_Categorie = (string)reader["Nom_Categorie"],    

                            };

                            categories.Add(newCategorie);
                        }
                    }
                }

                connection.Close();
            }

            return categories;
        }

        public bool CategoryCanBeDeleted(int id_category)
        {
            bool canBeDeleted = false;

            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("select count(*) " +
                    "                               from categories.non=m " +
                    "                               where Id_categorie = @id or id_ctegorie = @id_categorie;", connection))
                {
                    command.Parameters.AddWithValue("id_categorie", id_category);
                    if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                        canBeDeleted = true;
                }

                connection.Close();
            }

            return canBeDeleted;
        }

        public void DeleteLivre(int Id_Book)
        {
            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("delete from book where Id_Book = @Id_Book", connection))
                {
                    command.Parameters.AddWithValue("Id_Book", Id_Book);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
