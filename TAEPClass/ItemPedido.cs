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
        public int PedidoId { get; set; }
        public Produto ProdutoId { get; set; }
        public TamanhoPizza TamanhoPizzaId { get; set; }
        public bool PizzaMeia { get; set; }
        public Produto? ProdutoSaborDoisId { get; set; }
        public ItemPedido() { }

        public ItemPedido(int id, double valorUnit, double quantidade, int pedidoId, Produto produtoId, TamanhoPizza tamanhoPizzaId)
        {
            Id = id;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            TamanhoPizzaId = tamanhoPizzaId;
        }

        public ItemPedido(double valorUnit, double quantidade, int pedidoId, Produto produtoId, TamanhoPizza tamanhoPizzaId)
        {
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            TamanhoPizzaId = tamanhoPizzaId;
        }

        public ItemPedido (int pedidoId, Produto produtoId, double valorUnit, double quantidade, TamanhoPizza tamanhoPizzaId)
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            TamanhoPizzaId = tamanhoPizzaId;

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue(" sppedido_id", PedidoId);
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
                    , dr.GetDouble(2)
                    ,dr.GetDouble(3)
                    ,dr.GetInt32(4)
                    , Produto.ObterPorId(dr.GetInt32(5))
                    , TamanhoPizza.ObterPorId(dr.GetInt32(6))
                    ));
            }
            return itens;

        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade ", Quantidade);

            return cmd.ExecuteNonQuery() > -1 ? true : false;

        }

        public static void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }

    }
}
