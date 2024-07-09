using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Telefone
    {
       

        public int Id {  get; set; }
        public string Ddi { get; set; }
        public string Ddd { get; set; } 
        public string Numero { get; set; }
        public bool Ativo { get; set; } 
        public TipoTelefone TipoTelefones { get; set; } 
        public int ClienteId { get; set; }

        public Telefone() { }
        public Telefone(int id) 
        {
            Id = id;
        }
        public Telefone(int id, string ddi, string ddd, string numero, bool ativo, TipoTelefone tipoTelefone, int clienteId)
        {
            Id = id;
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            TipoTelefones = tipoTelefone;
            ClienteId = clienteId;
        }

        public Telefone(string ddd, string ddi, string numero, bool ativo, TipoTelefone tipoTelefone, int clienteId)
        {
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            TipoTelefones = tipoTelefone;
            ClienteId = clienteId;
        }

        

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spddi", Ddi);
            cmd.Parameters.AddWithValue("spddd", Ddd);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefones);
            cmd.Parameters.AddWithValue("spcliente_id", ClienteId);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public bool Editar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spddi", Ddi);
            cmd.Parameters.AddWithValue("spddd", Ddd);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefones);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public bool Deletar(int id, bool ativo)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spativo", ativo);
            return cmd.ExecuteNonQuery() > -1 ? true : false;
        }
        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone = new(
                            
                    );
            }
            return telefone;
        }
        public static List<Telefone> ObterListaPorCliente(int clienteId)
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where cliente_id = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4),
                        TipoTelefone.ObterPorId((5)),
                        dr.GetInt32(6)
                        )
                    );
            }
            return telefone;
        }
    }
}
