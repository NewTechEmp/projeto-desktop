using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public class Cliente
    {
        

        public int Id { get; set; }   
        public Usuario Usuario { get; set; }
        public DateTime DataNasc { get; set; }
        public string Cpf { get; set; }
        public List<Endereco> Enderecos{ get; set;}
        public List<Telefone> Telefones { get; set; }

        public Cliente() { }
        public Cliente(int id, Usuario usuario, DateTime dataNasc, string cpf, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, DateTime dataNasc, string cpf, List<Endereco> enderecos, List<Telefone> telefones)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
            Enderecos = enderecos;
            Telefones = telefones;
        }

        public Cliente(Usuario usuario, DateTime dataNasc, string cpf)
        {
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        } 

        public Cliente(int id, Usuario usuario, DateTime dataNasc, string cpf)
        {
            Id = id;
            Usuario = usuario;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public Cliente(DateTime dataNasc, string cpf)
        {
            DataNasc = dataNasc; 
            Cpf = cpf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spdata_nasc", DataNasc);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                Id = Convert.ToInt32(resultado);
            }
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = null;
            using (var cmd = Banco.Abrir())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM clientes WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        try
                        {
                            // Verifique se as colunas realmente contêm dados válidos e não são nulas
                            if (dr.IsDBNull(0) || dr.IsDBNull(1) || dr.IsDBNull(2) || dr.IsDBNull(3))
                                throw new Exception("Dados incompletos na linha do resultado.");

                            int clienteId = dr.GetInt32(0);
                            int usuarioId = dr.GetInt32(1);
                            DateTime dataCadastro = dr.GetDateTime(2);
                            string nome = dr.GetString(3);

                            // Crie o cliente com os dados recuperados
                            cliente = new Cliente(
                                clienteId,
                                Usuario.ObterPorId(usuarioId),
                                dataCadastro,
                                nome,
                                Endereco.ObterListaPorCliente(clienteId),
                                Telefone.ObterListaPorCliente(clienteId)
                            );
                        }
                        catch (InvalidCastException ex)
                        {
                            // Trate erros de conversão de tipos
                            Console.WriteLine($"Erro de conversão de dados: {ex.Message}");
                        }
                        catch (OverflowException ex)
                        {
                            // Trate erros de estouro
                            Console.WriteLine($"Erro de estouro: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            // Trate outros erros
                            Console.WriteLine($"Erro inesperado: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dado encontrado para o ID especificado.");
                    }
                }
            }

            return cliente;
        }


        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from vw_clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(
                    new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(1),
                    dr.GetDateTime(2),
                    dr.GetString(3),
                    Endereco.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))),
                    Telefone.ObterListaPorCliente(Convert.ToInt32(dr.GetInt32(0))
                    )
                ));
            }
            return clientes;
        }
    }
}
