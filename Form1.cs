using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            lstProduto.Items.Add(txtProduto.Text);
            lstPreco.Items.Add(txtPreco.Text);

            double valorTotal = 0;

            for (int i = 0; i < lstPreco.Items.Count; i++)
            {
                valorTotal = valorTotal + Convert.ToDouble(lstPreco.Items[i]);
            }

            lblPrecoTotal.Text = $"Valor Total: R$ {Convert.ToString(valorTotal)}";

            txtProduto.Clear();
            txtPreco.Clear();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            double valorTotal = 0;
            for (int i = 0; i < lstProduto.Items.Count; i++)
            {
                if (lstProduto.Items[i].ToString() == txtProduto.Text)
                {
                    lstProduto.Items.RemoveAt(i);
                    lstPreco.Items.RemoveAt(i);
                }
            }

            for (int j = 0; j < lstPreco.Items.Count; j++)
            {
                valorTotal = valorTotal + Convert.ToDouble(lstPreco.Items[j]);
            }
            lblPrecoTotal.Text = $"Valor Total: R$ {Convert.ToString(valorTotal)}";
        }

        private void lblPrecoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
