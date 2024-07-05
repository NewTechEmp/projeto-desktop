using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }   
        public string Descricao { get; set; }   
        public double ValorUnit {  get; set; }  
        public string CodBarras { get; set; }   
        public string? LinkImagem { get; set; }
        public DateTime DataCad {  get; set; }
        public Categoria CategoriaId { get; set; }   
        public bool Ativo {  get; set; }

        public Produto() { }
        public Produto(int id) 
        {
            Id = id;
        }
        public Produto(int id, string nome, string descricao, double valorUnit, string codBarras, string? linkImagem, DateTime dataCad, Categoria categoriaId, bool ativo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImagem = linkImagem;
            DataCad = dataCad;
            CategoriaId = categoriaId;
            Ativo = ativo;
        }

        public Produto(string nome, string descricao, double valorUnit, string codBarras, string? linkImagem, DateTime dataCad, Categoria categoriaId, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImagem = linkImagem;
            DataCad = dataCad;
            CategoriaId = categoriaId;
            Ativo = ativo;
        }

        public Produto(string nome, string descricao, double valorUnit, string codBarras, string? linkImagem, DateTime dataCad, Categoria categoriaId)
        {
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImagem = linkImagem;
            DataCad = dataCad;
            CategoriaId = categoriaId;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", Nome);
            cmd.Parameters.AddWithValue("", Descricao);
            cmd.Parameters.AddWithValue("spdescricao", ValorUnit);
            cmd.Parameters.AddWithValue("spvalor_unit", CodBarras);
            cmd.Parameters.AddWithValue("", LinkImagem);
            cmd.Parameters.AddWithValue("", DataCad);
            cmd.Parameters.AddWithValue("", CategoriaId);
            cmd.Parameters.AddWithValue("", Ativo);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spId", Id);
            cmd.Parameters.AddWithValue("spcod_barras", Nome);
            cmd.Parameters.AddWithValue("", Descricao);
            cmd.Parameters.AddWithValue("spdescricao", ValorUnit);
            cmd.Parameters.AddWithValue("spvalor_unit", CodBarras);
            cmd.Parameters.AddWithValue("", LinkImagem);
            cmd.Parameters.AddWithValue("", DataCad);
            cmd.Parameters.AddWithValue("", CategoriaId);
            cmd.Parameters.AddWithValue("", Ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Deletar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static List<Produto> ObterLista(string descricao = null)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from produtos order by descricao";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where nome like '%{descricao}%' order by descricao";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetDateTime(6),
                        Categoria.ObterPorId((5)),
                        dr.GetBoolean(6)
                    )
                );
            }

            return produto;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDouble(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetDateTime(6),
                        Categoria.ObterPorId((5)),
                        dr.GetBoolean(6)
                );
            }
            return produto;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DataCad);
        }
    }
}
