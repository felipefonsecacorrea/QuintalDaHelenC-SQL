namespace WindowsFormsApp2
{
    partial class FaturamentoForm5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturamentoForm5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_faturamento = new System.Windows.Forms.Label();
            this.rbtn_dia = new System.Windows.Forms.RadioButton();
            this.rbtn_mes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_ano = new System.Windows.Forms.RadioButton();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_pedidos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total_delivery = new System.Windows.Forms.TextBox();
            this.txt_totalMesa = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_delivery = new System.Windows.Forms.Label();
            this.lbl_TotalMesa = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_faturamento
            // 
            this.lbl_faturamento.AutoSize = true;
            this.lbl_faturamento.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faturamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_faturamento.Location = new System.Drawing.Point(237, 43);
            this.lbl_faturamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_faturamento.Name = "lbl_faturamento";
            this.lbl_faturamento.Size = new System.Drawing.Size(180, 23);
            this.lbl_faturamento.TabIndex = 6;
            this.lbl_faturamento.Text = "FATURAMENTO";
            // 
            // rbtn_dia
            // 
            this.rbtn_dia.AutoSize = true;
            this.rbtn_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_dia.Location = new System.Drawing.Point(6, 35);
            this.rbtn_dia.Name = "rbtn_dia";
            this.rbtn_dia.Size = new System.Drawing.Size(44, 17);
            this.rbtn_dia.TabIndex = 7;
            this.rbtn_dia.TabStop = true;
            this.rbtn_dia.Text = "Dia";
            this.rbtn_dia.UseVisualStyleBackColor = true;
            this.rbtn_dia.CheckedChanged += new System.EventHandler(this.rbtn_dia_CheckedChanged);
            // 
            // rbtn_mes
            // 
            this.rbtn_mes.AutoSize = true;
            this.rbtn_mes.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_mes.Location = new System.Drawing.Point(59, 35);
            this.rbtn_mes.Name = "rbtn_mes";
            this.rbtn_mes.Size = new System.Drawing.Size(48, 17);
            this.rbtn_mes.TabIndex = 8;
            this.rbtn_mes.TabStop = true;
            this.rbtn_mes.Text = "Mês";
            this.rbtn_mes.UseVisualStyleBackColor = false;
            this.rbtn_mes.CheckedChanged += new System.EventHandler(this.rbtn_mes_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_ano);
            this.groupBox1.Controls.Add(this.lbl_pesquisar);
            this.groupBox1.Controls.Add(this.rbtn_dia);
            this.groupBox1.Controls.Add(this.rbtn_mes);
            this.groupBox1.Location = new System.Drawing.Point(70, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_ano
            // 
            this.rbtn_ano.AutoSize = true;
            this.rbtn_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ano.Location = new System.Drawing.Point(115, 35);
            this.rbtn_ano.Name = "rbtn_ano";
            this.rbtn_ano.Size = new System.Drawing.Size(47, 17);
            this.rbtn_ano.TabIndex = 34;
            this.rbtn_ano.TabStop = true;
            this.rbtn_ano.Text = "Ano";
            this.rbtn_ano.UseVisualStyleBackColor = true;
            this.rbtn_ano.CheckedChanged += new System.EventHandler(this.rbtn_ano_CheckedChanged);
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar.Location = new System.Drawing.Point(6, 16);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(82, 16);
            this.lbl_pesquisar.TabIndex = 33;
            this.lbl_pesquisar.Text = "Pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "/";
            // 
            // txt_dia
            // 
            this.txt_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dia.Location = new System.Drawing.Point(274, 391);
            this.txt_dia.Multiline = true;
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(37, 32);
            this.txt_dia.TabIndex = 16;
            this.txt_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mes
            // 
            this.txt_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mes.Location = new System.Drawing.Point(328, 391);
            this.txt_mes.Multiline = true;
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(37, 33);
            this.txt_mes.TabIndex = 17;
            this.txt_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ano
            // 
            this.txt_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ano.Location = new System.Drawing.Point(382, 391);
            this.txt_ano.Multiline = true;
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(61, 33);
            this.txt_ano.TabIndex = 18;
            this.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ano";
            // 
            // lst_pedidos
            // 
            this.lst_pedidos.FormattingEnabled = true;
            this.lst_pedidos.Location = new System.Drawing.Point(35, 111);
            this.lst_pedidos.Name = "lst_pedidos";
            this.lst_pedidos.Size = new System.Drawing.Size(492, 264);
            this.lst_pedidos.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 33);
            this.label6.TabIndex = 26;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = "=";
            // 
            // txt_total_delivery
            // 
            this.txt_total_delivery.Enabled = false;
            this.txt_total_delivery.Location = new System.Drawing.Point(533, 172);
            this.txt_total_delivery.Multiline = true;
            this.txt_total_delivery.Name = "txt_total_delivery";
            this.txt_total_delivery.Size = new System.Drawing.Size(95, 33);
            this.txt_total_delivery.TabIndex = 28;
            // 
            // txt_totalMesa
            // 
            this.txt_totalMesa.Enabled = false;
            this.txt_totalMesa.Location = new System.Drawing.Point(533, 247);
            this.txt_totalMesa.Multiline = true;
            this.txt_totalMesa.Name = "txt_totalMesa";
            this.txt_totalMesa.Size = new System.Drawing.Size(95, 33);
            this.txt_totalMesa.TabIndex = 29;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(533, 319);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(104, 33);
            this.txt_total.TabIndex = 30;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(530, 424);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(101, 35);
            this.btn_sair.TabIndex = 31;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_delivery
            // 
            this.lbl_delivery.AutoSize = true;
            this.lbl_delivery.Location = new System.Drawing.Point(533, 156);
            this.lbl_delivery.Name = "lbl_delivery";
            this.lbl_delivery.Size = new System.Drawing.Size(45, 13);
            this.lbl_delivery.TabIndex = 32;
            this.lbl_delivery.Text = "Delivery";
            // 
            // lbl_TotalMesa
            // 
            this.lbl_TotalMesa.AutoSize = true;
            this.lbl_TotalMesa.Location = new System.Drawing.Point(533, 231);
            this.lbl_TotalMesa.Name = "lbl_TotalMesa";
            this.lbl_TotalMesa.Size = new System.Drawing.Size(33, 13);
            this.lbl_TotalMesa.TabIndex = 33;
            this.lbl_TotalMesa.Text = "Mesa";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(533, 303);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 34;
            this.lbl_total.Text = "Total";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ok.Location = new System.Drawing.Point(449, 391);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(44, 35);
            this.btn_ok.TabIndex = 35;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.Location = new System.Drawing.Point(548, 111);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(67, 35);
            this.btn_limpar.TabIndex = 36;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // FaturamentoForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(645, 471);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_TotalMesa);
            this.Controls.Add(this.lbl_delivery);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_totalMesa);
            this.Controls.Add(this.txt_total_delivery);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_pedidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_faturamento);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FaturamentoForm5";
            this.Text = "Faturamento";
            this.Load += new System.EventHandler(this.FaturamentoForm5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_faturamento;
        private System.Windows.Forms.RadioButton rbtn_dia;
        private System.Windows.Forms.RadioButton rbtn_mes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_ano;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_pedidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total_delivery;
        private System.Windows.Forms.TextBox txt_totalMesa;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_delivery;
        private System.Windows.Forms.Label lbl_TotalMesa;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_limpar;
    }
}