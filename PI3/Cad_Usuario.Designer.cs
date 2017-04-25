namespace PI3
{
    partial class Cadastro_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Usuario));
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_mudaSenha = new System.Windows.Forms.Button();
            this.checkBox_UserAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label_User_inativo = new System.Windows.Forms.Label();
            this.CbxTipodePerfil = new System.Windows.Forms.ComboBox();
            this.label_tipoPerfil = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barraNavegacao = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bt_NavegacaoPrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_NavegacaoNext = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraNavegacao)).BeginInit();
            this.barraNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_salvar.FlatAppearance.BorderSize = 2;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_salvar.Location = new System.Drawing.Point(12, 259);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 34);
            this.bt_salvar.TabIndex = 0;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_excluir.FlatAppearance.BorderSize = 2;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_excluir.Location = new System.Drawing.Point(238, 259);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 34);
            this.bt_excluir.TabIndex = 1;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_sair.FlatAppearance.BorderSize = 2;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sair.Location = new System.Drawing.Point(336, 259);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 34);
            this.bt_sair.TabIndex = 3;
            this.bt_sair.Text = "&Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_mudaSenha);
            this.groupBox1.Controls.Add(this.checkBox_UserAtivo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label_User_inativo);
            this.groupBox1.Controls.Add(this.CbxTipodePerfil);
            this.groupBox1.Controls.Add(this.label_tipoPerfil);
            this.groupBox1.Controls.Add(this.TxtLogin);
            this.groupBox1.Controls.Add(this.label_Login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros de Usuários";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_mudaSenha
            // 
            this.bt_mudaSenha.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_mudaSenha.FlatAppearance.BorderSize = 2;
            this.bt_mudaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mudaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mudaSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_mudaSenha.Location = new System.Drawing.Point(263, 143);
            this.bt_mudaSenha.Name = "bt_mudaSenha";
            this.bt_mudaSenha.Size = new System.Drawing.Size(103, 34);
            this.bt_mudaSenha.TabIndex = 6;
            this.bt_mudaSenha.Text = "Mudar Senha";
            this.bt_mudaSenha.UseVisualStyleBackColor = false;
            this.bt_mudaSenha.Click += new System.EventHandler(this.bt_mudaSenha_Click);
            // 
            // checkBox_UserAtivo
            // 
            this.checkBox_UserAtivo.AutoSize = true;
            this.checkBox_UserAtivo.Location = new System.Drawing.Point(345, 104);
            this.checkBox_UserAtivo.Name = "checkBox_UserAtivo";
            this.checkBox_UserAtivo.Size = new System.Drawing.Size(15, 14);
            this.checkBox_UserAtivo.TabIndex = 12;
            this.checkBox_UserAtivo.UseVisualStyleBackColor = true;
            this.checkBox_UserAtivo.CheckedChanged += new System.EventHandler(this.checkBox_UserAtivo_CheckedChanged);
            this.checkBox_UserAtivo.Click += new System.EventHandler(this.checkBox_UserAtivo_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 25);
            this.txtNome.TabIndex = 9;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged_1);
            // 
            // label_User_inativo
            // 
            this.label_User_inativo.AutoSize = true;
            this.label_User_inativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User_inativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_User_inativo.Location = new System.Drawing.Point(237, 102);
            this.label_User_inativo.Name = "label_User_inativo";
            this.label_User_inativo.Size = new System.Drawing.Size(102, 17);
            this.label_User_inativo.TabIndex = 7;
            this.label_User_inativo.Text = "Usuário inativo:";
            // 
            // CbxTipodePerfil
            // 
            this.CbxTipodePerfil.FormattingEnabled = true;
            this.CbxTipodePerfil.Items.AddRange(new object[] {
            "Estoquista",
            "Administrador"});
            this.CbxTipodePerfil.Location = new System.Drawing.Point(103, 99);
            this.CbxTipodePerfil.Name = "CbxTipodePerfil";
            this.CbxTipodePerfil.Size = new System.Drawing.Size(128, 25);
            this.CbxTipodePerfil.TabIndex = 4;
            this.CbxTipodePerfil.SelectedIndexChanged += new System.EventHandler(this.CbxTipodePerfil_SelectedIndexChanged);
            // 
            // label_tipoPerfil
            // 
            this.label_tipoPerfil.AutoSize = true;
            this.label_tipoPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_tipoPerfil.Location = new System.Drawing.Point(15, 102);
            this.label_tipoPerfil.Name = "label_tipoPerfil";
            this.label_tipoPerfil.Size = new System.Drawing.Size(90, 17);
            this.label_tipoPerfil.TabIndex = 6;
            this.label_tipoPerfil.Text = "Tipo de Perfil:";
            this.label_tipoPerfil.Click += new System.EventHandler(this.label_tipoPerfil_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(103, 62);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(263, 25);
            this.TxtLogin.TabIndex = 2;
            this.TxtLogin.TextChanged += new System.EventHandler(this.TxtLogin_TextChanged);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Login.Location = new System.Drawing.Point(61, 65);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(44, 17);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // barraNavegacao
            // 
            this.barraNavegacao.AddNewItem = null;
            this.barraNavegacao.CountItem = this.bindingNavigatorCountItem;
            this.barraNavegacao.DeleteItem = null;
            this.barraNavegacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_NavegacaoPrevious,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bt_NavegacaoNext,
            this.bindingNavigatorSeparator2});
            this.barraNavegacao.Location = new System.Drawing.Point(0, 0);
            this.barraNavegacao.MoveFirstItem = null;
            this.barraNavegacao.MoveLastItem = null;
            this.barraNavegacao.MoveNextItem = this.bt_NavegacaoNext;
            this.barraNavegacao.MovePreviousItem = this.bt_NavegacaoPrevious;
            this.barraNavegacao.Name = "barraNavegacao";
            this.barraNavegacao.PositionItem = this.bindingNavigatorPositionItem;
            this.barraNavegacao.Size = new System.Drawing.Size(439, 25);
            this.barraNavegacao.TabIndex = 6;
            this.barraNavegacao.Text = "barraNavegacao";
            this.barraNavegacao.RefreshItems += new System.EventHandler(this.barraNavegacao_RefreshItems);
            this.barraNavegacao.Click += new System.EventHandler(this.barraNavegacao_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bt_NavegacaoPrevious
            // 
            this.bt_NavegacaoPrevious.Checked = true;
            this.bt_NavegacaoPrevious.CheckOnClick = true;
            this.bt_NavegacaoPrevious.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bt_NavegacaoPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_NavegacaoPrevious.Image = ((System.Drawing.Image)(resources.GetObject("bt_NavegacaoPrevious.Image")));
            this.bt_NavegacaoPrevious.Name = "bt_NavegacaoPrevious";
            this.bt_NavegacaoPrevious.RightToLeftAutoMirrorImage = true;
            this.bt_NavegacaoPrevious.Size = new System.Drawing.Size(23, 22);
            this.bt_NavegacaoPrevious.Text = "Move previous";
            this.bt_NavegacaoPrevious.Click += new System.EventHandler(this.bt_NavegacaoPrevious_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_NavegacaoNext
            // 
            this.bt_NavegacaoNext.Checked = true;
            this.bt_NavegacaoNext.CheckOnClick = true;
            this.bt_NavegacaoNext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bt_NavegacaoNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_NavegacaoNext.Image = ((System.Drawing.Image)(resources.GetObject("bt_NavegacaoNext.Image")));
            this.bt_NavegacaoNext.Name = "bt_NavegacaoNext";
            this.bt_NavegacaoNext.RightToLeftAutoMirrorImage = true;
            this.bt_NavegacaoNext.Size = new System.Drawing.Size(23, 22);
            this.bt_NavegacaoNext.Text = "Move next";
            this.bt_NavegacaoNext.Click += new System.EventHandler(this.bt_NavegacaoNext_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.barraNavegacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_salvar);
            this.Name = "Cadastro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Usuário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraNavegacao)).EndInit();
            this.barraNavegacao.ResumeLayout(false);
            this.barraNavegacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_tipoPerfil;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipodePerfil;
        private System.Windows.Forms.Label label_User_inativo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox checkBox_UserAtivo;
        private System.Windows.Forms.Button bt_mudaSenha;
        private System.Windows.Forms.BindingNavigator barraNavegacao;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bt_NavegacaoPrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bt_NavegacaoNext;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}