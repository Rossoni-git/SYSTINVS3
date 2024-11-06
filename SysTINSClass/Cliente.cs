using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
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
        public string Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public List<Endereco> Endereco { get; set; }



    }
}
