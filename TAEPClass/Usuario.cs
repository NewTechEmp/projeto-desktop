using TAEPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data;

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
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spniveis_id", NivelId);
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha );
            cmd.Parameters.AddWithValue("spniveis_id", NivelId);

            return true;
        }
        public void ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4),
                    Nivel.ObterPorId(dr.GetInt32(5))
                    );
            }
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4),
                    Nivel.ObterPorId(dr.GetInt32(5))

                    ));
            }

            return usuario;
        }
    }
}
