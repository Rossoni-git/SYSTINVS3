namespace SysTINSApp
{
    partial class FrmEndereco
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
            txtID = new TextBox();
            txtNumero = new TextBox();
            txtCEP = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtUF = new TextBox();
            txtLogradouro = new TextBox();
            txtTipo_Endereco = new TextBox();
            txtComplemento = new TextBox();
            lblId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvEndereco = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            btnAtualizar = new Button();
            label1 = new Label();
            txtClienteID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(46, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(226, 137);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(46, 203);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(403, 64);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(403, 137);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(403, 203);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(226, 64);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 7;
            // 
            // txtTipo_Endereco
            // 
            txtTipo_Endereco.Location = new Point(567, 203);
            txtTipo_Endereco.Name = "txtTipo_Endereco";
            txtTipo_Endereco.Size = new Size(100, 23);
            txtTipo_Endereco.TabIndex = 8;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(226, 203);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 10;
            lblId.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Cliente ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 185);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 47);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 119);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 185);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 46);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 14;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(567, 185);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 15;
            label8.Text = "Tipo Endereço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(403, 119);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 15;
            label9.Text = "Cidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(403, 185);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 16;
            label10.Text = "UF";
            // 
            // dgvEndereco
            // 
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvEndereco.Location = new Point(34, 288);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.Size = new Size(1003, 150);
            dgvEndereco.TabIndex = 17;
            dgvEndereco.CellContentClick += dgvEndereco_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "CEP";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Logradouro";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Número";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Complemento";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Bairro";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Cidade";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "UF";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Tipo Endereço";
            Column10.Name = "Column10";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(46, 255);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 18;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(251, 255);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 19;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(403, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 20;
            label1.Text = "Inserir Endereço";
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(46, 137);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(100, 23);
            txtClienteID.TabIndex = 21;
            txtClienteID.TextChanged += textBox1_TextChanged;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 450);
            Controls.Add(txtClienteID);
            Controls.Add(label1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(dgvEndereco);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblId);
            Controls.Add(txtComplemento);
            Controls.Add(txtTipo_Endereco);
            Controls.Add(txtLogradouro);
            Controls.Add(txtUF);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtCEP);
            Controls.Add(txtNumero);
            Controls.Add(txtID);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            Load += FrmEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNumero;
        private TextBox txtCEP;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUF;
        private TextBox txtLogradouro;
        private TextBox txtTipo_Endereco;
        private TextBox txtComplemento;
        private Label lblId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dgvEndereco;
        private Button btnInserir;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label1;
        private TextBox txtClienteID;
    }
}