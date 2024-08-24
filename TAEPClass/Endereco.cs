using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Endereco
    {

        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }  
        public string Cidade { get; set; }  
        public string Uf {  get; set; }
        public bool Ativo { get; set; }
        public int ClienteId { get; set; }
        public TipoEndereco TipoEnderecos { get; set; }

        public Endereco() { }
        public Endereco(int id) 
        {
            Id = id;
        }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, bool ativo, int clienteId, TipoEndereco tipoEnderecos)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, bool ativo, int clienteId, TipoEndereco tipoEnderecos)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, int clienteId, TipoEndereco tipoEnderecos)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            ClienteId = clienteId;
            TipoEnderecos = tipoEnderecos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_insert";
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            cmd.Parameters.AddWithValue("sptipo_endereco_id", TipoEnderecos.Id);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spemail_cliente", ClienteId);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEnderecos.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Deletar(int id, bool ativo) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetBoolean(8),
                        dr.GetInt32(9),
                        TipoEndereco.ObterPorId(dr.GetInt32(10))
                    );
            }
            return endereco;
        }
        public static List<Endereco> ObterListaPorCliente(int clienteId)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM enderecos WHERE cliente_id = {clienteId}";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(
                    new Endereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetBoolean(8),
                        dr.GetInt32(9),
                        TipoEndereco.ObterPorId(dr.GetInt32(10))
                        )
                    );
            }
            
            return enderecos;
        }
    }
}
