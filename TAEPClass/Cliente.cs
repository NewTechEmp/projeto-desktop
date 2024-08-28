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
        public string Cpf { get; set; }
        public List<Endereco> Enderecos{ get; set;}
        public List<Telefone> Telefones { get; set; }

        public Cliente() { }
        public Cliente(int id, Usuario usuario, DateTime dataNasc, string cpf, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, DateTime dataNasc, string cpf, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, DateTime dataNasc, string cpf)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        } 

        public Cliente(int id, Usuario usuario, DateTime dataNasc, string cpf)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public Cliente(DateTime dataNasc, string cpf)
        {
            DataNasc = dataNasc; 
            Cpf = cpf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spdata_nasc", DataNasc);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
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
                    dr.GetInt32(0),
                    Usuario.ObterPorId(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    Endereco.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))),
                    Telefone.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0)))
                  );
                  
            }

            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from vw_clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    Endereco.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))),
                    Telefone.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))
                    )
                ));
            }
            return clientes;
        }
    }
}
