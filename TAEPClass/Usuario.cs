using TAEPClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BCryptNet = BCrypt.Net.BCrypt;

namespace TAEPClass
{
    public  class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }   
        public bool Ativo {  get; set; }    
        public Nivel Nivel {  get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string email, string senha, bool ativo, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            Nivel = nivelId;
        }

        public Usuario(string nome, string email, string senha, bool ativo, Nivel nivelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
            Nivel = nivelId;
        }

        public Usuario (string nome, string email, string senha, Nivel nivelId )
        {
            Nome= nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
        }
        public void Inserir()
        {
            CriptografarSenha(Senha);
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery();
        }
        public bool Editar(int id, string senhaConfirmar)
        {
            bool resultado = false;
            if (senhaConfirmar == Senha)
            {
                CriptografarSenha(Senha);
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_usuario_update";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsenha", Senha);
                cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
                try
                {
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return resultado;
        }
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id={id}";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuario = new(dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetString(3),
                              dr.GetBoolean(4),
                              Nivel.ObterPorId(dr.GetInt32(5))
                             );
            }
            return usuario;
        }
        public static List<Usuario> ObterLista(string nome = null)
        {
            // listar o usuario
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == null)
            {
                cmd.CommandText = "select * from usuarios order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from usuarios where nome like '%{nome}%' order by nome";
            }


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                                        dr.GetInt32(0),
                                        dr.GetString(1),
                                        dr.GetString(2),
                                        dr.GetString(3),
                                        dr.GetBoolean(4),
                                        Nivel.ObterPorId((5))
                                     )
                         );
            }
            return lista;
        }
        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            if (usuario.VerificarSenha(senha))
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = '{senha}' and ativo = 1";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usuario.Id = dr.GetInt32(0);
                    usuario.Nome = dr.GetString(1);
                    usuario.Email = dr.GetString(2);
                    usuario.Senha = dr.GetString(3);
                    usuario.Ativo = dr.GetBoolean(4);
                    usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(5)));
                }
                return usuario;
            }
            else
            {
                return null;
            }
        }
        private void CriptografarSenha(string senha)
        {
            string salt = BCryptNet.GenerateSalt(10);
            senha = BCryptNet.HashPassword(Senha,salt);
        }
        private bool VerificarSenha(string senha)
        {
            return BCryptNet.Verify(senha,Senha);
        }
    }
}