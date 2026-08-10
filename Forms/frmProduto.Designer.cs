namespace StockControl.Forms
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDadosProdutos = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            textMarca = new TextBox();
            txtPrecoCompra = new TextBox();
            txtEstoqueMinimo = new TextBox();
            grpDadosProdutos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDadosProdutos
            // 
            grpDadosProdutos.Controls.Add(txtEstoqueMinimo);
            grpDadosProdutos.Controls.Add(txtPrecoCompra);
            grpDadosProdutos.Controls.Add(textMarca);
            grpDadosProdutos.Controls.Add(txtNome);
            grpDadosProdutos.Controls.Add(txtCodigo);
            grpDadosProdutos.Controls.Add(label5);
            grpDadosProdutos.Controls.Add(label1);
            grpDadosProdutos.Controls.Add(label4);
            grpDadosProdutos.Controls.Add(label2);
            grpDadosProdutos.Controls.Add(label3);
            grpDadosProdutos.Location = new Point(116, 67);
            grpDadosProdutos.Name = "grpDadosProdutos";
            grpDadosProdutos.Size = new Size(547, 369);
            grpDadosProdutos.TabIndex = 0;
            grpDadosProdutos.TabStop = false;
            grpDadosProdutos.Text = "Dados do Produto";
            grpDadosProdutos.Enter += grpDadosProdutos_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 61);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 131);
            label4.Name = "label4";
            label4.Size = new Size(111, 17);
            label4.TabIndex = 4;
            label4.Text = "Preço de Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 165);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 5;
            label5.Text = "Estoque minimo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 25);
            txtNome.TabIndex = 7;
            // 
            // textMarca
            // 
            textMarca.Location = new Point(90, 94);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(100, 25);
            textMarca.TabIndex = 8;
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.Location = new Point(133, 131);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(100, 25);
            txtPrecoCompra.TabIndex = 9;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(133, 165);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(100, 25);
            txtEstoqueMinimo.TabIndex = 10;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(grpDadosProdutos);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            grpDadosProdutos.ResumeLayout(false);
            grpDadosProdutos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDadosProdutos;
        private Label label1;
        private Label label2;
        private TextBox txtEstoqueMinimo;
        private TextBox txtPrecoCompra;
        private TextBox textMarca;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}