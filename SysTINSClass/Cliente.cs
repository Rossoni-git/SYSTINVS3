using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Cliente
    {//Atributos da classe cliente
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public bool Ativo { get; set; }

        public List<Endereco>? Endereco { get; set; }

        public Cliente() {

            Endereco = new();
        }
        //Metodo construtor
        
        
        public Cliente(int id, string? nome, string cpf, string? telefone, string email, DateTime data_nasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Ativo = ativo;
        
        }

        //Metodo construtor
        public Cliente(string? nome, string cpf, string? telefone, string email, DateTime data_nasc)
        {

            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;

        }
        //Metodo construtor
        public Cliente(int id, string? nome, string? telefone, DateTime data_nasc)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Data_nasc = data_nasc;

        }
        //Método inserir terminado
        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);

            }
            cmd.Connection.Close();


        }
        //Método atualizar
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public static Cliente ObterPorId(int id)
        {
            //Método consultar id
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                            dr.GetString(4),
                              dr.GetDateTime(5),
                              dr.GetBoolean(6)
                );


            }
            return cliente;

        }
        //Metodo obterlista
        public static List<Cliente> ObterLista()
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cliente order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                       dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                            dr.GetString(4),
                              dr.GetDateTime(5),
                              dr.GetBoolean(6)
                    )
                );
            }
            return lista;
        }

    }
   } 

