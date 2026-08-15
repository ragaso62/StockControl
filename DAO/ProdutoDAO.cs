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


            //garante que a conexão seja fechada e descartada da memoria automaticamente apos o uso
            using (MySqlConnection conn = conexao.ObterConexao())
            {  
                //abre a conexão ativa com o banco de dados
                conn.Open();

                //declara a instrução SQL de inserção usando sintaxe @"...", usar parametros (@Nome, @Preco, ...)
                string sql = @"INSERT INTO Produto (Codigo, Nome, Marca, Preco, Estoque, EstoqueMinimo) VALUES (@Codigo, @Nome, @Marca, @Preco, @Estoque, @EstoqueMinimo);";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    //associar o valor da propriedade 'Codigo' do obijeto ao parametro '@Codigo' SLQ
                    cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@Estoque", produto.Estoque);
                    cmd.Parameters.AddWithValue("@EstoqueMinimo", produto.EstoqueMinimo);

                    //executa a instrução SQL no BD (usado para INSERT, UPDARE e DELETE, pois ele não retorna dados)
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
