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
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
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
        public static Usuario EfetuarLogin(string email, string senha)
        {
            int nivelId = 0;
            //recuperando id do nivel cliente
            using (var cmdNivel = Banco.Abrir())
            { 
                string comandoNivel = "SELECT id FROM niveis WHERE descricao = 'cliente'";
                cmdNivel.CommandType = CommandType.Text;
                cmdNivel.CommandText = comandoNivel;
                nivelId = Convert.ToInt32(cmdNivel.ExecuteScalar());
            }
            // recuperando usuario
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM usuarios WHERE email = @email AND ativo = 1 AND nivel_id != @nivelId";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nivelId", nivelId);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        var usuario = new Usuario
                        {
                            Id = dr.GetInt32(0),
                            Nome = dr.GetString(1),
                            Email = dr.GetString(2),
                            Senha = dr.GetString(3),
                            DataCad = dr.GetDateTime(4),
                            Ativo = dr.GetBoolean(5),
                            Nivel = Nivel.ObterPorId(Convert.ToInt32(dr.GetInt32(6)))
                        };

                        if (VerificarSenha(senha, usuario.Senha))
                        {
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
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