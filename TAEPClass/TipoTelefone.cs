﻿using System;
using System.Collections.Generic;
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

        public void Inserir()
        {

        }

        public bool Editar(int id)
        {
            return false;
        }

        public static TipoTelefone ObterPorId(int id)
        {
            TipoTelefone tipoTelefone = new();
            return tipoTelefone;
        }

        public static List<TipoTelefone> ObterListaPorid(int id)
        {
            List<TipoTelefone> tipoTelefones = new();
            return tipoTelefones;
        }
    }
}
