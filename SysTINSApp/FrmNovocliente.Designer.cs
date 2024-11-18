namespace SysTINSApp
{
    partial class FrmNovocliente
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
            txtClienteNome = new TextBox();
            txtClienteCPF = new TextBox();
            txtClienteEmail = new TextBox();
            txtClienteTelefone = new TextBox();
            txtClienteData = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClienteInserir = new Button();
            dgvCliente = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btnAtualizar = new Button();
            cmbID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // txtClienteNome
            // 
            txtClienteNome.Location = new Point(213, 61);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(100, 23);
            txtClienteNome.TabIndex = 1;
            // 
            // txtClienteCPF
            // 
            txtClienteCPF.Location = new Point(362, 64);
            txtClienteCPF.Name = "txtClienteCPF";
            txtClienteCPF.Size = new Size(100, 23);
            txtClienteCPF.TabIndex = 2;
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.Location = new Point(513, 64);
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.Size = new Size(100, 23);
            txtClienteEmail.TabIndex = 3;
            // 
            // txtClienteTelefone
            // 
            txtClienteTelefone.Location = new Point(66, 153);
            txtClienteTelefone.Name = "txtClienteTelefone";
            txtClienteTelefone.Size = new Size(100, 23);
            txtClienteTelefone.TabIndex = 4;
            // 
            // txtClienteData
            // 
            txtClienteData.Format = DateTimePickerFormat.Short;
            txtClienteData.Location = new Point(227, 150);
            txtClienteData.Name = "txtClienteData";
            txtClienteData.Size = new Size(140, 23);
            txtClienteData.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 45);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 48);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 48);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 135);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 132);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 12;
            label6.Text = "Data De Nascimento";
            // 
            // btnClienteInserir
            // 
            btnClienteInserir.Location = new Point(66, 205);
            btnClienteInserir.Name = "btnClienteInserir";
            btnClienteInserir.Size = new Size(75, 23);
            btnClienteInserir.TabIndex = 13;
            btnClienteInserir.Text = "Inserir";
            btnClienteInserir.UseVisualStyleBackColor = true;
            btnClienteInserir.Click += button1_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvCliente.Location = new Point(38, 259);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.Size = new Size(803, 138);
            dgvCliente.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "CPF";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefone";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Data De Nascimento";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Data De Cadastro";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ativo";
            Column8.Name = "Column8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(333, 0);
            label7.Name = "label7";
            label7.Size = new Size(179, 37);
            label7.TabIndex = 14;
            label7.Text = "Inserir Cliente";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(227, 205);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 15;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // cmbID
            // 
            cmbID.FormattingEnabled = true;
            cmbID.Location = new Point(66, 64);
            cmbID.Name = "cmbID";
            cmbID.Size = new Size(100, 23);
            cmbID.TabIndex = 16;
            cmbID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmNovocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(cmbID);
            Controls.Add(btnAtualizar);
            Controls.Add(label7);
            Controls.Add(btnClienteInserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCliente);
            Controls.Add(txtClienteData);
            Controls.Add(txtClienteTelefone);
            Controls.Add(txtClienteEmail);
            Controls.Add(txtClienteCPF);
            Controls.Add(txtClienteNome);
            Name = "FrmNovocliente";
            Text = "FrmNovocliente";
            Load += FrmNovocliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtClienteNome;
        private TextBox txtClienteCPF;
        private TextBox txtClienteEmail;
        private TextBox txtClienteTelefone;
        private DateTimePicker txtClienteData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnClienteInserir;
        private DataGridView dgvCliente;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label7;
        private Button btnAtualizar;
        private ComboBox cmbID;
    }
}