using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TAEPClass;

namespace TAEPClass
{
    public class ItemPedido
    {
        public int Id { get; set; }

        public double ValorUnit { get; set; }

        public double Quantidade { get; set; }  
        public Pedido PedidoId { get; set; }
        public Produto ProdutoId { get; set; }  

        public TamanhoPizza TamanhoPizzaId { get; set; }
        public ItemPedido() { }

        public ItemPedido(int id, double valorUnit, double quantidade, Pedido pedidoId, Produto produtoId, TamanhoPizza tamanhoPizzaId)
        {
            Id = id;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            TamanhoPizzaId = tamanhoPizzaId;
        }

        public ItemPedido(double valorUnit, double quantidade, Pedido pedidoId, Produto produtoId, TamanhoPizza tamanhoPizzaId)
        {
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            TamanhoPizzaId = tamanhoPizzaId;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue(" sppedido_id", PedidoId.Id);
            cmd.Parameters.AddWithValue("spprodutos_id", ProdutoId.Id);
            cmd.Parameters.AddWithValue("sptamanho_pizza_id", TamanhoPizzaId.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static ItemPedido ObterItem(int idPedido, int idProduto = 0)
        {
            ItemPedido itemPedido = new();

            return itemPedido;

        }
        public static List<ItemPedido> ObterListaPorPedido(int idPedido)
        {
            List<ItemPedido> itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from item_pedido where pedido_id = {idPedido}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens.Add(new(dr.GetInt32(0)
                    , dr.GetInt32(1)
                    , dr.GetDouble(2)
                    ,dr.GetDouble(3)
                    , Pedido.
                    , Produto.BuscarPorId(dr.GetInt32(2))));
            }
            return itens;

        }

    }
}
