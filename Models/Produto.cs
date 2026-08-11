using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Marca {  get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set;  }
        public int EstoqueMinimo { get; set; }
    }
}
