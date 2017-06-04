namespace PI3
{
    partial class Estoque
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
            this.label_categoria = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtQtdDispProd = new System.Windows.Forms.TextBox();
            this.txtQtdMinProd = new System.Windows.Forms.TextBox();
            this.label_qtdDisponivel = new System.Windows.Forms.Label();
            this.label_qtdMinima = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Saida = new System.Windows.Forms.CheckBox();
            this.cbox_entrada = new System.Windows.Forms.CheckBox();
            this.txt_personalizado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_categoria.Location = new System.Drawing.Point(-1, 77);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(53, 15);
            this.label_categoria.TabIndex = 7;
            this.label_categoria.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(2, 95);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(268, 20);
            this.txtNomeProduto.TabIndex = 8;
            // 
            // txtQtdDispProd
            // 
            this.txtQtdDispProd.Location = new System.Drawing.Point(153, 143);
            this.txtQtdDispProd.Name = "txtQtdDispProd";
            this.txtQtdDispProd.ReadOnly = true;
            this.txtQtdDispProd.Size = new System.Drawing.Size(70, 20);
            this.txtQtdDispProd.TabIndex = 22;
            // 
            // txtQtdMinProd
            // 
            this.txtQtdMinProd.Location = new System.Drawing.Point(31, 143);
            this.txtQtdMinProd.Name = "txtQtdMinProd";
            this.txtQtdMinProd.Size = new System.Drawing.Size(77, 20);
            this.txtQtdMinProd.TabIndex = 20;
            // 
            // label_qtdDisponivel
            // 
            this.label_qtdDisponivel.AutoSize = true;
            this.label_qtdDisponivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtdDisponivel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_qtdDisponivel.Location = new System.Drawing.Point(150, 127);
            this.label_qtdDisponivel.Name = "label_qtdDisponivel";
            this.label_qtdDisponivel.Size = new System.Drawing.Size(86, 15);
            this.label_qtdDisponivel.TabIndex = 21;
            this.label_qtdDisponivel.Text = "Qtd Disponível";
            // 
            // label_qtdMinima
            // 
            this.label_qtdMinima.AutoSize = true;
            this.label_qtdMinima.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtdMinima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_qtdMinima.Location = new System.Drawing.Point(28, 127);
            this.label_qtdMinima.Name = "label_qtdMinima";
            this.label_qtdMinima.Size = new System.Drawing.Size(71, 15);
            this.label_qtdMinima.TabIndex = 19;
            this.label_qtdMinima.Text = "Qtd Mínima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 23;
            // 
            // cbox_Saida
            // 
            this.cbox_Saida.AutoSize = true;
            this.cbox_Saida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Saida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbox_Saida.Location = new System.Drawing.Point(174, 41);
            this.cbox_Saida.Name = "cbox_Saida";
            this.cbox_Saida.Size = new System.Drawing.Size(55, 19);
            this.cbox_Saida.TabIndex = 24;
            this.cbox_Saida.Text = "Saída";
            this.cbox_Saida.UseVisualStyleBackColor = true;
            this.cbox_Saida.Click += new System.EventHandler(this.cbox_Saida_CheckedChanged_1);
            // 
            // cbox_entrada
            // 
            this.cbox_entrada.AutoSize = true;
            this.cbox_entrada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_entrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbox_entrada.Location = new System.Drawing.Point(59, 41);
            this.cbox_entrada.Name = "cbox_entrada";
            this.cbox_entrada.Size = new System.Drawing.Size(66, 19);
            this.cbox_entrada.TabIndex = 25;
            this.cbox_entrada.Text = "Entrada";
            this.cbox_entrada.UseVisualStyleBackColor = true;
            this.cbox_entrada.Click += new System.EventHandler(this.cbox_entrada_CheckedChanged_1);
            // 
            // txt_personalizado
            // 
            this.txt_personalizado.AutoSize = true;
            this.txt_personalizado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personalizado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_personalizado.Location = new System.Drawing.Point(8, 9);
            this.txt_personalizado.Name = "txt_personalizado";
            this.txt_personalizado.Size = new System.Drawing.Size(100, 15);
            this.txt_personalizado.TabIndex = 26;
            this.txt_personalizado.Text = "txt_personalizado";
            this.txt_personalizado.BindingContextChanged += new System.EventHandler(this.txt_personalizado_Click);
            this.txt_personalizado.TextChanged += new System.EventHandler(this.txt_personalizado_Click);
            this.txt_personalizado.Click += new System.EventHandler(this.txt_personalizado_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_personalizado);
            this.Controls.Add(this.cbox_entrada);
            this.Controls.Add(this.cbox_Saida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdDispProd);
            this.Controls.Add(this.txtQtdMinProd);
            this.Controls.Add(this.label_qtdDisponivel);
            this.Controls.Add(this.label_qtdMinima);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label_categoria);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtQtdDispProd;
        private System.Windows.Forms.TextBox txtQtdMinProd;
        private System.Windows.Forms.Label label_qtdDisponivel;
        private System.Windows.Forms.Label label_qtdMinima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbox_Saida;
        private System.Windows.Forms.CheckBox cbox_entrada;
        private System.Windows.Forms.Label txt_personalizado;
    }
}