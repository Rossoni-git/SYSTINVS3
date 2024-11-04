using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Produto
    {//Criação de váriaveis da classe Produto
        public string Codbarras { get; set; }
        public string? Descricao { get; set; }

        public decimal Vunidade { get; set; }

        public string Uvenda { get; set; }

        public int Minestoque { get; set; }
        public Categoria Categoria { get; set; }
        public int? Desconto { get; set; }

        public int Produtoid { get; set; }

        public Produto (string codbarras, string descricao, decimal vunidade, int minestoque,
            Categoria categoria, int desconto, string uvenda)
        {

            Codbarras = codbarras;

            Descricao = descricao;

            Vunidade = vunidade;

            Uvenda = uvenda;

            Minestoque = minestoque;

            Categoria = categoria;

            Desconto = desconto;
        }
        public Produto(int produtoid, string descricao, decimal vunidade, string uvenda, Categoria categoria,
            int minestoque, int desconto, string codbarras)
        {
            Codbarras = codbarras;

            Produtoid = produtoid;

            Descricao = descricao;

            Vunidade = vunidade;

            Uvenda = uvenda;

            Minestoque = minestoque;

            Categoria = categoria;

            Desconto = desconto;
        }
        public void Inserir()

        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spid", Produtoid);
            cmd.Parameters.AddWithValue("spcod_barras", Codbarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Vunidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Uvenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", Minestoque);
            cmd.Parameters.AddWithValue("spclasse_desconto", Desconto);

        }




    }

}
