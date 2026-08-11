using MySqlConnector;
using StockControl.Database;

namespace StockControl
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                //criar um obijeto
                Conexao conexao = new Conexao();
                //obiter a conexaão
                using (MySqlConnection conn = conexao.ObterConexao())
                {
                    //abre a conexão
                    conn.Open();


                    //menssagem de sucesso
                    MessageBox.Show(
                        "Conexão Realizada com sucesso",
                        "StockControl",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //caso ocorra erro
                MessageBox.Show(
                    "Erro ao conectar." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
  