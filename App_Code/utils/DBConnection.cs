using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
//using MySql;

/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    private static MySqlConnection connection;
    private static MySqlCommand command;
    private static MySqlDataReader reader;
    private static String query;
    public static List<Compte> comptes;
    public static List<Compte_client> compte_clients;
    public static List<Historique> histories;
    public static List<Transaction> transactions;
    public static List<Client> clients;
    public static int last_nif;
    private static float temp_solde;
    private static int temp_no_compte;
    private static float final_amount;


    public DBConnection()
    {
        //
        // 
        //
    }

    public static bool initConnection()
    {
       
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            string stringConn = System.Configuration.ConfigurationManager.ConnectionStrings["BankConnection"].ToString();
            //connection = new MySqlConnection(stringConn);
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            return true;
        }
        catch (MySqlException e) {
            string error = e.StackTrace;
            string error2 = e.Message;
            return false;
        }
    }

    // Methode retournant la liste des comptes
    public static bool loadClientsAccounts() {
        compte_clients = new List<Compte_client>();
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            query = "SELECT * FROM `compte_client`";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                Compte_client cc = new Compte_client();
                cc.No_compte = reader.GetInt16(reader.GetOrdinal("no_compte"));
                cc.Nif = reader.GetInt32(reader.GetOrdinal("nif"));
                cc.Solde = reader.GetFloat(reader.GetOrdinal("solde"));
                cc.Type_compte = reader.GetInt16(reader.GetOrdinal("type_compte"));
                cc.Date = reader.GetDateTime(reader.GetOrdinal("date_creation"));
                compte_clients.Add(cc);
            }

            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }
        
    }

    public static bool loadAccountTypes()
    {
        comptes = new List<Compte>();
        query = "SELECT * FROM `compte`";
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                Compte c = new Compte();
                c.Type_compte = reader.GetInt16(reader.GetOrdinal("type_compte"));
                c.Libele_compte = reader.GetString(reader.GetOrdinal("libelle_compte"));
                comptes.Add(c);
            }

            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }

    }

    //Methode retournant la liste des types de transaction
    public static bool loadTransactionType()
    {
        transactions = new List<Transaction>();
        query = "SELECT * FROM `transaction`";
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                Transaction t = new Transaction();
                t.Libele_transaction = reader.GetString(reader.GetOrdinal("libele_transaction"));
                t.Type_transaction = reader.GetInt16(reader.GetOrdinal("type_transaction"));
                transactions.Add(t);
            }
            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            string error = e.Message;
            connection.Close();
            return false;
        }

    }

    //Methode retournant la liste des clients
    public static bool loadClientsList()
    {
        clients = new List<Client>();
        query = "SELECT * FROM `client`";
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while(reader.HasRows && reader.Read())
            {
                Client c = new Client();
                c.Addresse = reader.GetString(reader.GetOrdinal("adresse"));
                c.Cin = reader.GetInt32(reader.GetOrdinal("cin"));
                c.Nif = reader.GetInt32(reader.GetOrdinal("nif"));
                c.Nom = reader.GetString(reader.GetOrdinal("nom"));
                c.Prenom = reader.GetString(reader.GetOrdinal("prenom"));
                c.Sexe = reader.GetString(reader.GetOrdinal("sexe"));
                c.Telephone = reader.GetString(reader.GetOrdinal("telephone"));
                clients.Add(c);

            }
            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }

    }

    //Methode pour enregistrer un client
    public static bool registerClient(string nom, string prenom, string sexe, int nif, int cin, string adresse, string telephone)
    {
        query = "INSERT INTO `client`(nom, prenom, sexe, nif, cin, adresse, telephone) VALUES('"+nom+"','" +prenom +"','"+sexe+"',"+nif+ ","+cin+ ",'"+adresse+"','"+telephone+"')";
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            command = new MySqlCommand(query, connection);
            command.ExecuteReader();
            connection.Close();
            return true;
        }  
        catch (MySqlException e) {
            String message = e.Message;

            return false;
        }
    }

    // Methode pour enregistrer uun compte
    public static bool registerAccount(int nif, int type, float solde, DateTime date) {     
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            query = "INSERT INTO `compte_client`(nif, type_compte, solde, date_creation) VALUES("+nif+","+type+","+solde+",'2018-05-09')";
            command = new MySqlCommand(query, connection);
            command.ExecuteReader();
            connection.Close();
            return true;
        }   
        catch (MySqlException e)
        {
            String message = e.Message;
            return false;
        }

        
    }


    // Methode pour faire un depot
    public static bool deposit(int compte, float amount)
    {
        
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            query = "SELECT solde FROM `compte_client` WHERE no_compte = " + compte; 
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                temp_solde = reader.GetFloat(reader.GetOrdinal("solde"));
            }

            connection.Close();
            connection.Open();
            if (amount > 0) {
                //Transaction
                final_amount = amount + temp_solde;
                query = "UPDATE `compte_client` SET solde = " + final_amount + " WHERE no_compte="+compte+";";
                command = new MySqlCommand(query, connection);
                command.ExecuteReader();
                // Enregistrement de l'historique
                connection.Close();
                connection.Open();
                query = "INSERT INTO `historique`(no_compte, montant, date_transaction, type_transaction) VALUES (" + compte + "," + amount + ",'2018-08-09', 1)";
                command = new MySqlCommand(query, connection);
                command.ExecuteReader();
            }
           
            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            String message = e.Message;
            return false;
        }


    }

    // Methode pour faire un retrait
    public static bool whitDrawal(int compte, float amount)
    {
        try
        {
            connection = new MySqlConnection(@"Data Source=localhost;port=3309;Initial Catalog=mybank;User Id=root;password=''");
            connection.Open();
            query = "SELECT solde FROM `compte_client` WHERE no_compte = " + compte;
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                temp_solde = reader.GetFloat(reader.GetOrdinal("solde"));
                
            }
  
            connection.Close();
            connection.Open();
            if (temp_solde > amount)
            {
                final_amount = temp_solde - amount;
                // retrait
                query = "UPDATE `compte_client` SET solde = " + final_amount + " WHERE no_compte = " + compte;
                command = new MySqlCommand(query, connection);
                command.ExecuteReader();
                connection.Close();
                connection.Open();
                // enregistrement de l'historique
                query = "INSERT INTO `historique`(no_compte, montant, date_transaction, type_transaction) VALUES ("+ compte +","+ amount +",'2018-08-09', 2)";
                command = new MySqlCommand(query, connection);
                command.ExecuteReader();
            }

            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            String message = e.Message;
            return false;
        }
    }

   


}