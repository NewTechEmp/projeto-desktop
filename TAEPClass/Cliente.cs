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
        public string Nome { get; set; }   
        public DateTime DataNasc { get; set; }
        public string Cpf {  get; set; }
        public string Email { get; set; }   
        public string Senha {  get; set; }
        public DateTime DataCad {  get; set; }
        public bool Ativo {  get; set; }
        public List<Endereco> Enderecos{ get; set;}
        public List<Telefone> Telefones { get; set; }

        public Cliente(){}
        public Cliente(int id, string nome, DateTime dataNasc, string cpf, string email, string senha, DateTime datacad, bool ativo, List<Endereco> endereco, List<Telefone> telefone)
        {
            Id = id;
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            DataCad = datacad;
            Ativo = ativo;
            Enderecos = endereco;
            Telefones = telefone;
        }

        public Cliente(string nome, DateTime dataNasc, string cpf, string email, string senha, DateTime datacad, bool ativo, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            DataCad = datacad;
            Ativo = ativo;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefones);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("sptelefone", Telefones);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Deletar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
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
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Endereco.ObterListaPorCliente(dr.GetInt32(0)),
                    Telefone.ObterListaPorCliente(dr.GetInt32(0))
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
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Endereco.ObterListaPorCliente(dr.GetInt32(0)),
                    Telefone.ObterListaPorCliente(dr.GetInt32(0))
                    )
                );
            }
            return clientes;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad);
        }
    }
}
