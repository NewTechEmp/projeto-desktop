using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TAEPClass;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    public class TipoBorda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public TipoBorda() { }
        public TipoBorda(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
           
        }
        public TipoBorda(int id, string descricao, double valor, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Ativo = ativo;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoborda_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppreco", Valor);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoborda_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("sppreco", Valor);
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
            cmd.CommandText = "select * from tipos_borda";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoBorda.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetDouble(2), dr.GetBoolean(3)));
            }
            return tipoBorda;
        }
        public static TipoBorda ObterPorId(int id)
        {
            TipoBorda tipoBorda = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipos_borda where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoBorda.Id = dr.GetInt32(0);
                tipoBorda.Descricao = dr.GetString(1);
                tipoBorda.Valor = dr.GetDouble(2);
                tipoBorda.Ativo = dr.GetBoolean(3);
            }
            return tipoBorda;
        }
    }
}
