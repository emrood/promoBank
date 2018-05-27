using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Historique
/// </summary>
public class Historique
{
    private int ID;
    private int no_compte;
    private float montant;
    private DateTime date_transaction;
    private int type_transaction;

    public int Id
    {
        get
        {
            return ID;
        }

        set
        {
            ID = value;
        }
    }

    public int No_compte
    {
        get
        {
            return no_compte;
        }

        set
        {
            no_compte = value;
        }
    }

    public float Montant
    {
        get
        {
            return montant;
        }

        set
        {
            montant = value;
        }
    }

    public DateTime Date_transaction
    {
        get
        {
            return date_transaction;
        }

        set
        {
            date_transaction = value;
        }
    }

    public int Type_transaction
    {
        get
        {
            return type_transaction;
        }

        set
        {
            type_transaction = value;
        }
    }

    public Historique()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Historique(int id, int no_compte, float montant, DateTime date_transaction, int type_transaction)
    {
        ID = id;
        this.no_compte = no_compte;
        this.montant = montant;
        this.date_transaction = date_transaction;
        this.type_transaction = type_transaction;
    }

    public Historique(int no_compte, float montant, DateTime date_transaction, int type_transaction)
    {
        this.no_compte = no_compte;
        this.montant = montant;
        this.date_transaction = date_transaction;
        this.type_transaction = type_transaction;
    }
}