using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Compte
/// </summary>
public class Compte
{
    private int type_compte;
    private string libele_compte;

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

    public string Libele_compte
    {
        get
        {
            return libele_compte;
        }

        set
        {
            libele_compte = value;
        }
    }

    public Compte()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Compte(int type_compte, string libele_compte)
    {
        this.type_compte = type_compte;
        this.libele_compte = libele_compte;
    }
}