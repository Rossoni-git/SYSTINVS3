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

        public Cliente(){

           Endereco = new(); 
            }
        //Metodo construtor
        public Cliente(int id, string? nome, string cpf, string? telefone, string email, DateTime data_nasc,bool ativo, List<Endereco> endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Ativo = ativo;
            Endereco = endereco;
        }

        //Metodo construtor
        public Cliente( string? nome, string cpf, string? telefone, string email, DateTime data_nasc)
        {
           
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
        
        }
        //Metodo construtor
        public Cliente(int id, string? nome, string cpf, string? telefone, DateTime data_nasc)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
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



        }

    }
}
