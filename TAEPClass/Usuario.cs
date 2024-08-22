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
        public DateTime DataCad {  get; set; }
        public bool Ativo {  get; set; }    
        public Nivel Nivel {  get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string email, string senha, DateTime dataCad, bool ativo, Nivel nivelId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCad = dataCad;
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

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public void Inserir()
        {
            string senhaCriptografada = CriptografarSenha(Senha);
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", senhaCriptografada);
            cmd.Parameters.AddWithValue("spniveis_id", Nivel.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
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
                cmd.Parameters.AddWithValue("spemail", Email);
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
                              dr.GetDateTime(4),
                              dr.GetBoolean(5),
                              Nivel.ObterPorId(dr.GetInt32(6))
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
                                        dr.GetDateTime(4),
                                        dr.GetBoolean(5),
                                        Nivel.ObterPorId((6))
                                     )
                         );
            }
            return lista;
        }
        public static Usuario? EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email}' and ativo = 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Senha = dr.GetString(3);
                usuario.DataCad = dr.GetDateTime(4);
                usuario.Ativo = dr.GetBoolean(5);
                usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(6)));
            }
            string hashPass = usuario.Senha;
            if (!VerificarSenha(senha, hashPass))
            {    
                return null;
            }
            else
            {
                return usuario;
            }
        }
        public string CriptografarSenha(string senha)
        {
            string salt = BCryptNet.GenerateSalt(10);
            string CripSenha = BCryptNet.HashPassword(senha,salt);
            return CripSenha;
        }
        private static bool VerificarSenha(string senha,string hashPass)
        {
            return BCryptNet.Verify(senha, hashPass);

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad, Nivel.Sigla, Email);
        }
    }
}