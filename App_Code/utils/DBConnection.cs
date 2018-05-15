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
    private static List<Compte> comptes;
    private static List<Compte_client> compte_clients;
    private static List<Historique> histories;
    private static List<Transaction> transactions;
    private static List<Client> clients;


    public DBConnection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool initConnection()
    {
       
        try
        {
            string stringConn = System.Configuration.ConfigurationManager.ConnectionStrings["BankConnection"].ToString();
            connection = new MySqlConnection(stringConn);
            connection.Open();
            return true;
        }
        catch (Exception e) {
            string error = e.StackTrace;
            string error2 = e.Message;
            return false;
        }
    }

    public static bool loadClientsAccounts() {
        try
        {
            query = "SELECT * FROM `compte_client`";
            command = new MySqlCommand(query, connection);
            command.ExecuteReader();

            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }
        
    }

    public static bool loadAccountTypes()
    {
        try
        {
            comptes = new List<Compte>();
            query = "SELECT * FROM `compte`";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                Compte c = new Compte();
                c.Type_compte = reader.GetInt16(reader.GetOrdinal("type_compte"));
                c.Libele_compte = reader.GetString(reader.GetOrdinal("libele_compte"));
                comptes.Add(c);
            }

            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }

    }

    public static bool loadTransactionType()
    {
        try
        {
            query = "SELECT * FROM `transaction`";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();

            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }

    }

    public static bool loadClientsList()
    {
        try
        {
            query = "SELECT * FROM `client`";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();

            connection.Close();
            return true;
        }
        catch (Exception e)
        {
            string error = e.StackTrace;
            string error2 = e.Message;
            connection.Close();
            return false;
        }

    }
}