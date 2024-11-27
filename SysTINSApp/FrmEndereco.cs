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
            cmbClienteID.DataSource = Cliente.ObterLista();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
          Cliente.ObterporId(int.Parse(cmbClienteID.Text)),
              txtCEP.Text,

              txtSenha.Text,  );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                // carrega grid
                CarregaGridUsuarios();
                MessageBox.Show($"Usuário {usuario.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
