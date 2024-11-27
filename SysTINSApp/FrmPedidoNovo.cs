using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Usuario.ObterPorId(Program.UsuarioLogado.Id),
                Cliente.ObterporId(int.Parse(txtIdCliente.Text))
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbIndentificacao.Enabled = false;
            grbItens.Enabled = true;

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length >= 4)
            {
                Cliente cliente = Cliente.ObterporId(int.Parse(txtIdCliente.Text));
                txtClienteNome.Text = $"{cliente.Nome} - {cliente.Cpf}";

            }
        }

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 9)
            {
                Produto produto = Produto.ObterPorCodBar(txtCodBar.Text);
                if(produto.Id > 0)
                {
                    txtDescricao.Text=produto.Descricao;
                    txtValorUnit.Text = produto.ValorUnit.ToString();


                }
                else
                {
                    MessageBox.Show("Código de barras inválido ou Produto não cadastrado");


                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(
                int.Parse(txtIdPedido.Text),
                Produto.ObterPorCodBar(txtCodBar.Text),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)

                );
            itemPedido.Inserir();
            MessageBox.Show("Item Inserido");
        }
    }
}