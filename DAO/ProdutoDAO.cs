    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using StockControl.Database;
using StockControl.Models;

namespace StockControl.DAO
{

    public class ProdutoDAO
    {
        public void Salvar(Produto produto)
        {
            Conexao conexao = new Conexao();

            MySqlConnection conn = conexao.ObterConexao();
            conn.Open();

            //montar o SQL por concatenação
            string slq = "INSERT INTO produto (Codigo, Nome, Marca, Preco, Estoque, EstoqueMinimo) VALUE(" +
                produto.Codigo + "', '"
                + produto.Nome + "', '"
                + produto.Marca + "', '"
                + produto.Preco + "', '"
                + produto.Estoque + "', '"
                + produto.EstoqueMinimo + ");";
            MySqlCommand cmd = new MySqlCommand(slq, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

    }
}
