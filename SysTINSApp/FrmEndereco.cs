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
    public partial class FrmEndereco : Form
    {
        public FrmEndereco()
        {
            InitializeComponent();
        }
        private void FrmEndereco_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaGridEndereco()
        {
            var listaDeEnderecos = Endereco.ObterListaDoCliente(int.Parse(txtClienteID.Text));
            dgvEndereco.Rows.Clear();
            int linha = 0;
            foreach (var enderecos in listaDeEnderecos)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[linha].Cells[0].Value = enderecos.Id;
                dgvEndereco.Rows[linha].Cells[1].Value = enderecos.Cliente_Id;
                dgvEndereco.Rows[linha].Cells[2].Value = enderecos.Cep;
                dgvEndereco.Rows[linha].Cells[3].Value = enderecos.Logradouro;
                dgvEndereco.Rows[linha].Cells[4].Value = enderecos.Numero;
                dgvEndereco.Rows[linha].Cells[5].Value = enderecos.Complemento;
                dgvEndereco.Rows[linha].Cells[6].Value = enderecos.Bairro;
                dgvEndereco.Rows[linha].Cells[7].Value = enderecos.Cidade;
                dgvEndereco.Rows[linha].Cells[8].Value = enderecos.Tipo_endereco;
                dgvEndereco.Rows[linha].Cells[9].Value = enderecos.Uf;
                linha++;

            }




        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                       int.Parse(txtID.Text),
                       int.Parse(txtClienteID.Text),
                             txtCEP.Text,
                         txtLogradouro.Text,
                        txtNumero.Text,
                        txtComplemento.Text,
                        txtBairro.Text,
                        txtUF.Text,
                        txtComplemento.Text
                        );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                 

                CarregaGridEndereco();
                MessageBox.Show($"Endereço {endereco.Cep} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
    }
}
