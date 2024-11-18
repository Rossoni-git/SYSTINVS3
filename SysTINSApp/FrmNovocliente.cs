using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmNovocliente : Form
    {
        public FrmNovocliente()
        {
            InitializeComponent();
        }

        private void FrmNovocliente_Load(object sender, EventArgs e)
        {
            CarregarGridCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(

               txtClienteNome.Text,
               txtClienteCPF.Text,
               txtClienteTelefone.Text,
               txtClienteEmail.Text,
               txtClienteData.Value
               );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                CarregarGridCliente();
                MessageBox.Show($"cliente {cliente.Id} Inserido com sucesso");
                btnClienteInserir.Enabled = false;
            }
        }
        private void CarregarGridCliente()
        {
            {
                dgvCliente.Rows.Clear();
                var listaDeClientes = Cliente.ObterLista();
                int linha = 0;
                foreach (var cliente in listaDeClientes)
                {
                    dgvCliente.Rows.Add();
                    dgvCliente.Rows[linha].Cells[0].Value = cliente.Id;
                    dgvCliente.Rows[linha].Cells[1].Value = cliente.Nome;
                    dgvCliente.Rows[linha].Cells[2].Value = cliente.Cpf;
                    dgvCliente.Rows[linha].Cells[4].Value = cliente.Telefone;
                    dgvCliente.Rows[linha].Cells[3].Value = cliente.Email;
                    dgvCliente.Rows[linha].Cells[5].Value = cliente.Data_Nasc;
                    dgvCliente.Rows[linha].Cells[6].Value = cliente.Data_cad;
                    dgvCliente.Rows[linha].Cells[7].Value = cliente.Ativo;
                    linha++;
                }

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            {
                Cliente cliente = new();
                cliente.Id = int.Parse(cmbID.Text);
                cliente.Nome = txtClienteNome.Text;
                cliente.Telefone = txtClienteTelefone.Text;
                cliente.Data_Nasc = txtClienteData.Value;
                if (cliente.Atualizar())
                {
                    CarregarGridCliente();
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
            }
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}