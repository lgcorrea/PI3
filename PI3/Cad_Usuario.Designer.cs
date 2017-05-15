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
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.checkBox_UserAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label_User_inativo = new System.Windows.Forms.Label();
            this.CbxTipodePerfil = new System.Windows.Forms.ComboBox();
            this.label_tipoPerfil = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_NovoUsuario = new System.Windows.Forms.Button();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_sair.FlatAppearance.BorderSize = 2;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sair.Location = new System.Drawing.Point(784, 329);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 34);
            this.bt_sair.TabIndex = 3;
            this.bt_sair.Text = "&Sair";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSenhaUser);
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
            this.groupBox1.Location = new System.Drawing.Point(460, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros de Usuários";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha:";
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Location = new System.Drawing.Point(105, 120);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(180, 25);
            this.txtSenhaUser.TabIndex = 3;
            this.txtSenhaUser.TextChanged += new System.EventHandler(this.txtSenhaUser_TextChanged);
            // 
            // checkBox_UserAtivo
            // 
            this.checkBox_UserAtivo.AutoSize = true;
            this.checkBox_UserAtivo.Location = new System.Drawing.Point(347, 162);
            this.checkBox_UserAtivo.Name = "checkBox_UserAtivo";
            this.checkBox_UserAtivo.Size = new System.Drawing.Size(15, 14);
            this.checkBox_UserAtivo.TabIndex = 6;
            this.checkBox_UserAtivo.UseVisualStyleBackColor = true;
            this.checkBox_UserAtivo.CheckedChanged += new System.EventHandler(this.checkBox_UserAtivo_CheckedChanged);
            this.checkBox_UserAtivo.Click += new System.EventHandler(this.checkBox_UserAtivo_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 25);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged_1);
            // 
            // label_User_inativo
            // 
            this.label_User_inativo.AutoSize = true;
            this.label_User_inativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_User_inativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_User_inativo.Location = new System.Drawing.Point(239, 159);
            this.label_User_inativo.Name = "label_User_inativo";
            this.label_User_inativo.Size = new System.Drawing.Size(93, 17);
            this.label_User_inativo.TabIndex = 7;
            this.label_User_inativo.Text = "Usuário Ativo:";
            // 
            // CbxTipodePerfil
            // 
            this.CbxTipodePerfil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CbxTipodePerfil.FormattingEnabled = true;
            this.CbxTipodePerfil.Location = new System.Drawing.Point(105, 156);
            this.CbxTipodePerfil.Name = "CbxTipodePerfil";
            this.CbxTipodePerfil.Size = new System.Drawing.Size(128, 25);
            this.CbxTipodePerfil.TabIndex = 5;
            this.CbxTipodePerfil.SelectedIndexChanged += new System.EventHandler(this.CbxTipodePerfil_SelectedIndexChanged);
            // 
            // label_tipoPerfil
            // 
            this.label_tipoPerfil.AutoSize = true;
            this.label_tipoPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_tipoPerfil.Location = new System.Drawing.Point(17, 159);
            this.label_tipoPerfil.Name = "label_tipoPerfil";
            this.label_tipoPerfil.Size = new System.Drawing.Size(90, 17);
            this.label_tipoPerfil.TabIndex = 6;
            this.label_tipoPerfil.Text = "Tipo de Perfil:";
            this.label_tipoPerfil.Click += new System.EventHandler(this.label_tipoPerfil_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(105, 89);
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
            this.label_Login.Location = new System.Drawing.Point(63, 92);
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
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Alterar.FlatAppearance.BorderSize = 2;
            this.bt_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Alterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Alterar.Location = new System.Drawing.Point(689, 329);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(73, 34);
            this.bt_Alterar.TabIndex = 7;
            this.bt_Alterar.Text = "Alterar ";
            this.bt_Alterar.UseVisualStyleBackColor = false;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
            // 
            // bt_NovoUsuario
            // 
            this.bt_NovoUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_NovoUsuario.FlatAppearance.BorderSize = 2;
            this.bt_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_NovoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NovoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_NovoUsuario.Location = new System.Drawing.Point(12, 329);
            this.bt_NovoUsuario.Name = "bt_NovoUsuario";
            this.bt_NovoUsuario.Size = new System.Drawing.Size(106, 34);
            this.bt_NovoUsuario.TabIndex = 13;
            this.bt_NovoUsuario.Text = "Novo Usuário";
            this.bt_NovoUsuario.UseVisualStyleBackColor = false;
            this.bt_NovoUsuario.Click += new System.EventHandler(this.bt_NovoUsuario_Click);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToOrderColumns = true;
            this.dgUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(12, 75);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(372, 229);
            this.dgUsuarios.TabIndex = 14;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick);
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Pesquisar.FlatAppearance.BorderSize = 2;
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Pesquisar.Location = new System.Drawing.Point(12, 22);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(106, 34);
            this.btn_Pesquisar.TabIndex = 15;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(881, 445);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.bt_NovoUsuario);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cadastro_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_NovoUsuario;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}