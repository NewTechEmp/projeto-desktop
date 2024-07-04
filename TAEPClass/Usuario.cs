using TAEPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public  class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }   
        public bool Ativo {  get; set; }    
        public Nivel NivelId {  get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string email, string senha, bool ativo, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            NivelId = nivelId;
        }

        public Usuario(string nome, string email, string senha, bool ativo, Nivel nivelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            NivelId = nivelId;
        }

        public Usuario (string nome, string email, string senha, Nivel nivelId )
        {
            Nome= nome;
            Email = email;
            Senha = senha;
            NivelId= nivelId;
        }
        public void Inserir()
        {

        }
        public bool Editar(int id)
        {
            return true;
        }
        public void ObterPorId(int id)
        {
            Usuario usuario = new();
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuario = new();
            return usuario;
        }
    }
}
