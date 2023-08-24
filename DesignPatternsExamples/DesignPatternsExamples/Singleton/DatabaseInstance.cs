using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Singleton;

public class DatabaseInstance
{
    private string port = "server1";
    private string server = "server1";
    private string host = "server1";
    private string ussername = "hola";
    private string password = "adios";
    private string connString = "";


    private static DatabaseInstance? instance = null;
    private DatabaseInstance() 
    {
        
    }

    public static DatabaseInstance getInstance()
    {
        if (instance == null)
        {
            instance = new DatabaseInstance();
        }
        return instance;
    }
}
