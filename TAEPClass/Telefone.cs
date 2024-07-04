using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Telefone
    {
       

        public int Id {  get; set; }
        public string DDI { get; set; }
        public string DDD { get; set; } 
        public string Numero { get; set; }
        public bool Ativo { get; set; } 
        public int TipoTelefoneId { get; set; } 
        public int ClienteId { get; set; }

        public Telefone(int id, string dDI, string dDD, string numero, bool ativo, int tipoTelefoneId, int clienteId)
        {
            Id = id;
            DDI = dDI;
            DDD = dDD;
            Numero = numero;
            Ativo = ativo;
            TipoTelefoneId = tipoTelefoneId;
            ClienteId = clienteId;
        }

        public Telefone(string Ddd, string Ddi, string numero, bool ativo, int tipoTelefoneId, int clienteId)
        {
            DDI = Ddi;
            DDD = Ddd;
            Numero = numero;
            Ativo = ativo;
            TipoTelefoneId = tipoTelefoneId;
            ClienteId = clienteId;
        }

        public Telefone() { }   

        public void Inserir()
        {

        }

        public bool Editar(int id)
        {
            return false;
        }

        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new();
            return telefone;
        }

        public static List<Telefone> ObterLista(int clienteId)
        {
            List<Telefone> telefone = new();
            return telefone;
        }


        
    }
}
