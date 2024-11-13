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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserirCliente(object sender, EventArgs e)
        {
           Cliente cliete = new(
               txtNome.Text,
               txtEmail.Text,
               txtSenha.Text,
               Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
               );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                // carrega grid
                CarregaGridUsuarios();
                MessageBox.Show($"Usuário {usuario.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
    }
}
