using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Pedido
    {
       

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public  Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string? Status { get; set; }
        public decimal Desconto { get; set; }





        public Pedido()
        {
            Cliente = new();
            Usuario = new();


        }
        public Pedido( Usuario usuario, Cliente cliente)
        {
           
            Usuario = usuario;
            Cliente = cliente;
          
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, decimal desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

    }
}
