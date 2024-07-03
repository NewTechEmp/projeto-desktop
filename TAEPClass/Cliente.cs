using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime Datacad {  get; set; }
        public bool Ativo {  get; set; }
        public List<Endereco> Enderecos{ get; set;}
        public List<Telefone> Telefones { get; set; }

        public Cliente(int id, string nome, DateTime dataNasc, string cpf, string email, string senha, DateTime datacad, bool ativo, List<Endereco> endereco, List<Telefone> telefone)
        {
            Id = id;
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Datacad = datacad;
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
            Datacad = datacad;
            Ativo = ativo;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public void Inserir()
        {

        }

        public bool Editar(int id)
        {
            return false;
        }
        public static Cliente ObterPorId(int id)
        {

        }

        public static List<Cliente> ObterLista(int id)
        {

        }
    }
}
