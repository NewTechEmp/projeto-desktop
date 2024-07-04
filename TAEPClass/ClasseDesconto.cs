using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    internal class ClasseDesconto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public ClasseDesconto() { }
        public ClasseDesconto(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public ClasseDesconto(int id, string descricao, string sigla, bool ativo)
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
            cmd.CommandText = "sp_classedesconto_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_classedesconto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_classedesconto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<ClasseDesconto> ObterLista()
        {
            List<ClasseDesconto> classeDesconto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from classedesconto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classeDesconto.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return classeDesconto;
        }
        public static ClasseDesconto ObterPorId(int id)
        {
            ClasseDesconto classeDesconto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from classedesconto where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classeDesconto.Id = dr.GetInt32(0);
                classeDesconto.Descricao = dr.GetString(1);
                classeDesconto.Sigla = dr.GetString(2);
                classeDesconto.Ativo = dr.GetBoolean(3);
            }
            return classeDesconto;
        }
    }
}
