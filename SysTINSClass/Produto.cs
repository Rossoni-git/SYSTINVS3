using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public Produto() {

            Categoria = new();
        }

        public Produto(string codbarras, string descricao, decimal vunidade, int minestoque,
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
        public Produto( string descricao, decimal vunidade, string uvenda, Categoria categoria,
         int minestoque, int desconto, string codbarras)
        {
            Codbarras = codbarras;

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
        //Metodo obter pod id terminado
        public static Produto ObterPorId(int Produtoid)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where id = {Produtoid}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDecimal(4),
                        dr.GetInt32(5),
                        Categoria.ObterPorId(dr.GetInt32(6)),
                        dr.GetDecimal(6)
                        );


            }
            return produto;



        }
        //Método atualizar terminado
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produoto_update";
            cmd.Parameters.AddWithValue("spcod_barras", Codbarras);
            cmd.Parameters.AddWithValue("spdescricao",Descricao );
            cmd.Parameters.AddWithValue("spvalor_unit", Vunidade);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", Minestoque);
            cmd.Parameters.AddWithValue("spcalsse_desconto", Desconto);


            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
   
}
