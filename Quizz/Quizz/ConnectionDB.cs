using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Quizz
{
    class DataBase
    {
        private MySqlConnection connection;

        // Constructeur
        public DataBase()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=football; UID=Florian; PASSWORD=Pa$$w0rd";
            this.connection = new MySqlConnection(connectionString);
        }

        public void AddPlayer(QuestionQuizz player)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO Players (FirstName, LastName, TelNumber) VALUES (@FirstName, @LastName, @TelNumber)";

                // utilisation de l'objet contact passé en paramètre
                //cmd.Parameters.AddWithValue("@FirstName", player.FirstName);
                //cmd.Parameters.AddWithValue("@LastName", player.LastName);
                //cmd.Parameters.AddWithValue("@TelNumber", player.Number);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }
            catch
            {

                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }
    }
}
