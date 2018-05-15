using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Client
/// </summary>
public class Client
{
    private string nom;
    private string prenom;
    private string sexe;
    private int nif;
    private int cin;
    private string addresse;
    private string telephone;

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

    public string Sexe
    {
        get
        {
            return sexe;
        }

        set
        {
            sexe = value;
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

    public int Cin
    {
        get
        {
            return cin;
        }

        set
        {
            cin = value;
        }
    }

    public string Addresse
    {
        get
        {
            return addresse;
        }

        set
        {
            addresse = value;
        }
    }

    public string Telephone
    {
        get
        {
            return telephone;
        }

        set
        {
            telephone = value;
        }
    }

    public Client()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Client(string nom, string prenom, string sexe, int nif, int cin, string addresse, string telephone)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.sexe = sexe;
        this.nif = nif;
        this.cin = cin;
        this.addresse = addresse;
        this.telephone = telephone;
    }
}