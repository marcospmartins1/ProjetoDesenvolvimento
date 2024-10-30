namespace ProjetoDesenvolvimento.Frms
{
    partial class frmListarProdutos
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
            this.dataGridViewListarProdutos = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorbrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaecocostaDataSet15 = new ProjetoDesenvolvimento.lojaecocostaDataSet15();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.comboPesquisar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.produtosTableAdapter = new ProjetoDesenvolvimento.lojaecocostaDataSet15TableAdapters.ProdutosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet15)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListarProdutos
            // 
            this.dataGridViewListarProdutos.AllowUserToAddRows = false;
            this.dataGridViewListarProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewListarProdutos.AutoGenerateColumns = false;
            this.dataGridViewListarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nomecategoriaDataGridViewTextBoxColumn,
            this.descricaoprodutoDataGridViewTextBoxColumn,
            this.nomefornecedorDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.valorbrutoDataGridViewTextBoxColumn});
            this.dataGridViewListarProdutos.DataSource = this.produtosBindingSource;
            this.dataGridViewListarProdutos.Location = new System.Drawing.Point(31, 137);
            this.dataGridViewListarProdutos.Name = "dataGridViewListarProdutos";
            this.dataGridViewListarProdutos.ReadOnly = true;
            this.dataGridViewListarProdutos.Size = new System.Drawing.Size(960, 568);
            this.dataGridViewListarProdutos.TabIndex = 116;
            this.dataGridViewListarProdutos.Click += new System.EventHandler(this.dataGridViewListarProdutos_Click);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomecategoriaDataGridViewTextBoxColumn
            // 
            this.nomecategoriaDataGridViewTextBoxColumn.DataPropertyName = "nome_categoria";
            this.nomecategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.nomecategoriaDataGridViewTextBoxColumn.Name = "nomecategoriaDataGridViewTextBoxColumn";
            this.nomecategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoprodutoDataGridViewTextBoxColumn
            // 
            this.descricaoprodutoDataGridViewTextBoxColumn.DataPropertyName = "descricaoproduto";
            this.descricaoprodutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoprodutoDataGridViewTextBoxColumn.Name = "descricaoprodutoDataGridViewTextBoxColumn";
            this.descricaoprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefornecedorDataGridViewTextBoxColumn
            // 
            this.nomefornecedorDataGridViewTextBoxColumn.DataPropertyName = "nome_fornecedor";
            this.nomefornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.nomefornecedorDataGridViewTextBoxColumn.Name = "nomefornecedorDataGridViewTextBoxColumn";
            this.nomefornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorbrutoDataGridViewTextBoxColumn
            // 
            this.valorbrutoDataGridViewTextBoxColumn.DataPropertyName = "valorbruto";
            this.valorbrutoDataGridViewTextBoxColumn.HeaderText = "Valor total";
            this.valorbrutoDataGridViewTextBoxColumn.Name = "valorbrutoDataGridViewTextBoxColumn";
            this.valorbrutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.lojaecocostaDataSet15;
            // 
            // lojaecocostaDataSet15
            // 
            this.lojaecocostaDataSet15.DataSetName = "lojaecocostaDataSet15";
            this.lojaecocostaDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFechar);
            this.groupBox2.Controls.Add(this.comboPesquisar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelNomeCliente);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(31, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(960, 81);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Location = new System.Drawing.Point(791, 20);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(153, 50);
            this.btnFechar.TabIndex = 109;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // comboPesquisar
            // 
            this.comboPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPesquisar.FormattingEnabled = true;
            this.comboPesquisar.Items.AddRange(new object[] {
            "Categoria",
            "Fornecedor",
            "Valor",
            "Quantidade"});
            this.comboPesquisar.Location = new System.Drawing.Point(481, 31);
            this.comboPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboPesquisar.Name = "comboPesquisar";
            this.comboPesquisar.Size = new System.Drawing.Size(176, 26);
            this.comboPesquisar.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(369, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "Pesquisar por:";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomeCliente.Location = new System.Drawing.Point(7, 38);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(51, 19);
            this.labelNomeCliente.TabIndex = 32;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(66, 33);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(238, 24);
            this.txtNome.TabIndex = 1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1022, 730);
            this.Controls.Add(this.dataGridViewListarProdutos);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 769);
            this.MinimumSize = new System.Drawing.Size(1038, 769);
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar produtos | Loja EcoCosta";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaecocostaDataSet15)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListarProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox comboPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox txtNome;
        private lojaecocostaDataSet15 lojaecocostaDataSet15;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private lojaecocostaDataSet15TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorbrutoDataGridViewTextBoxColumn;
    }
}