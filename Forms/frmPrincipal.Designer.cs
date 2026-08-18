namespace StockControl
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTestarConexao = new Button();
            btnCadastrarProduto = new Button();
            SuspendLayout();
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Location = new Point(265, 296);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(161, 23);
            btnTestarConexao.TabIndex = 0;
            btnTestarConexao.Text = "Testar Conexão";
            btnTestarConexao.UseVisualStyleBackColor = true;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Location = new Point(209, 75);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(160, 23);
            btnCadastrarProduto.TabIndex = 1;
            btnCadastrarProduto.Text = "Cadastrar produto";
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            btnCadastrarProduto.Click += btnCadastrarProduto_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 403);
            Controls.Add(btnCadastrarProduto);
            Controls.Add(btnTestarConexao);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTestarConexao;
        private Button btnCadastrarProduto;
    }
}
