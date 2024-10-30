namespace ProjetoDesenvolvimento.Frms
{
    partial class frmCadastroClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoSobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaecocostaDataSet = new ProjetoDesenvolvimento.lojaecocostaDataSet();
            this.clientesTableAdapter = new ProjetoDesenvolvimento.lojaecocostaDataSetTableAdapters.ClientesTableAdapter();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonecelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneresidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.maskedTelefoneresidencial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTelefonecelular = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.labelRG = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelDATANASCIMENTO = new System.Windows.Forms.Label();
            this.maskedrg = new System.Windows.Forms.MaskedTextBox();
            this.maskedcpf = new System.Windows.Forms.MaskedTextBox();
            this.maskeddata = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelNumeroCasa = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1021, 25);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarClientesToolStripMenuItem.Image")));
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarClientesToolStripMenuItem.Text = "Buscar clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçãoToolStripMenuItem,
            this.informaçãoSobreOProgramaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // informaçãoToolStripMenuItem
            // 
            this.informaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaçãoToolStripMenuItem.Image")));
            this.informaçãoToolStripMenuItem.Name = "informaçãoToolStripMenuItem";
            this.informaçãoToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.informaçãoToolStripMenuItem.Text = "Informação sobre o desenvolvimento";
            this.informaçãoToolStripMenuItem.Click += new System.EventHandler(this.informaçãoToolStripMenuItem_Click);
            // 
            // informaçãoSobreOProgramaToolStripMenuItem
            // 
            this.informaçãoSobreOProgramaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaçãoSobreOProgramaToolStripMenuItem.Image")));
            this.informaçãoSobreOProgramaToolStripMenuItem.Name = "informaçãoSobreOProgramaToolStripMenuItem";
            this.informaçãoSobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.informaçãoSobreOProgramaToolStripMenuItem.Text = "Informação sobre o programa";
            this.informaçãoSobreOProgramaToolStripMenuItem.Click += new System.EventHandler(this.informaçãoSobreOProgramaToolStripMenuItem_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.lojaecocostaDataSet;
            // 
            // lojaecocostaDataSet
            // 
            this.lojaecocostaDataSet.DataSetName = "lojaecocostaDataSet";
            this.lojaecocostaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AutoGenerateColumns = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.telefonecelularDataGridViewTextBoxColumn,
            this.telefoneresidencialDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numerocasaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridViewClientes.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewClientes.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewClientes.Location = new System.Drawing.Point(30, 332);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewClientes.Size = new System.Drawing.Size(960, 291);
            this.dataGridViewClientes.TabIndex = 110;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick_1);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "datanascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Data de nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonecelularDataGridViewTextBoxColumn
            // 
            this.telefonecelularDataGridViewTextBoxColumn.DataPropertyName = "telefonecelular";
            this.telefonecelularDataGridViewTextBoxColumn.HeaderText = "Telefone celular";
            this.telefonecelularDataGridViewTextBoxColumn.Name = "telefonecelularDataGridViewTextBoxColumn";
            this.telefonecelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneresidencialDataGridViewTextBoxColumn
            // 
            this.telefoneresidencialDataGridViewTextBoxColumn.DataPropertyName = "telefoneresidencial";
            this.telefoneresidencialDataGridViewTextBoxColumn.HeaderText = "Telefone residencial";
            this.telefoneresidencialDataGridViewTextBoxColumn.Name = "telefoneresidencialDataGridViewTextBoxColumn";
            this.telefoneresidencialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerocasaDataGridViewTextBoxColumn
            // 
            this.numerocasaDataGridViewTextBoxColumn.DataPropertyName = "numerocasa";
            this.numerocasaDataGridViewTextBoxColumn.HeaderText = "N°";
            this.numerocasaDataGridViewTextBoxColumn.Name = "numerocasaDataGridViewTextBoxColumn";
            this.numerocasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.btnFechar);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Controls.Add(this.btnAtualizar);
            this.groupBox4.Controls.Add(this.btnDeletar);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Location = new System.Drawing.Point(30, 631);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(960, 75);
            this.groupBox4.TabIndex = 109;
            this.groupBox4.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(803, 19);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 50);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(4, 19);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastrar.Size = new System.Drawing.Size(153, 50);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(201, 19);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(153, 50);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar Cliente";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(403, 19);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(153, 50);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Excluir Cliente";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(608, 19);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 50);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar Clientes";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEMAIL);
            this.groupBox3.Controls.Add(this.maskedTelefoneresidencial);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maskedTelefonecelular);
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(30, 160);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(960, 69);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.Location = new System.Drawing.Point(645, 32);
            this.txtEMAIL.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEMAIL.Size = new System.Drawing.Size(303, 24);
            this.txtEMAIL.TabIndex = 8;
            // 
            // maskedTelefoneresidencial
            // 
            this.maskedTelefoneresidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTelefoneresidencial.Location = new System.Drawing.Point(451, 32);
            this.maskedTelefoneresidencial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTelefoneresidencial.Mask = "(000) 0000-0000";
            this.maskedTelefoneresidencial.Name = "maskedTelefoneresidencial";
            this.maskedTelefoneresidencial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTelefoneresidencial.Size = new System.Drawing.Size(135, 24);
            this.maskedTelefoneresidencial.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Telefone Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(296, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Telefone Residencial:";
            // 
            // maskedTelefonecelular
            // 
            this.maskedTelefonecelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTelefonecelular.Location = new System.Drawing.Point(132, 32);
            this.maskedTelefonecelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTelefonecelular.Mask = "(000) 0,0000-0000";
            this.maskedTelefonecelular.Name = "maskedTelefonecelular";
            this.maskedTelefonecelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTelefonecelular.Size = new System.Drawing.Size(143, 24);
            this.maskedTelefonecelular.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Location = new System.Drawing.Point(589, 38);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 19);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "E-mail:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSexo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelNomeCliente);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.labelRG);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelCPF);
            this.groupBox2.Controls.Add(this.labelDATANASCIMENTO);
            this.groupBox2.Controls.Add(this.maskedrg);
            this.groupBox2.Controls.Add(this.maskedcpf);
            this.groupBox2.Controls.Add(this.maskeddata);
            this.groupBox2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(30, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(960, 115);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do cliente";
            // 
            // comboSexo
            // 
            this.comboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.comboSexo.Location = new System.Drawing.Point(348, 77);
            this.comboSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 26);
            this.comboSexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(296, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 87;
            this.label4.Text = "Sexo:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomeCliente.Location = new System.Drawing.Point(101, 45);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(51, 19);
            this.labelNomeCliente.TabIndex = 32;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(156, 38);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomeCliente.Size = new System.Drawing.Size(353, 24);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRG.Location = new System.Drawing.Point(717, 42);
            this.labelRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(27, 19);
            this.labelRG.TabIndex = 33;
            this.labelRG.Text = "RG";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(35, 39);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.Size = new System.Drawing.Size(45, 24);
            this.txtID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCPF.Location = new System.Drawing.Point(525, 42);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(36, 19);
            this.labelCPF.TabIndex = 35;
            this.labelCPF.Text = "CPF";
            // 
            // labelDATANASCIMENTO
            // 
            this.labelDATANASCIMENTO.AutoSize = true;
            this.labelDATANASCIMENTO.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATANASCIMENTO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDATANASCIMENTO.Location = new System.Drawing.Point(4, 83);
            this.labelDATANASCIMENTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDATANASCIMENTO.Name = "labelDATANASCIMENTO";
            this.labelDATANASCIMENTO.Size = new System.Drawing.Size(125, 19);
            this.labelDATANASCIMENTO.TabIndex = 36;
            this.labelDATANASCIMENTO.Text = "Data Nascimento:";
            // 
            // maskedrg
            // 
            this.maskedrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedrg.Location = new System.Drawing.Point(749, 37);
            this.maskedrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedrg.Mask = "00,000,000,0";
            this.maskedrg.Name = "maskedrg";
            this.maskedrg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedrg.Size = new System.Drawing.Size(103, 24);
            this.maskedrg.TabIndex = 3;
            // 
            // maskedcpf
            // 
            this.maskedcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedcpf.Location = new System.Drawing.Point(569, 37);
            this.maskedcpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedcpf.Mask = "000,000,000-00";
            this.maskedcpf.Name = "maskedcpf";
            this.maskedcpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedcpf.Size = new System.Drawing.Size(132, 24);
            this.maskedcpf.TabIndex = 2;
            // 
            // maskeddata
            // 
            this.maskeddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskeddata.Location = new System.Drawing.Point(132, 80);
            this.maskeddata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskeddata.Mask = "00/00/0000";
            this.maskeddata.Name = "maskeddata";
            this.maskeddata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskeddata.Size = new System.Drawing.Size(105, 24);
            this.maskeddata.TabIndex = 4;
            this.maskeddata.ValidatingType = typeof(System.DateTime);
            this.maskeddata.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskeddata_TypeValidationCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.maskedCEP);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNumeroCasa);
            this.groupBox1.Controls.Add(this.labelCEP);
            this.groupBox1.Controls.Add(this.labelNumeroCasa);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.labelBairro);
            this.groupBox1.Controls.Add(this.labelEndereco);
            this.groupBox1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(30, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(960, 89);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboEstado.Location = new System.Drawing.Point(77, 56);
            this.comboEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboEstado.Size = new System.Drawing.Size(49, 26);
            this.comboEstado.TabIndex = 13;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCEP.Location = new System.Drawing.Point(792, 20);
            this.maskedCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedCEP.Mask = "00000-000";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedCEP.Size = new System.Drawing.Size(88, 24);
            this.maskedCEP.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(576, 20);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.Size = new System.Drawing.Size(161, 24);
            this.txtBairro.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(59, 20);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.Size = new System.Drawing.Size(345, 24);
            this.txtEndereco.TabIndex = 9;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(451, 20);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeroCasa.Size = new System.Drawing.Size(45, 24);
            this.txtNumeroCasa.TabIndex = 10;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCEP.Location = new System.Drawing.Point(755, 26);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(36, 19);
            this.labelCEP.TabIndex = 84;
            this.labelCEP.Text = "CEP";
            // 
            // labelNumeroCasa
            // 
            this.labelNumeroCasa.AutoSize = true;
            this.labelNumeroCasa.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNumeroCasa.Location = new System.Drawing.Point(419, 26);
            this.labelNumeroCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroCasa.Name = "labelNumeroCasa";
            this.labelNumeroCasa.Size = new System.Drawing.Size(23, 19);
            this.labelNumeroCasa.TabIndex = 83;
            this.labelNumeroCasa.Text = "N°";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEstado.Location = new System.Drawing.Point(16, 61);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(58, 19);
            this.labelEstado.TabIndex = 82;
            this.labelEstado.Text = "Estado:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBairro.Location = new System.Drawing.Point(517, 26);
            this.labelBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(55, 19);
            this.labelBairro.TabIndex = 81;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEndereco.Location = new System.Drawing.Point(16, 26);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(39, 19);
            this.labelEndereco.TabIndex = 80;
            this.labelEndereco.Text = "Rua:";
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1021, 722);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1037, 761);
            this.MinimumSize = new System.Drawing.Size(1037, 761);
            this.Name = "frmCadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes | Loja EcoCosta";
            this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoSobreOProgramaToolStripMenuItem;
        private lojaecocostaDataSet lojaecocostaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private lojaecocostaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelDATANASCIMENTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelNumeroCasa;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonecelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneresidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.TextBox txtEMAIL;
        public System.Windows.Forms.MaskedTextBox maskedTelefoneresidencial;
        public System.Windows.Forms.MaskedTextBox maskedTelefonecelular;
        public System.Windows.Forms.ComboBox comboSexo;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.MaskedTextBox maskedrg;
        public System.Windows.Forms.MaskedTextBox maskedcpf;
        public System.Windows.Forms.MaskedTextBox maskeddata;
        public System.Windows.Forms.ComboBox comboEstado;
        public System.Windows.Forms.MaskedTextBox maskedCEP;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNumeroCasa;
    }
}