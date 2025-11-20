
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

        static string connectionString = "Server=localhost;database=Livres;uid=Livre;pwd=Livre;";

        public List<Livre> GetAllLivres()
        {
            List<Livre> livres = new List<Livre>();

            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("select ISBN, Titre, Description FROM livres", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livre newlivre = new Livre()
                            {
                                Id = (string)reader["ISBN"],
                                Titre = (string)reader["Titre"],
                                Description = (string)reader["Description"],

                            };

                            livres.Add(newlivre);
                        }
                    }
                }

                connection.Close();
            }

            return livres;
        }


        public void  AddLivres(Livre livre)
        {
           

            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("INSERT INTO livres (TITRE, Description) VALUES (@Titre , @Description)", connection))
                {
                    
                    command.Parameters.AddWithValue("@Titre", livre.Titre);
                    command.Parameters.AddWithValue("@Description", livre.Description);

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

        public void DeleteLivre(int ISBN)
        {
            using (MySqlConnection connection = new(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new("delete from Livre where ISBN = @ISBN", connection))
                {
                    command.Parameters.AddWithValue("ISBN", ISBN);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
