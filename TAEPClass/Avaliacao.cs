﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAEPClass
{
    internal class Avaliacao
    {
        //propriedades da classe
        public int Id { get; set; }
        public double Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }

        // métodos construtores
        public Avaliacao() { }

        public Avaliacao(int id, double nota, string comentario, DateTime dataPedido, Cliente cliente, Produto produto)
        {
            Id = id;
            Nota = nota;
            Comentario = comentario;
            DataPedido = dataPedido;
            Cliente = cliente;
            Produto = produto;
        }

        public Avaliacao(double nota, string comentario, DateTime dataPedido, Cliente cliente, Produto produto)
        {
            Nota = nota;
            Comentario = comentario;
            DataPedido = dataPedido;
            Cliente = cliente;
            Produto = produto;
        }

        // metodos da classe
        public void Inserir()
        {

        }
        public void Editar()
        {

        }
        public static List<Avaliacao> ObterLista(string descricao = null)
        {                                                                                           
            List<Avaliacao> avaliacaos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from adicional order by descricao";
            }
            else
            {
                cmd.CommandText = $"select * from adicional where nome like '%{descricao}%' order by descricao";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                avaliacaos.Add(new(
                    dr.GetInt32(0), 
                    dr.GetDouble(1),
                    dr.GetString(2), 
                    dr.GetDateTime(3),
                    Cliente.ObterPorId((4)),
                    Produto.ObterLista((5))
                    ));
            }
            return avaliacaos;
        }
    }
}
