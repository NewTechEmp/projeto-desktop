using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Cliente
    {
        

        public int Id { get; set; }   
        public Usuario Usuario { get; set; }   
        public DateTime DataNasc { get; set; }
        public string Cpf {  get; set; }
     

        public Cliente(){}

        public Cliente(int id, Usuario usuario, DateTime dataNasc, string cpf)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public Cliente(Usuario usuario, DateTime dataNasc, string cpf)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spusuario_id",Usuario);
            cmd.Parameters.AddWithValue("spdata_nasc",DataNasc);
            cmd.Parameters.AddWithValue("spcpf",Cpf);


            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new(

                    Usuario.ObterPorId(dr.GetInt32(0))
                    , dr.GetDateTime(1)
                    ,dr.GetString(3)
                   );
                  
            }

            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(
                    new(
                     Usuario.ObterPorId(dr.GetInt32(0))
                    , dr.GetDateTime(1)
                    , dr.GetString(3)
                    )
                );
            }
            return clientes;
        }
       
    }
}
