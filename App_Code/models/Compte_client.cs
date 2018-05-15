using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Compte_client
/// </summary>
public class Compte_client
{
    private int no_compte;
    private int nif;
    private int type_compte;
    private float solde;
    private DateTime date;

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

    public int Nif
    {
        get
        {
            return nif;
        }

        set
        {
            nif = value;
        }
    }

    public int Type_compte
    {
        get
        {
            return type_compte;
        }

        set
        {
            type_compte = value;
        }
    }

    public float Solde
    {
        get
        {
            return solde;
        }

        set
        {
            solde = value;
        }
    }

    public DateTime Date
    {
        get
        {
            return date;
        }

        set
        {
            date = value;
        }
    }

    public Compte_client()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Compte_client(int no_compte, int nif, int type_compte, float solde, DateTime date)
    {
        this.no_compte = no_compte;
        this.nif = nif;
        this.type_compte = type_compte;
        this.solde = solde;
        this.date = date;
    }
}