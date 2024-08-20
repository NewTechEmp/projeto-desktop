using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using TAEPClass;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;
using System.Security.Cryptography.X509Certificates;


public static class Banco
{
 
    private static string strconn = @"server=127.0.0.1;database=Tudo_Acaba_em_Pizza_DB;user id=root;password=";
    
    public static string caminho = System.Environment.CurrentDirectory;
   
    public static string caminhoFotos = caminho+@"\fotos\";  // Substitua por um caminho válido

    public static MySqlCommand Abrir()
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn = new MySqlConnection(strconn);
        try
        {
            cn.Open();
            cmd.Connection = cn;
        }
        catch (Exception)
        {
            throw;
        }
        return cmd;
    }
}