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
         //consulta o banco de dados e retorna uma lista com todos os produtos cadastrados
         public List<Produto> Listar()
        {
            //cria uma lista vazia para armazenar todos os produtos
            List<Produto> lista = new List<Produto>();

            Conexao conexao = new Conexao();
            using (MySqlConnection conn = conexao.ObterConexao())
            {
                conn.Open();
                string sql = "SELECT Id, Codigo, Nome, Marca, Preco, Estoque, EstoqueMinimo FROM Produto ORDER BY Nome;";
                
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    //execute Reader() executa o SELECT e retorna um leitor de dados (reader)
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        //enquanto ouver linhas para aver no banco
                        while (reader.Read())
                        {
                            Produto produto = new Produto();
                            produto.Id = Convert.ToInt32(reader["Id"]);
                            produto.Codigo = reader["Codigo"].ToString()!;
                            produto.Nome = reader["Nome"].ToString()!;
                            produto.Marca = reader["Marca"].ToString()!;
                            produto.Preco = Convert.ToDecimal(reader["Preco"]);
                            produto.Estoque = Convert.ToInt32(reader["Estoque"]);
                            produto.EstoqueMinimo = Convert.ToInt32(reader["EstoqueMinimo"]);

                            //adicionar produto na lista
                            lista.Add(produto);
                        }
                    }
                }
            }
            //retorna a lista preenchida
            return lista;
        }
    }
}
