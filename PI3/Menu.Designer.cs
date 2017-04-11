namespace PI3
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.bt_Estoque = new System.Windows.Forms.Button();
            this.bt_Vendas = new System.Windows.Forms.Button();
            this.bt_Produtos = new System.Windows.Forms.Button();
            this.bt_Config = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.clientesToolStripMenuItem.Text = "Cadastros";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.clientesToolStripMenuItem1.Text = "&Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Checked = true;
            this.usuáriosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem1,
            this.historicoDePedidosToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pedidosToolStripMenuItem.Text = "Vendas";
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.pedidosToolStripMenuItem1.Text = "Cadastro de Pedidos";
            this.pedidosToolStripMenuItem1.Click += new System.EventHandler(this.pedidosToolStripMenuItem1_Click);
            // 
            // historicoDePedidosToolStripMenuItem
            // 
            this.historicoDePedidosToolStripMenuItem.Name = "historicoDePedidosToolStripMenuItem";
            this.historicoDePedidosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.historicoDePedidosToolStripMenuItem.Text = "Historico de Pedidos";
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Clientes.FlatAppearance.BorderSize = 2;
            this.bt_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clientes.ForeColor = System.Drawing.Color.White;
            this.bt_Clientes.Location = new System.Drawing.Point(12, 49);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(152, 96);
            this.bt_Clientes.TabIndex = 8;
            this.bt_Clientes.Text = "Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = false;
            this.bt_Clientes.Click += new System.EventHandler(this.bt_Clientes_Click);
            // 
            // bt_Estoque
            // 
            this.bt_Estoque.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Estoque.FlatAppearance.BorderSize = 2;
            this.bt_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Estoque.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Estoque.ForeColor = System.Drawing.Color.White;
            this.bt_Estoque.Location = new System.Drawing.Point(203, 186);
            this.bt_Estoque.Name = "bt_Estoque";
            this.bt_Estoque.Size = new System.Drawing.Size(152, 96);
            this.bt_Estoque.TabIndex = 10;
            this.bt_Estoque.Text = "Estoque";
            this.bt_Estoque.UseVisualStyleBackColor = false;
            this.bt_Estoque.Click += new System.EventHandler(this.bt_Estoque_Click);
            // 
            // bt_Vendas
            // 
            this.bt_Vendas.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Vendas.FlatAppearance.BorderSize = 2;
            this.bt_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Vendas.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Vendas.ForeColor = System.Drawing.Color.White;
            this.bt_Vendas.Location = new System.Drawing.Point(203, 49);
            this.bt_Vendas.Name = "bt_Vendas";
            this.bt_Vendas.Size = new System.Drawing.Size(152, 96);
            this.bt_Vendas.TabIndex = 11;
            this.bt_Vendas.Text = "Vendas";
            this.bt_Vendas.UseVisualStyleBackColor = false;
            this.bt_Vendas.Click += new System.EventHandler(this.bt_Vendas_Click);
            // 
            // bt_Produtos
            // 
            this.bt_Produtos.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Produtos.FlatAppearance.BorderSize = 2;
            this.bt_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Produtos.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Produtos.ForeColor = System.Drawing.Color.White;
            this.bt_Produtos.Location = new System.Drawing.Point(12, 186);
            this.bt_Produtos.Name = "bt_Produtos";
            this.bt_Produtos.Size = new System.Drawing.Size(152, 96);
            this.bt_Produtos.TabIndex = 12;
            this.bt_Produtos.Text = "Produtos";
            this.bt_Produtos.UseVisualStyleBackColor = false;
            this.bt_Produtos.Click += new System.EventHandler(this.bt_Produtos_Click);
            // 
            // bt_Config
            // 
            this.bt_Config.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Config.FlatAppearance.BorderSize = 2;
            this.bt_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Config.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Config.ForeColor = System.Drawing.Color.White;
            this.bt_Config.Location = new System.Drawing.Point(12, 323);
            this.bt_Config.Name = "bt_Config";
            this.bt_Config.Size = new System.Drawing.Size(152, 96);
            this.bt_Config.TabIndex = 13;
            this.bt_Config.Text = "Config.";
            this.bt_Config.UseVisualStyleBackColor = false;
            this.bt_Config.Click += new System.EventHandler(this.bt_Config_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_sair.FlatAppearance.BorderSize = 2;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Location = new System.Drawing.Point(658, 323);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(152, 96);
            this.bt_sair.TabIndex = 14;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(842, 431);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_Config);
            this.Controls.Add(this.bt_Produtos);
            this.Controls.Add(this.bt_Vendas);
            this.Controls.Add(this.bt_Estoque);
            this.Controls.Add(this.bt_Clientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlde Vendas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historicoDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.Button bt_Estoque;
        private System.Windows.Forms.Button bt_Vendas;
        private System.Windows.Forms.Button bt_Produtos;
        private System.Windows.Forms.Button bt_Config;
        private System.Windows.Forms.Button bt_sair;
    }
}