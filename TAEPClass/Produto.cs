using System;
using System.Collections.Generic;
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
        public string? LinkImage { get; set; }
        public DateTime DataCad {  get; set; }
        public int CategoriasId { get; set; }   
        public bool Ativo {  get; set; }

        public Produto() { }
        public Produto(int id, string nome, string descricao, double valorUnit, string codBarras, string? linkImage, DateTime dataCad, int categoriasId, bool ativo)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImage = linkImage;
            DataCad = dataCad;
            CategoriasId = categoriasId;
            Ativo = ativo;
        }

        public Produto(string nome, string descricao, double valorUnit, string codBarras, string? linkImage, DateTime dataCad, int categoriasId, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImage = linkImage;
            DataCad = dataCad;
            CategoriasId = categoriasId;
            Ativo = ativo;
        }

        public Produto(string nome, string descricao, double valorUnit, string codBarras, string? linkImage, DateTime dataCad, int categoriasId)
        {
            Nome = nome;
            Descricao = descricao;
            ValorUnit = valorUnit;
            CodBarras = codBarras;
            LinkImage = linkImage;
            DataCad = dataCad;
            CategoriasId = categoriasId;
        }

        public void Inserir()
        {

        }

        public bool Editar()

        {
            return false;
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            return produto;
        }

        public static List<Produto> ObterLista(int id)
        {
            List<Produto> produto = new();
            return produto;
        }
    }
}
