using System.Data;

namespace SysTINSClass
{
    public class Produto
    {//Criação de váriaveis da classe Produto
        public int Produtoid { get; set; }
        public string Codbarras { get; set; }
        public string? Descricao { get; set; }

        public decimal Vunidade { get; set; }
        public string Uvenda { get; set; }
        public decimal Minestoque { get; set; }
        public Categoria Categoria { get; set; }
        public decimal? Desconto { get; set; }

        public DateTime Datacad { get; set; }

       

        public Produto() {

            Categoria = new();
        }

        public Produto(string codbarras, string descricao, decimal vunidade, int minestoque,
            Categoria categoria, int desconto, string uvenda, DateTime datacad)
        {

            Codbarras = codbarras;

            Descricao = descricao;

            Vunidade = vunidade;

            Uvenda = uvenda;

            Minestoque = minestoque;

            Categoria = categoria;

            Desconto = desconto;

            Datacad = datacad;

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

        public Produto(int produtoid, string codbarras, string? descricao, decimal vunidade, string uvenda, decimal minestoque, Categoria categoria, decimal? desconto, DateTime datacad)
        {
            Produtoid = produtoid;
            Codbarras = codbarras;
            Descricao = descricao;
            Vunidade = vunidade;
            Uvenda = uvenda;
            Minestoque = minestoque;
            Categoria = categoria;
            Desconto = desconto;
            Datacad = datacad;
        }

        public void Inserir()

        {





            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras",Codbarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Vunidade);
            cmd.Parameters.AddWithValue("spunidade_venda", Uvenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Minestoque);
            cmd.Parameters.AddWithValue("spclasse_desconto", Desconto);
          Codbarras = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

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
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetDecimal(3),
                   dr.GetString(3),
                      dr.GetInt32(6),
               Categoria.ObterPorId(dr.GetInt32(7)),
                        dr.GetDecimal(8),
                        dr.GetDateTime(9)
                        ); 


            }
            return produto;



        }
        //Método atualizar terminado
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spcod_barras", Codbarras);
            cmd.Parameters.AddWithValue("spdescricao",Descricao );
            cmd.Parameters.AddWithValue("spvalor_unit", Vunidade);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Minestoque);
            cmd.Parameters.AddWithValue("spcalsse_desconto", Desconto);


            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
   
}
