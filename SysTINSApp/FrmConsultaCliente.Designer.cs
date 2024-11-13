namespace SysTINSApp
{
    partial class FrmConsultaCliente
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNomecliente = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnInserircliente = new Button();
            dataGridView1 = new DataGridView();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Nome_cliente = new DataGridViewTextBoxColumn();
            cpf_cliente = new DataGridViewTextBoxColumn();
            Telefone_cliente = new DataGridViewTextBoxColumn();
            Email_Cliente = new DataGridViewTextBoxColumn();
            Datanasc_cliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 96);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 171);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 171);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 171);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Cpf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 227);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 5;
            label6.Text = "Data de nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 227);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Subheading", 25F, FontStyle.Italic);
            label8.Location = new Point(249, 25);
            label8.Name = "label8";
            label8.Size = new Size(303, 49);
            label8.TabIndex = 7;
            label8.Text = "Cadastro de Cliente";
            label8.Click += label8_Click;
            // 
            // txtNomecliente
            // 
            txtNomecliente.Location = new Point(59, 114);
            txtNomecliente.Name = "txtNomecliente";
            txtNomecliente.Size = new Size(390, 23);
            txtNomecliente.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(406, 189);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(59, 189);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(59, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(112, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // btnInserircliente
            // 
            btnInserircliente.Location = new Point(277, 239);
            btnInserircliente.Name = "btnInserircliente";
            btnInserircliente.Size = new Size(101, 29);
            btnInserircliente.TabIndex = 16;
            btnInserircliente.Text = "Inserir";
            btnInserircliente.UseVisualStyleBackColor = true;
            btnInserircliente.Click += btnInserirCliente;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Cliente, Nome_cliente, cpf_cliente, Telefone_cliente, Email_Cliente, Datanasc_cliente });
            dataGridView1.Location = new Point(57, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(650, 123);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "Id";
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.ReadOnly = true;
            // 
            // Nome_cliente
            // 
            Nome_cliente.HeaderText = "Nome";
            Nome_cliente.Name = "Nome_cliente";
            Nome_cliente.ReadOnly = true;
            // 
            // cpf_cliente
            // 
            cpf_cliente.HeaderText = "Cpf";
            cpf_cliente.Name = "cpf_cliente";
            // 
            // Telefone_cliente
            // 
            Telefone_cliente.HeaderText = "Telefone";
            Telefone_cliente.Name = "Telefone_cliente";
            // 
            // Email_Cliente
            // 
            Email_Cliente.HeaderText = "Email";
            Email_Cliente.Name = "Email_Cliente";
            // 
            // Datanasc_cliente
            // 
            Datanasc_cliente.HeaderText = "Data_Nascimento";
            Datanasc_cliente.Name = "Datanasc_cliente";
            Datanasc_cliente.Width = 150;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnInserircliente);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(txtNomecliente);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmConsultaCliente";
            Text = "FrmConsultaCliente";
            Load += FrmConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNomecliente;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker1;
        private Button btnInserircliente;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nome_cliente;
        private DataGridViewTextBoxColumn cpf_cliente;
        private DataGridViewTextBoxColumn Telefone_cliente;
        private DataGridViewTextBoxColumn Email_Cliente;
        private DataGridViewTextBoxColumn Datanasc_cliente;
    }
}