using StockControl.DAO;
using StockControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //bloco try tenta executar o código e captura falhas caso algo de errado
            try
            {
                //criar e preencher o obijeto
                Produto produto = new Produto();

                produto.Codigo = txtCodigo.Text;
                produto.Nome = txtNome.Text;
                produto.Marca = txtMarca.Text;
                produto.Preco = Convert.ToDecimal(txtPrecoCompra.Text);
                produto.Estoque = 0;
                produto.EstoqueMinimo = Convert.ToInt32(txtEstoqueMinimo.Text);

                ;//salvar atraves do DAO
                ProdutoDAO dao = new ProdutoDAO();
                dao.Salvar(produto);

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //captura erros de formatação
            catch (FormatException)
            {
                //exibe messagem de alerta orientando a correção dos campos numericos
                MessageBox.Show("Preencha os campos de preço 3 estoque apenas com numeros", "Erro de digitação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch(Exception ex)
            {
                //Exibir mensagem de erro gerado pelo sistema
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
