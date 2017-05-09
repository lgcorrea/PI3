namespace PI3
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.label_Nome_produto = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_vlr_produto = new System.Windows.Forms.Label();
            this.label_qtdMinima = new System.Windows.Forms.Label();
            this.label_qtdDisponivel = new System.Windows.Forms.Label();
            this.label_descontoProd = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQtdMinProd = new System.Windows.Forms.TextBox();
            this.txtQtdDispProd = new System.Windows.Forms.TextBox();
            this.txtDescPromocao = new System.Windows.Forms.TextBox();
            this.comboBoxCategProd = new System.Windows.Forms.ComboBox();
            this.pictureProduto = new System.Windows.Forms.PictureBox();
            this.imgProd = new System.Windows.Forms.Label();
            this.Checkbox_prodInativo = new System.Windows.Forms.CheckBox();
            this.bt_categoria = new System.Windows.Forms.PictureBox();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.dgwProduto = new System.Windows.Forms.DataGridView();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtPesquisaProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nome_produto
            // 
            this.label_Nome_produto.AutoSize = true;
            this.label_Nome_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nome_produto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Nome_produto.Location = new System.Drawing.Point(9, 286);
            this.label_Nome_produto.Name = "label_Nome_produto";
            this.label_Nome_produto.Size = new System.Drawing.Size(103, 15);
            this.label_Nome_produto.TabIndex = 4;
            this.label_Nome_produto.Text = "Nome do Produto";
            this.label_Nome_produto.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descricao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_descricao.Location = new System.Drawing.Point(9, 334);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(59, 15);
            this.label_descricao.TabIndex = 8;
            this.label_descricao.Text = "Descrição";
            this.label_descricao.Click += new System.EventHandler(this.label_descricao_Click);
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_categoria.Location = new System.Drawing.Point(350, 286);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(57, 15);
            this.label_categoria.TabIndex = 6;
            this.label_categoria.Text = "Categoria";
            // 
            // label_vlr_produto
            // 
            this.label_vlr_produto.AutoSize = true;
            this.label_vlr_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vlr_produto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_vlr_produto.Location = new System.Drawing.Point(9, 383);
            this.label_vlr_produto.Name = "label_vlr_produto";
            this.label_vlr_produto.Size = new System.Drawing.Size(80, 15);
            this.label_vlr_produto.TabIndex = 11;
            this.label_vlr_produto.Text = "Valor Unitário";
            this.label_vlr_produto.Click += new System.EventHandler(this.label_vlr_produto_Click);
            // 
            // label_qtdMinima
            // 
            this.label_qtdMinima.AutoSize = true;
            this.label_qtdMinima.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtdMinima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_qtdMinima.Location = new System.Drawing.Point(9, 444);
            this.label_qtdMinima.Name = "label_qtdMinima";
            this.label_qtdMinima.Size = new System.Drawing.Size(71, 15);
            this.label_qtdMinima.TabIndex = 15;
            this.label_qtdMinima.Text = "Qtd Mínima";
            this.label_qtdMinima.Click += new System.EventHandler(this.label_qtdMinima_Click);
            // 
            // label_qtdDisponivel
            // 
            this.label_qtdDisponivel.AutoSize = true;
            this.label_qtdDisponivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtdDisponivel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_qtdDisponivel.Location = new System.Drawing.Point(108, 444);
            this.label_qtdDisponivel.Name = "label_qtdDisponivel";
            this.label_qtdDisponivel.Size = new System.Drawing.Size(86, 15);
            this.label_qtdDisponivel.TabIndex = 17;
            this.label_qtdDisponivel.Text = "Qtd Disponível";
            // 
            // label_descontoProd
            // 
            this.label_descontoProd.AutoSize = true;
            this.label_descontoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descontoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_descontoProd.Location = new System.Drawing.Point(164, 383);
            this.label_descontoProd.Name = "label_descontoProd";
            this.label_descontoProd.Size = new System.Drawing.Size(116, 15);
            this.label_descontoProd.TabIndex = 13;
            this.label_descontoProd.Text = "Desconto Promoção";
            this.label_descontoProd.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 302);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(268, 20);
            this.txtNomeProduto.TabIndex = 5;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(12, 350);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(268, 20);
            this.txtDescricaoProduto.TabIndex = 9;
            this.txtDescricaoProduto.TextChanged += new System.EventHandler(this.txtDescricaoProduto_TextChanged);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(12, 399);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(100, 20);
            this.txtValorProduto.TabIndex = 12;
            this.txtValorProduto.TextChanged += new System.EventHandler(this.txtValorProduto_TextChanged);
            // 
            // txtQtdMinProd
            // 
            this.txtQtdMinProd.Location = new System.Drawing.Point(12, 460);
            this.txtQtdMinProd.Name = "txtQtdMinProd";
            this.txtQtdMinProd.Size = new System.Drawing.Size(52, 20);
            this.txtQtdMinProd.TabIndex = 16;
            this.txtQtdMinProd.TextChanged += new System.EventHandler(this.txtQtdMinProd_TextChanged);
            // 
            // txtQtdDispProd
            // 
            this.txtQtdDispProd.Location = new System.Drawing.Point(111, 460);
            this.txtQtdDispProd.Name = "txtQtdDispProd";
            this.txtQtdDispProd.Size = new System.Drawing.Size(52, 20);
            this.txtQtdDispProd.TabIndex = 18;
            this.txtQtdDispProd.TextChanged += new System.EventHandler(this.txtQtdDispProd_TextChanged);
            // 
            // txtDescPromocao
            // 
            this.txtDescPromocao.Location = new System.Drawing.Point(167, 399);
            this.txtDescPromocao.Name = "txtDescPromocao";
            this.txtDescPromocao.Size = new System.Drawing.Size(113, 20);
            this.txtDescPromocao.TabIndex = 14;
            this.txtDescPromocao.TextChanged += new System.EventHandler(this.txtDescPromocao_TextChanged);
            // 
            // comboBoxCategProd
            // 
            this.comboBoxCategProd.FormattingEnabled = true;
            this.comboBoxCategProd.Location = new System.Drawing.Point(353, 301);
            this.comboBoxCategProd.Name = "comboBoxCategProd";
            this.comboBoxCategProd.Size = new System.Drawing.Size(147, 21);
            this.comboBoxCategProd.TabIndex = 7;
            // 
            // pictureProduto
            // 
            this.pictureProduto.Location = new System.Drawing.Point(616, 325);
            this.pictureProduto.Name = "pictureProduto";
            this.pictureProduto.Size = new System.Drawing.Size(175, 113);
            this.pictureProduto.TabIndex = 18;
            this.pictureProduto.TabStop = false;
            this.pictureProduto.Click += new System.EventHandler(this.pictureProduto_Click);
            // 
            // imgProd
            // 
            this.imgProd.AutoSize = true;
            this.imgProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgProd.Location = new System.Drawing.Point(613, 296);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(114, 15);
            this.imgProd.TabIndex = 19;
            this.imgProd.Text = "Imagem do Produto";
            this.imgProd.Click += new System.EventHandler(this.imgProd_Click);
            // 
            // Checkbox_prodInativo
            // 
            this.Checkbox_prodInativo.AutoSize = true;
            this.Checkbox_prodInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_prodInativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Checkbox_prodInativo.Location = new System.Drawing.Point(353, 334);
            this.Checkbox_prodInativo.Name = "Checkbox_prodInativo";
            this.Checkbox_prodInativo.Size = new System.Drawing.Size(108, 19);
            this.Checkbox_prodInativo.TabIndex = 10;
            this.Checkbox_prodInativo.Text = "Produto Inativo";
            this.Checkbox_prodInativo.UseVisualStyleBackColor = true;
            this.Checkbox_prodInativo.CheckedChanged += new System.EventHandler(this.Checkbox_prodInativo_CheckedChanged);
            // 
            // bt_categoria
            // 
            this.bt_categoria.Image = ((System.Drawing.Image)(resources.GetObject("bt_categoria.Image")));
            this.bt_categoria.Location = new System.Drawing.Point(507, 301);
            this.bt_categoria.Name = "bt_categoria";
            this.bt_categoria.Size = new System.Drawing.Size(36, 21);
            this.bt_categoria.TabIndex = 21;
            this.bt_categoria.TabStop = false;
            this.bt_categoria.Click += new System.EventHandler(this.bt_categoria_Click);
            // 
            // bt_Pesquisar
            // 
            this.bt_Pesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Pesquisar.FlatAppearance.BorderSize = 2;
            this.bt_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Pesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Pesquisar.Location = new System.Drawing.Point(717, 9);
            this.bt_Pesquisar.Name = "bt_Pesquisar";
            this.bt_Pesquisar.Size = new System.Drawing.Size(91, 35);
            this.bt_Pesquisar.TabIndex = 2;
            this.bt_Pesquisar.Text = "Pesquisar";
            this.bt_Pesquisar.UseVisualStyleBackColor = false;
            this.bt_Pesquisar.Click += new System.EventHandler(this.bt_Pesquisar_Click);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Salvar.FlatAppearance.BorderSize = 2;
            this.bt_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salvar.Location = new System.Drawing.Point(517, 444);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(91, 35);
            this.bt_Salvar.TabIndex = 20;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_excluir.FlatAppearance.BorderSize = 2;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(616, 444);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(91, 35);
            this.bt_excluir.TabIndex = 21;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_sair.FlatAppearance.BorderSize = 2;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(715, 444);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(91, 35);
            this.bt_sair.TabIndex = 22;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // dgwProduto
            // 
            this.dgwProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduto.Location = new System.Drawing.Point(12, 50);
            this.dgwProduto.Name = "dgwProduto";
            this.dgwProduto.Size = new System.Drawing.Size(794, 233);
            this.dgwProduto.TabIndex = 0;
            this.dgwProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduto_CellContentClick);
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(9, 22);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(110, 13);
            this.lbProduto.TabIndex = 0;
            this.lbProduto.Text = "Codigo/NomeProduto";
            // 
            // txtPesquisaProd
            // 
            this.txtPesquisaProd.Location = new System.Drawing.Point(125, 19);
            this.txtPesquisaProd.Name = "txtPesquisaProd";
            this.txtPesquisaProd.Size = new System.Drawing.Size(582, 20);
            this.txtPesquisaProd.TabIndex = 1;
            this.txtPesquisaProd.TextChanged += new System.EventHandler(this.txtPesquisaProd_TextChanged);
            // 
            // Produtos
            // 
            this.AcceptButton = this.bt_Salvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.Controls.Add(this.txtPesquisaProd);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.dgwProduto);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Pesquisar);
            this.Controls.Add(this.bt_categoria);
            this.Controls.Add(this.Checkbox_prodInativo);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.pictureProduto);
            this.Controls.Add(this.comboBoxCategProd);
            this.Controls.Add(this.txtDescPromocao);
            this.Controls.Add(this.txtQtdDispProd);
            this.Controls.Add(this.txtQtdMinProd);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label_descontoProd);
            this.Controls.Add(this.label_qtdDisponivel);
            this.Controls.Add(this.label_qtdMinima);
            this.Controls.Add(this.label_vlr_produto);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.label_Nome_produto);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nome_produto;
        private System.Windows.Forms.Label label_descricao;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label_vlr_produto;
        private System.Windows.Forms.Label label_qtdMinima;
        private System.Windows.Forms.Label label_qtdDisponivel;
        private System.Windows.Forms.Label label_descontoProd;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.TextBox txtQtdMinProd;
        private System.Windows.Forms.TextBox txtQtdDispProd;
        private System.Windows.Forms.TextBox txtDescPromocao;
        private System.Windows.Forms.ComboBox comboBoxCategProd;
        private System.Windows.Forms.PictureBox pictureProduto;
        private System.Windows.Forms.Label imgProd;
        private System.Windows.Forms.CheckBox Checkbox_prodInativo;
        private System.Windows.Forms.PictureBox bt_categoria;
        private System.Windows.Forms.Button bt_Pesquisar;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.DataGridView dgwProduto;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.TextBox txtPesquisaProd;
    }
}