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
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }


        public Categoria()
        {


        }
        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;

        }
        //Método insert da class categoria
        public void Inserir()

        {





            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.Parameters.AddWithValue("spid", Id);


        }

        //Método Consultar da classe categoria
        public static Categoria ObterPorId(int id)
        {
           Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome, sigla from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            cmd.Connection.Close();
            return categoria;

        }
        //Método de obter lista da classe categoria
        public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            cmd.Connection.Close();
            return lista;
        }



    }
}
