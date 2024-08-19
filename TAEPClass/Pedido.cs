using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;
using System.Data;

namespace TAEPClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public Status StatusId {  get; set; }
        public ClasseDesconto ClasseDescontoId {  get; set; }
        List<ItemPedido> Itens { get; set; }

        public Pedido() { }

        public Pedido(int id, DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDescontoId, List<ItemPedido> itens)
        {
            Id = id;
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDescontoId = classeDescontoId;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDescontoId)
        {
            Id = id;
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDescontoId = classeDescontoId;

        }

        public Pedido(DateTime dataPedido, Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDescontoId)
        {
            DataPedido = dataPedido;
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDescontoId = classeDescontoId;
        }

        public Pedido(Usuario usuario, Cliente cliente, Status statusId, ClasseDesconto classeDescontoId)
        {
            Usuario = usuario;
            Cliente = cliente;
            StatusId = statusId;
            ClasseDescontoId = classeDescontoId;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spclasse_desconto_id", ClasseDescontoId.Id);
            cmd.Parameters.AddWithValue("spstatus_id", StatusId.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new(dr.GetInt32(0)
                    ,dr.GetDateTime(1)
                    , Usuario.ObterPorId(dr.GetInt32(2))
                    , Cliente.ObterPorId(dr.GetInt32(3))
                    ,Status.ObterPorId(dr.GetInt32(5))
                    , ClasseDesconto.ObterPorId(dr.GetInt32(4))
                    );
            }

            return pedido;
        }
        public static List<Pedido> ObterPorClienteId(int ClienteId)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {ClienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(dr.GetInt32(0)
                    , dr.GetDateTime(1)
                    , Usuario.ObterPorId(dr.GetInt32(2))
                    , Cliente.ObterPorId(dr.GetInt32(3))
                    , Status.ObterPorId(dr.GetInt32(4))
                    , ClasseDesconto.ObterPorId(dr.GetInt32(5))
                    , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    );       
            }
            return pedidos;
        }

    }
}
