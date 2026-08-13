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
            //criar e preencher o obijeto
            Produto produto = new Produto();

            produto.Codigo = txtCodigo.Text;
            produto.Nome = txtNome.Text;
            produto.Marca = txtMarca.Text;
        }
    }
}
