using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public  class TipoTelefone
    {
        

        public int Id { get; set; } 
        public string Sigla { get; set; }   
        public string Descricao { get; set; }   
        public bool Ativo { get; set; }

        public TipoTelefone() { }
        public TipoTelefone(int id, string sigla, string descricao, bool ativo)
        {
            Id = id;
            Sigla = sigla;
            Descricao = descricao;
            Ativo = ativo;
        }

        public TipoTelefone(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipotelefone_insert";
            cmd.Parameters.AddWithValue("spnome", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipotelefone_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Descricao);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }
        public void Desativar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipotelefone_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
        }
        public static List<TipoTelefone> ObterLista()
        {
            List<TipoTelefone> tipotelefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipotelefone";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipotelefone.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3)));
            }
            return tipotelefone;
        }
        public static TipoTelefone ObterPorId(int id)
        {
            TipoTelefone tipoTelefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tipotelefone where id  = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoTelefone.Id = dr.GetInt32(0);
                tipoTelefone.Descricao = dr.GetString(1);
                tipoTelefone.Sigla = dr.GetString(2);
                tipoTelefone.Ativo = dr.GetBoolean(3);
            }
            return tipoTelefone;
        }
    }
}
