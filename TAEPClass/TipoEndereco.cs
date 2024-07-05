using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }

        // construtores
        public TipoEndereco() { }
        public TipoEndereco(string descricao, string sigla)
        {
            Descricao = descricao;
            Sigla = sigla;
        }
        public TipoEndereco(int id, string descricao, string sigla, bool ativo)
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
            cmd.CommandText = "sp_tipoendereco_insert";
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoendereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipoendereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<TipoEndereco> ObterLista()
        {
            List<TipoEndereco> tipoEndereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipoendereco order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEndereco.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return tipoEndereco;
        }
        public static TipoEndereco ObterPorId(int id)
        {
            TipoEndereco tipoEndereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipoendereco where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEndereco.Id = dr.GetInt32(0);
                tipoEndereco.Descricao = dr.GetString(1);
                tipoEndereco.Sigla = dr.GetString(2);
                tipoEndereco.Ativo = dr.GetBoolean(3);
            }
            return tipoEndereco;
        }
    }
}
