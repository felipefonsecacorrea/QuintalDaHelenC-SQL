namespace WindowsFormsApp2
{
    partial class FormComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComanda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_comanda = new System.Windows.Forms.Label();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.cbx_lista_mesa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_lista_kit = new System.Windows.Forms.ComboBox();
            this.lbl_kit = new System.Windows.Forms.Label();
            this.lbl_porcoes = new System.Windows.Forms.Label();
            this.cbx_lista_porcoes = new System.Windows.Forms.ComboBox();
            this.lbl_sobremesa = new System.Windows.Forms.Label();
            this.cbx_lista_sobremesas = new System.Windows.Forms.ComboBox();
            this.lbl_bebidas = new System.Windows.Forms.Label();
            this.cbx_list_bebidas = new System.Windows.Forms.ComboBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.btn_imrpimir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lst_lista_pedido = new System.Windows.Forms.ListBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_pratos = new System.Windows.Forms.Label();
            this.cbx_lista_pratos = new System.Windows.Forms.ComboBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.ckb_cartao = new System.Windows.Forms.CheckBox();
            this.ckb_dinheiro = new System.Windows.Forms.CheckBox();
            this.lbl_dinheiro = new System.Windows.Forms.Label();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.dt_pedido_mesa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_comanda
            // 
            this.lbl_comanda.AutoSize = true;
            this.lbl_comanda.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_comanda.Location = new System.Drawing.Point(216, 28);
            this.lbl_comanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_comanda.Name = "lbl_comanda";
            this.lbl_comanda.Size = new System.Drawing.Size(125, 23);
            this.lbl_comanda.TabIndex = 4;
            this.lbl_comanda.Text = "COMANDA";
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mesa.Location = new System.Drawing.Point(248, 97);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(56, 16);
            this.lbl_mesa.TabIndex = 30;
            this.lbl_mesa.Text = "Mesa: ";
            // 
            // cbx_lista_mesa
            // 
            this.cbx_lista_mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_mesa.FormattingEnabled = true;
            this.cbx_lista_mesa.Location = new System.Drawing.Point(242, 116);
            this.cbx_lista_mesa.Name = "cbx_lista_mesa";
            this.cbx_lista_mesa.Size = new System.Drawing.Size(62, 33);
            this.cbx_lista_mesa.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_lista_kit);
            this.groupBox2.Controls.Add(this.lbl_kit);
            this.groupBox2.Controls.Add(this.lbl_porcoes);
            this.groupBox2.Controls.Add(this.cbx_lista_porcoes);
            this.groupBox2.Controls.Add(this.lbl_sobremesa);
            this.groupBox2.Controls.Add(this.cbx_lista_sobremesas);
            this.groupBox2.Controls.Add(this.lbl_bebidas);
            this.groupBox2.Controls.Add(this.cbx_list_bebidas);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.lbl_observacao);
            this.groupBox2.Controls.Add(this.btn_imrpimir);
            this.groupBox2.Controls.Add(this.btn_salvar);
            this.groupBox2.Controls.Add(this.btn_remover);
            this.groupBox2.Controls.Add(this.btn_limpar);
            this.groupBox2.Controls.Add(this.lst_lista_pedido);
            this.groupBox2.Controls.Add(this.btn_confirmar);
            this.groupBox2.Controls.Add(this.lbl_pratos);
            this.groupBox2.Controls.Add(this.cbx_lista_pratos);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 320);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbx_lista_kit
            // 
            this.cbx_lista_kit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_kit.FormattingEnabled = true;
            this.cbx_lista_kit.Location = new System.Drawing.Point(0, 194);
            this.cbx_lista_kit.Name = "cbx_lista_kit";
            this.cbx_lista_kit.Size = new System.Drawing.Size(313, 24);
            this.cbx_lista_kit.TabIndex = 49;
            this.cbx_lista_kit.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_kit_SelectedIndexChanged);
            // 
            // lbl_kit
            // 
            this.lbl_kit.AutoSize = true;
            this.lbl_kit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kit.Location = new System.Drawing.Point(6, 177);
            this.lbl_kit.Name = "lbl_kit";
            this.lbl_kit.Size = new System.Drawing.Size(36, 14);
            this.lbl_kit.TabIndex = 48;
            this.lbl_kit.Text = "KIT:";
            // 
            // lbl_porcoes
            // 
            this.lbl_porcoes.AutoSize = true;
            this.lbl_porcoes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcoes.Location = new System.Drawing.Point(6, 136);
            this.lbl_porcoes.Name = "lbl_porcoes";
            this.lbl_porcoes.Size = new System.Drawing.Size(61, 14);
            this.lbl_porcoes.TabIndex = 47;
            this.lbl_porcoes.Text = "Porções:";
            // 
            // cbx_lista_porcoes
            // 
            this.cbx_lista_porcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_porcoes.FormattingEnabled = true;
            this.cbx_lista_porcoes.Location = new System.Drawing.Point(0, 153);
            this.cbx_lista_porcoes.Name = "cbx_lista_porcoes";
            this.cbx_lista_porcoes.Size = new System.Drawing.Size(313, 24);
            this.cbx_lista_porcoes.TabIndex = 5;
            this.cbx_lista_porcoes.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_porcoes_SelectedIndexChanged);
            // 
            // lbl_sobremesa
            // 
            this.lbl_sobremesa.AutoSize = true;
            this.lbl_sobremesa.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sobremesa.Location = new System.Drawing.Point(6, 97);
            this.lbl_sobremesa.Name = "lbl_sobremesa";
            this.lbl_sobremesa.Size = new System.Drawing.Size(79, 14);
            this.lbl_sobremesa.TabIndex = 45;
            this.lbl_sobremesa.Text = "Sobremesa:";
            // 
            // cbx_lista_sobremesas
            // 
            this.cbx_lista_sobremesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_sobremesas.FormattingEnabled = true;
            this.cbx_lista_sobremesas.Location = new System.Drawing.Point(0, 112);
            this.cbx_lista_sobremesas.Name = "cbx_lista_sobremesas";
            this.cbx_lista_sobremesas.Size = new System.Drawing.Size(313, 24);
            this.cbx_lista_sobremesas.TabIndex = 4;
            this.cbx_lista_sobremesas.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_sobremesas_SelectedIndexChanged);
            // 
            // lbl_bebidas
            // 
            this.lbl_bebidas.AutoSize = true;
            this.lbl_bebidas.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bebidas.Location = new System.Drawing.Point(6, 56);
            this.lbl_bebidas.Name = "lbl_bebidas";
            this.lbl_bebidas.Size = new System.Drawing.Size(63, 14);
            this.lbl_bebidas.TabIndex = 43;
            this.lbl_bebidas.Text = "Bebidas:";
            // 
            // cbx_list_bebidas
            // 
            this.cbx_list_bebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_list_bebidas.FormattingEnabled = true;
            this.cbx_list_bebidas.ItemHeight = 16;
            this.cbx_list_bebidas.Location = new System.Drawing.Point(0, 73);
            this.cbx_list_bebidas.Name = "cbx_list_bebidas";
            this.cbx_list_bebidas.Size = new System.Drawing.Size(313, 24);
            this.cbx_list_bebidas.TabIndex = 42;
            this.cbx_list_bebidas.SelectedIndexChanged += new System.EventHandler(this.cbx_list_bebidas_SelectedIndexChanged);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(33, 255);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(259, 26);
            this.txt_obs.TabIndex = 6;
            this.txt_obs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacao.Location = new System.Drawing.Point(0, 267);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(36, 14);
            this.lbl_observacao.TabIndex = 40;
            this.lbl_observacao.Text = "Obs:";
            // 
            // btn_imrpimir
            // 
            this.btn_imrpimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_imrpimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_imrpimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imrpimir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imrpimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_imrpimir.Location = new System.Drawing.Point(574, 274);
            this.btn_imrpimir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_imrpimir.Name = "btn_imrpimir";
            this.btn_imrpimir.Size = new System.Drawing.Size(94, 35);
            this.btn_imrpimir.TabIndex = 9;
            this.btn_imrpimir.Text = "IMPRIMIR";
            this.btn_imrpimir.UseVisualStyleBackColor = false;
            this.btn_imrpimir.Click += new System.EventHandler(this.btn_imrpimir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salvar.Location = new System.Drawing.Point(574, 217);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(94, 41);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_remover.Location = new System.Drawing.Point(574, 91);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(94, 42);
            this.btn_remover.TabIndex = 8;
            this.btn_remover.Text = "REMOVER";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.Location = new System.Drawing.Point(575, 32);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 42);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lst_lista_pedido
            // 
            this.lst_lista_pedido.FormattingEnabled = true;
            this.lst_lista_pedido.Location = new System.Drawing.Point(319, 19);
            this.lst_lista_pedido.Name = "lst_lista_pedido";
            this.lst_lista_pedido.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_lista_pedido.Size = new System.Drawing.Size(250, 290);
            this.lst_lista_pedido.TabIndex = 30;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_confirmar.Location = new System.Drawing.Point(76, 287);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(149, 27);
            this.btn_confirmar.TabIndex = 18;
            this.btn_confirmar.Text = "CONFIRMAR OBS.";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // lbl_pratos
            // 
            this.lbl_pratos.AutoSize = true;
            this.lbl_pratos.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pratos.Location = new System.Drawing.Point(6, 16);
            this.lbl_pratos.Name = "lbl_pratos";
            this.lbl_pratos.Size = new System.Drawing.Size(51, 14);
            this.lbl_pratos.TabIndex = 20;
            this.lbl_pratos.Text = "Pratos:";
            // 
            // cbx_lista_pratos
            // 
            this.cbx_lista_pratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_pratos.FormattingEnabled = true;
            this.cbx_lista_pratos.Location = new System.Drawing.Point(0, 30);
            this.cbx_lista_pratos.Name = "cbx_lista_pratos";
            this.cbx_lista_pratos.Size = new System.Drawing.Size(313, 24);
            this.cbx_lista_pratos.TabIndex = 2;
            this.cbx_lista_pratos.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_pratos_SelectedIndexChanged);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_finalizar.Location = new System.Drawing.Point(73, 218);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(117, 38);
            this.btn_finalizar.TabIndex = 13;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbl_total);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_troco);
            this.groupBox3.Controls.Add(this.btn_finalizar);
            this.groupBox3.Controls.Add(this.btn_ok);
            this.groupBox3.Controls.Add(this.ckb_cartao);
            this.groupBox3.Controls.Add(this.ckb_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_pagamento);
            this.groupBox3.Controls.Add(this.txt_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_troco);
            this.groupBox3.Location = new System.Drawing.Point(420, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 274);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "00,00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(47, 65);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(46, 14);
            this.lbl_total.TabIndex = 42;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(108, 47);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(112, 38);
            this.txt_total.TabIndex = 41;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_troco
            // 
            this.txt_troco.Enabled = false;
            this.txt_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_troco.Location = new System.Drawing.Point(166, 157);
            this.txt_troco.Multiline = true;
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(86, 38);
            this.txt_troco.TabIndex = 40;
            this.txt_troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ok.Location = new System.Drawing.Point(108, 157);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(42, 38);
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ckb_cartao
            // 
            this.ckb_cartao.AutoSize = true;
            this.ckb_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_cartao.Location = new System.Drawing.Point(144, 105);
            this.ckb_cartao.Name = "ckb_cartao";
            this.ckb_cartao.Size = new System.Drawing.Size(76, 17);
            this.ckb_cartao.TabIndex = 11;
            this.ckb_cartao.Text = "CARTÃO";
            this.ckb_cartao.UseVisualStyleBackColor = true;
            this.ckb_cartao.CheckedChanged += new System.EventHandler(this.ckb_cartao_CheckedChanged);
            // 
            // ckb_dinheiro
            // 
            this.ckb_dinheiro.AutoSize = true;
            this.ckb_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_dinheiro.Location = new System.Drawing.Point(21, 105);
            this.ckb_dinheiro.Name = "ckb_dinheiro";
            this.ckb_dinheiro.Size = new System.Drawing.Size(87, 17);
            this.ckb_dinheiro.TabIndex = 10;
            this.ckb_dinheiro.Text = "DINHEIRO";
            this.ckb_dinheiro.UseVisualStyleBackColor = true;
            this.ckb_dinheiro.CheckedChanged += new System.EventHandler(this.ckb_dinheiro_CheckedChanged);
            // 
            // lbl_dinheiro
            // 
            this.lbl_dinheiro.AutoSize = true;
            this.lbl_dinheiro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinheiro.Location = new System.Drawing.Point(-3, 140);
            this.lbl_dinheiro.Name = "lbl_dinheiro";
            this.lbl_dinheiro.Size = new System.Drawing.Size(47, 14);
            this.lbl_dinheiro.TabIndex = 30;
            this.lbl_dinheiro.Text = "Valor:";
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagamento.ForeColor = System.Drawing.Color.Black;
            this.lbl_pagamento.Location = new System.Drawing.Point(18, 16);
            this.lbl_pagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(226, 16);
            this.lbl_pagamento.TabIndex = 5;
            this.lbl_pagamento.Text = "*FORMA DE PAGAMENTO";
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Enabled = false;
            this.txt_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinheiro.Location = new System.Drawing.Point(0, 157);
            this.txt_dinheiro.Multiline = true;
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(86, 38);
            this.txt_dinheiro.TabIndex = 6;
            this.txt_dinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_troco.ForeColor = System.Drawing.Color.Black;
            this.lbl_troco.Location = new System.Drawing.Point(171, 140);
            this.lbl_troco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(49, 14);
            this.lbl_troco.TabIndex = 7;
            this.lbl_troco.Text = "Troco:";
            // 
            // dt_pedido_mesa
            // 
            this.dt_pedido_mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_pedido_mesa.Location = new System.Drawing.Point(77, 213);
            this.dt_pedido_mesa.Name = "dt_pedido_mesa";
            this.dt_pedido_mesa.Size = new System.Drawing.Size(200, 22);
            this.dt_pedido_mesa.TabIndex = 32;
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(707, 624);
            this.Controls.Add(this.dt_pedido_mesa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_mesa);
            this.Controls.Add(this.cbx_lista_mesa);
            this.Controls.Add(this.lbl_comanda);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 663);
            this.MinimumSize = new System.Drawing.Size(723, 663);
            this.Name = "FormComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.FormComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_comanda;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.ComboBox cbx_lista_mesa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ListBox lst_lista_pedido;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_pratos;
        private System.Windows.Forms.ComboBox cbx_lista_pratos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckb_dinheiro;
        private System.Windows.Forms.Label lbl_dinheiro;
        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.CheckBox ckb_cartao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_imrpimir;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_observacao;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label lbl_porcoes;
        private System.Windows.Forms.ComboBox cbx_lista_porcoes;
        private System.Windows.Forms.Label lbl_sobremesa;
        private System.Windows.Forms.ComboBox cbx_lista_sobremesas;
        private System.Windows.Forms.Label lbl_bebidas;
        private System.Windows.Forms.ComboBox cbx_list_bebidas;
        private System.Windows.Forms.ComboBox cbx_lista_kit;
        private System.Windows.Forms.Label lbl_kit;
        private System.Windows.Forms.DateTimePicker dt_pedido_mesa;
        private System.Windows.Forms.Label label2;
    }
}