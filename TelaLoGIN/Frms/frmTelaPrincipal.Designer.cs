namespace ProjetoDesenvolvimento.Frms
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicarUmaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoSobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(223, 17);
            this.toolStripStatusLabel1.Text = "Bem vindo ao Sistema da Loja EcoCosta |";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem,
            this.listarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarClientesToolStripMenuItem.Image")));
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarClientesToolStripMenuItem.Image")));
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEstoqueToolStripMenuItem1});
            this.estoqueToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Sair;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // listarEstoqueToolStripMenuItem1
            // 
            this.listarEstoqueToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listarEstoqueToolStripMenuItem1.Image")));
            this.listarEstoqueToolStripMenuItem1.Name = "listarEstoqueToolStripMenuItem1";
            this.listarEstoqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarEstoqueToolStripMenuItem1.Text = "Listar estoque";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedoresToolStripMenuItem,
            this.listarFornecedoresToolStripMenuItem1});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cadastrarFornecedoresToolStripMenuItem
            // 
            this.cadastrarFornecedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarFornecedoresToolStripMenuItem.Image")));
            this.cadastrarFornecedoresToolStripMenuItem.Name = "cadastrarFornecedoresToolStripMenuItem";
            this.cadastrarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadastrarFornecedoresToolStripMenuItem.Text = "Cadastrar fornecedores";
            this.cadastrarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedoresToolStripMenuItem_Click);
            // 
            // listarFornecedoresToolStripMenuItem1
            // 
            this.listarFornecedoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listarFornecedoresToolStripMenuItem1.Image")));
            this.listarFornecedoresToolStripMenuItem1.Name = "listarFornecedoresToolStripMenuItem1";
            this.listarFornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.listarFornecedoresToolStripMenuItem1.Text = "Listar fornecedores";
            this.listarFornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.listarFornecedoresToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutosToolStripMenuItem,
            this.listarProdutosToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarProdutosToolStripMenuItem.Image")));
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // listarProdutosToolStripMenuItem1
            // 
            this.listarProdutosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listarProdutosToolStripMenuItem1.Image")));
            this.listarProdutosToolStripMenuItem1.Name = "listarProdutosToolStripMenuItem1";
            this.listarProdutosToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.listarProdutosToolStripMenuItem1.Text = "Listar produtos";
            this.listarProdutosToolStripMenuItem1.Click += new System.EventHandler(this.listarProdutosToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicarUmaVendaToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Sair;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // inicarUmaVendaToolStripMenuItem
            // 
            this.inicarUmaVendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicarUmaVendaToolStripMenuItem.Image")));
            this.inicarUmaVendaToolStripMenuItem.Name = "inicarUmaVendaToolStripMenuItem";
            this.inicarUmaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inicarUmaVendaToolStripMenuItem.Text = "Iniciar uma venda";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatórioDeVendasToolStripMenuItem.Image")));
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas";
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
            // trocarUsuárioToolStripMenuItem
            // 
            this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.trocarUsuárioToolStripMenuItem.Text = "Logoff";
            this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // trocarUsuárioToolStripMenuItem1
            // 
            this.trocarUsuárioToolStripMenuItem1.Name = "trocarUsuárioToolStripMenuItem1";
            this.trocarUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.trocarUsuárioToolStripMenuItem1.Text = "Sair";
            this.trocarUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.trocarUsuárioToolStripMenuItem,
            this.trocarUsuárioToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCategoriaToolStripMenuItem,
            this.listarCategoriasToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            this.cadastrarCategoriaToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Adicionar;
            this.cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            this.cadastrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarCategoriaToolStripMenuItem.Text = "Cadastrar categorias";
            this.cadastrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCategoriaToolStripMenuItem_Click_1);
            // 
            // listarCategoriasToolStripMenuItem
            // 
            this.listarCategoriasToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Buscar;
            this.listarCategoriasToolStripMenuItem.Name = "listarCategoriasToolStripMenuItem";
            this.listarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarCategoriasToolStripMenuItem.Text = "Listar categorias";
            this.listarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoriasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.listarUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Adicionar;
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuários";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // listarUsuáriosToolStripMenuItem
            // 
            this.listarUsuáriosToolStripMenuItem.Image = global::ProjetoDesenvolvimento.Properties.Resources.Buscar;
            this.listarUsuáriosToolStripMenuItem.Name = "listarUsuáriosToolStripMenuItem";
            this.listarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listarUsuáriosToolStripMenuItem.Text = "Listar usuários";
            this.listarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.listarUsuáriosToolStripMenuItem_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::ProjetoDesenvolvimento.Properties.Resources.ecocostafuck1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal | Loja EcoCosta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaPrincipal_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProdutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicarUmaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoSobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuáriosToolStripMenuItem;
    }
}