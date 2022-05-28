using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WFProdutoServico : Form
    {
        public WFProdutoServico()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                ProdutoServiço produtoServico = new ProdutoServiço();
                if (!textBoxID.Text.Equals(""))
                {
                    produtoServico.Id = Convert.ToInt32(textBoxID.Text);
                }
                produtoServico.Descricao = textBoxDescricao.Text;
                produtoServico.Peso = Decimal.Parse(textBoxPeso.Text);
                produtoServico.TMO = Decimal.Parse(textBoxTMO.Text);
                produtoServico.Categoria.Id = (Int32)comboBoxCategoria.SelectedValue;
                produtoServico.TipoProdutoServico.Id = (Int32)comboBoxTipo.SelectedValue;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro 0x00186!!! Entre em contato com o administrador do sistema. Detalhes:"+exception.Message);
            }
        }

        private void WFProdutoServico_Load(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            comboBoxCategoria.DataSource = categoria.ListaCategoria();
            comboBoxCategoria.DisplayMember = categoria.Descricao;
        
;        }
    }
}
