using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Transaction
/// </summary>
public class Transaction
{

    private int type_transaction;
    private string libele_transaction;

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

    public string Libele_transaction
    {
        get
        {
            return libele_transaction;
        }

        set
        {
            libele_transaction = value;
        }
    }

    public Transaction()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Transaction(int type_transaction, string libele_transaction)
    {
        this.type_transaction = type_transaction;
        this.libele_transaction = libele_transaction;
    }

    public Transaction(string libele_transaction)
    {
        this.libele_transaction = libele_transaction;
    }
}