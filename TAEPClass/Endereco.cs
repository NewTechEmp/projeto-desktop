using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public class Endereco
    {

        public int Id { get; set; }
        public string Cep { get; set; } 
        public bool Ativo { get; set; }
        public int ClienteId { get; set; }
        public int TipoEnderecoUId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }  
        public string Cidade { get; set; }  
        public string Uf {  get; set; }

        public Endereco(int id, string cep, bool ativo, int clienteId, int tipoEnderecoUId, string logradouro, string numero, string bairro, string cidade, string uf)
        {
            Id = id;
            Cep = cep;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecoUId = tipoEnderecoUId;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco(string cep, bool ativo, int clienteId, int tipoEnderecoUId, string logradouro, string numero, string bairro, string cidade, string uf)
        {
            Cep = cep;
            Ativo = ativo;
            ClienteId = clienteId;
            TipoEnderecoUId = tipoEnderecoUId;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public void Inserir()
        {

        }
        public bool Editar(int id)
        {

        }
        public static List<Endereco> ObterLista(int clienteId)
        {

        }
        public static Endereco ObterPorId(int id )
        {

        }
    }
}
