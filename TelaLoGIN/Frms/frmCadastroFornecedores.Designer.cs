namespace ProjetoDesenvolvimento.Frms

{
    partial class frmCadastroFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedores));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.maskedresidencial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedcelular = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelDATANASCIMENTO = new System.Windows.Forms.Label();
            this.maskedcnpj = new System.Windows.Forms.MaskedTextBox();
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoSobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.idfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaecocostaDataSet1 = new ProjetoDesenvolvimento.lojaecocostaDataSet1();
            this.fornecedoresTableAdapter = new ProjetoDesenvolvimento.lojaecocostaDataSet1TableAdapters.FornecedoresTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.maskedresidencial);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maskedcelular);
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(23, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(646, 32);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(303, 24);
            this.txtemail.TabIndex = 7;
            // 
            // maskedresidencial
            // 
            this.maskedresidencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedresidencial.Location = new System.Drawing.Point(450, 32);
            this.maskedresidencial.Mask = "(000) 0000-0000";
            this.maskedresidencial.Name = "maskedresidencial";
            this.maskedresidencial.Size = new System.Drawing.Size(135, 24);
            this.maskedresidencial.TabIndex = 6;
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
            // maskedcelular
            // 
            this.maskedcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedcelular.Location = new System.Drawing.Point(132, 32);
            this.maskedcelular.Mask = "(000) 0,0000-0000";
            this.maskedcelular.Name = "maskedcelular";
            this.maskedcelular.Size = new System.Drawing.Size(143, 24);
            this.maskedcelular.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Location = new System.Drawing.Point(591, 38);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 19);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "E-mail:";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(804, 16);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 50);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSexo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelNomeCliente);
            this.groupBox2.Controls.Add(this.txtNomeFornecedor);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelCNPJ);
            this.groupBox2.Controls.Add(this.labelDATANASCIMENTO);
            this.groupBox2.Controls.Add(this.maskedcnpj);
            this.groupBox2.Controls.Add(this.maskeddata);
            this.groupBox2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(23, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do fornecedor";
            // 
            // comboSexo
            // 
            this.comboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.comboSexo.Location = new System.Drawing.Point(56, 79);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 28);
            this.comboSexo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "Sexo:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomeCliente.Location = new System.Drawing.Point(102, 45);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(51, 19);
            this.labelNomeCliente.TabIndex = 32;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(156, 38);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(353, 24);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(35, 39);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(45, 24);
            this.txtID.TabIndex = 78;
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
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNPJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCNPJ.Location = new System.Drawing.Point(522, 41);
            this.labelCNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(45, 19);
            this.labelCNPJ.TabIndex = 35;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // labelDATANASCIMENTO
            // 
            this.labelDATANASCIMENTO.AutoSize = true;
            this.labelDATANASCIMENTO.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATANASCIMENTO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDATANASCIMENTO.Location = new System.Drawing.Point(722, 40);
            this.labelDATANASCIMENTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDATANASCIMENTO.Name = "labelDATANASCIMENTO";
            this.labelDATANASCIMENTO.Size = new System.Drawing.Size(125, 19);
            this.labelDATANASCIMENTO.TabIndex = 36;
            this.labelDATANASCIMENTO.Text = "Data Nascimento:";
            // 
            // maskedcnpj
            // 
            this.maskedcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedcnpj.Location = new System.Drawing.Point(572, 37);
            this.maskedcnpj.Mask = "00,000,000/0000-00";
            this.maskedcnpj.Name = "maskedcnpj";
            this.maskedcnpj.Size = new System.Drawing.Size(141, 24);
            this.maskedcnpj.TabIndex = 2;
            // 
            // maskeddata
            // 
            this.maskeddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskeddata.Location = new System.Drawing.Point(848, 36);
            this.maskeddata.Mask = "00/00/0000";
            this.maskeddata.Name = "maskeddata";
            this.maskeddata.Size = new System.Drawing.Size(106, 24);
            this.maskeddata.TabIndex = 3;
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
            this.groupBox1.Location = new System.Drawing.Point(23, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 89);
            this.groupBox1.TabIndex = 3;
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
            this.comboEstado.Location = new System.Drawing.Point(76, 55);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboEstado.Size = new System.Drawing.Size(49, 26);
            this.comboEstado.TabIndex = 12;
            // 
            // maskedCEP
            // 
            this.maskedCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCEP.Location = new System.Drawing.Point(796, 21);
            this.maskedCEP.Mask = "00000,000";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(88, 24);
            this.maskedCEP.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(576, 21);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 24);
            this.txtBairro.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(58, 21);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(345, 24);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(450, 21);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(45, 24);
            this.txtNumeroCasa.TabIndex = 9;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCEP.Location = new System.Drawing.Point(755, 27);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(41, 19);
            this.labelCEP.TabIndex = 84;
            this.labelCEP.Text = "CEP:";
            // 
            // labelNumeroCasa
            // 
            this.labelNumeroCasa.AutoSize = true;
            this.labelNumeroCasa.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNumeroCasa.Location = new System.Drawing.Point(419, 27);
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
            this.labelEstado.Location = new System.Drawing.Point(16, 62);
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
            this.labelBairro.Location = new System.Drawing.Point(518, 27);
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
            this.labelEndereco.Location = new System.Drawing.Point(16, 27);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(39, 19);
            this.labelEndereco.TabIndex = 80;
            this.labelEndereco.Text = "Rua:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(608, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 50);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar Fornecedores";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(411, 16);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(153, 50);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Excluir Fornecedor";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(206, 16);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(153, 50);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar Fornecedor";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(3, 16);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(153, 50);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar Fornecedor";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // listarFornecedoresToolStripMenuItem
            // 
            this.listarFornecedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarFornecedoresToolStripMenuItem.Image")));
            this.listarFornecedoresToolStripMenuItem.Name = "listarFornecedoresToolStripMenuItem";
            this.listarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarFornecedoresToolStripMenuItem.Text = "Buscar fornecedores";
            this.listarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.listarFornecedoresToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçãoToolStripMenuItem,
            this.informaçãoSobreOProgramaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.btnFechar);
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Controls.Add(this.btnAtualizar);
            this.groupBox4.Controls.Add(this.btnDeletar);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Location = new System.Drawing.Point(23, 641);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 72);
            this.groupBox4.TabIndex = 97;
            this.groupBox4.TabStop = false;
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedores.AutoGenerateColumns = false;
            this.dataGridViewFornecedores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfornecedorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
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
            this.dataGridViewFornecedores.DataSource = this.fornecedoresBindingSource;
            this.dataGridViewFornecedores.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(23, 358);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.ReadOnly = true;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(960, 272);
            this.dataGridViewFornecedores.TabIndex = 98;
            this.dataGridViewFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellClick_1);
            // 
            // idfornecedorDataGridViewTextBoxColumn
            // 
            this.idfornecedorDataGridViewTextBoxColumn.DataPropertyName = "id_fornecedor";
            this.idfornecedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idfornecedorDataGridViewTextBoxColumn.Name = "idfornecedorDataGridViewTextBoxColumn";
            this.idfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome ";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.lojaecocostaDataSet1;
            // 
            // lojaecocostaDataSet1
            // 
            this.lojaecocostaDataSet1.DataSetName = "lojaecocostaDataSet1";
            this.lojaecocostaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1022, 722);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 761);
            this.MinimumSize = new System.Drawing.Size(1038, 761);
            this.Name = "frmCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedores | Loja EcoCosta";
            this.Load += new System.EventHandler(this.frmCadastroFornecedores_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.Label labelDATANASCIMENTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelNumeroCasa;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoSobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private lojaecocostaDataSet1 lojaecocostaDataSet1;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private lojaecocostaDataSet1TableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
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
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.MaskedTextBox maskedresidencial;
        public System.Windows.Forms.MaskedTextBox maskedcelular;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.MaskedTextBox maskedcnpj;
        public System.Windows.Forms.MaskedTextBox maskeddata;
        public System.Windows.Forms.MaskedTextBox maskedCEP;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNumeroCasa;
        public System.Windows.Forms.ComboBox comboEstado;
        public System.Windows.Forms.ComboBox comboSexo;
    }
}