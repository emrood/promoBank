using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClientHistory
/// </summary>
public class ClientHistory
{

    private string nom;
    private string prenom;
    private string libele;
    private float montant;
    private long nif;
    private DateTime date;

    public string Nom
    {
        get
        {
            return nom;
        }

        set
        {
            nom = value;
        }
    }

    public string Prenom
    {
        get
        {
            return prenom;
        }

        set
        {
            prenom = value;
        }
    }

    public string Libele
    {
        get
        {
            return libele;
        }

        set
        {
            libele = value;
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

    public long Nif
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

    public ClientHistory()
    {
        //
        // TODO: Add constructor logic here
        //
    }




}