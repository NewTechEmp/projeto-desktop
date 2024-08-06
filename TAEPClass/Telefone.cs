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
        public string ClienteEmail { get; set; }
        public TipoTelefone TipoTelefones { get; set; }

        public Telefone() { }
        public Telefone(int id) 
        {
            Id = id;
        }
        public Telefone(int id, string ddi, string ddd, string numero, bool ativo, string clienteEmail, TipoTelefone tipoTelefone)
        {
            Id = id;
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            ClienteEmail = clienteEmail;
            TipoTelefones = tipoTelefone;
        }
        public Telefone( string ddi, string ddd, string numero, string clienteEmail, TipoTelefone tipoTelefone)
        {
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            ClienteEmail = clienteEmail;
            TipoTelefones = tipoTelefone;
        }

        public Telefone(string ddd, string ddi, string numero, bool ativo, string clienteEmail, TipoTelefone tipoTelefone)
        {
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            Ativo = ativo;
            ClienteEmail = clienteEmail;
            TipoTelefones = tipoTelefone;
        }

        

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spddi", Ddi);
            cmd.Parameters.AddWithValue("spddd", Ddd);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sp_telefone_cliente_email", ClienteEmail);
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefones.Id);
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
            cmd.Parameters.AddWithValue("sptipo_telefone_id", TipoTelefones.Id);
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
                    dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4),
                        dr.GetString(6),
                     TipoTelefone.ObterPorId(dr.GetInt32(5))

                    );
            }
            return telefone;
        }
        public static List<Telefone> ObterListaPorCliente(string clienteEmail)
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where email_cliente = {clienteEmail}";
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
                      dr.GetString(6),
                     TipoTelefone.ObterPorId(dr.GetInt32(5))
                        )
                    );
            }
            return telefone;
        }
    }
}
