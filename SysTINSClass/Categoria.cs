using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Categoria
    {
        public int Id { get; set; }//Criação de atributo da classe
        public string? Nome { get; set; }
        public string? Sigla { get; set; }


        public Categoria()
        {


        }
        //Criando construtor
        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;

        }

        public Categoria( string nome, string sigla)
        {
          
            Nome = nome;
            Sigla = sigla;

        }
        public Categoria(int id,string nome )
        {
            Id = id;
            Nome = nome;
           

        }
        //Método insert da class categoria
        public void Inserir()

        {





            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        //Método Consultar da classe categoria
        public static Categoria ObterPorId(int id)
        {
           Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome, sigla from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                categoria = new(dr.GetInt32(0), dr.GetString(1));
            }
            cmd.Connection.Close();
            return categoria;

        }
        //Método de obter lista da classe categoria
        public static List<Categoria> ObterLista()
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from categorias order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1))) ;
            }
            cmd.Connection.Close();
            return categorias;
        }
        //Método atualizar categoria
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update categorias set nome = '{Nome}', sigla = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        // Método deletar categoria
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "sp_categoria_delete";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
