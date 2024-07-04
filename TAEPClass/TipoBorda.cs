using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    internal class TipoBorda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public TipoBorda() { }
        public TipoBorda(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public TipoBorda(int id, string descricao, string sigla, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Sigla = sigla;
            Ativo = ativo;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoborda_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoborda_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoborda_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<TipoBorda> ObterLista()
        {
            List<TipoBorda> tipoBorda = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipoborda";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoBorda.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return tipoBorda;
        }
        public static TipoBorda ObterPorId(int id)
        {
            TipoBorda tipoBorda = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipoborda where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoBorda.Id = dr.GetInt32(0);
                tipoBorda.Descricao = dr.GetString(1);
                tipoBorda.Sigla = dr.GetString(2);
                tipoBorda.Ativo = dr.GetBoolean(3);
            }
            return tipoBorda;
        }
    }
}
