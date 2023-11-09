namespace WindowsFormsApp2
{
    partial class FormNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoPedido));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.lbl_tel_cliente = new System.Windows.Forms.Label();
            this.txt_bairro_endereco = new System.Windows.Forms.TextBox();
            this.lbl_bairro_endereco = new System.Windows.Forms.Label();
            this.txt_rua_endereco = new System.Windows.Forms.TextBox();
            this.lbl_rua_endereco = new System.Windows.Forms.Label();
            this.txt_numero_endereco = new System.Windows.Forms.TextBox();
            this.lbl_numero_endereco = new System.Windows.Forms.Label();
            this.txt_referencia_endereco = new System.Windows.Forms.TextBox();
            this.lbl_referencia_endereco = new System.Windows.Forms.Label();
            this.btn_confirmar_obs = new System.Windows.Forms.Button();
            this.cbx_lista_marmitex_promo = new System.Windows.Forms.ComboBox();
            this.lbl_marmitex_promo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_informção = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_data_pedido = new System.Windows.Forms.Label();
            this.dt_data_pedido = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_lista_salada = new System.Windows.Forms.ComboBox();
            this.lbl_salada = new System.Windows.Forms.Label();
            this.lbl_marmitex_especial = new System.Windows.Forms.Label();
            this.cbx_lista_marmitex_especial = new System.Windows.Forms.ComboBox();
            this.lbl_bebidas = new System.Windows.Forms.Label();
            this.cbx_lista_bebida = new System.Windows.Forms.ComboBox();
            this.lbl_marmitex_light = new System.Windows.Forms.Label();
            this.cbx_lista_marmitex_light = new System.Windows.Forms.ComboBox();
            this.lbl_marmita_premi = new System.Windows.Forms.Label();
            this.cbx_lista_marmitex_premi = new System.Windows.Forms.ComboBox();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.btn_salvar_pedido = new System.Windows.Forms.Button();
            this.btn_imrpimir_pedido = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lst_lista_pedido = new System.Windows.Forms.ListBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total_pedido = new System.Windows.Forms.Label();
            this.txt_total_pedido = new System.Windows.Forms.TextBox();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.ckb_cartao = new System.Windows.Forms.CheckBox();
            this.ckb_dinheiro = new System.Windows.Forms.CheckBox();
            this.lbl_dinheiro = new System.Windows.Forms.Label();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.lbl_troco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_pedido.Location = new System.Drawing.Point(11, 153);
            this.lbl_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(123, 23);
            this.lbl_pedido.TabIndex = 3;
            this.lbl_pedido.Text = "P E D I D O";
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cliente.Location = new System.Drawing.Point(256, 26);
            this.txt_nome_cliente.Multiline = true;
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(179, 33);
            this.txt_nome_cliente.TabIndex = 1;
            this.txt_nome_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome_cliente.Location = new System.Drawing.Point(253, 7);
            this.lbl_nome_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(56, 16);
            this.lbl_nome_cliente.TabIndex = 5;
            this.lbl_nome_cliente.Text = "Nome:";
            // 
            // lbl_tel_cliente
            // 
            this.lbl_tel_cliente.AutoSize = true;
            this.lbl_tel_cliente.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_tel_cliente.Location = new System.Drawing.Point(15, 7);
            this.lbl_tel_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tel_cliente.Name = "lbl_tel_cliente";
            this.lbl_tel_cliente.Size = new System.Drawing.Size(86, 16);
            this.lbl_tel_cliente.TabIndex = 7;
            this.lbl_tel_cliente.Text = "*Telefone:";
            // 
            // txt_bairro_endereco
            // 
            this.txt_bairro_endereco.Location = new System.Drawing.Point(6, 92);
            this.txt_bairro_endereco.Multiline = true;
            this.txt_bairro_endereco.Name = "txt_bairro_endereco";
            this.txt_bairro_endereco.Size = new System.Drawing.Size(141, 26);
            this.txt_bairro_endereco.TabIndex = 4;
            this.txt_bairro_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_bairro_endereco
            // 
            this.lbl_bairro_endereco.AutoSize = true;
            this.lbl_bairro_endereco.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro_endereco.ForeColor = System.Drawing.Color.Black;
            this.lbl_bairro_endereco.Location = new System.Drawing.Point(5, 75);
            this.lbl_bairro_endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bairro_endereco.Name = "lbl_bairro_endereco";
            this.lbl_bairro_endereco.Size = new System.Drawing.Size(52, 14);
            this.lbl_bairro_endereco.TabIndex = 9;
            this.lbl_bairro_endereco.Text = "Bairro:";
            // 
            // txt_rua_endereco
            // 
            this.txt_rua_endereco.Location = new System.Drawing.Point(155, 92);
            this.txt_rua_endereco.Multiline = true;
            this.txt_rua_endereco.Name = "txt_rua_endereco";
            this.txt_rua_endereco.Size = new System.Drawing.Size(331, 26);
            this.txt_rua_endereco.TabIndex = 5;
            this.txt_rua_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_rua_endereco
            // 
            this.lbl_rua_endereco.AutoSize = true;
            this.lbl_rua_endereco.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua_endereco.ForeColor = System.Drawing.Color.Black;
            this.lbl_rua_endereco.Location = new System.Drawing.Point(152, 75);
            this.lbl_rua_endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rua_endereco.Name = "lbl_rua_endereco";
            this.lbl_rua_endereco.Size = new System.Drawing.Size(37, 14);
            this.lbl_rua_endereco.TabIndex = 11;
            this.lbl_rua_endereco.Text = "Rua:";
            // 
            // txt_numero_endereco
            // 
            this.txt_numero_endereco.Location = new System.Drawing.Point(6, 138);
            this.txt_numero_endereco.Multiline = true;
            this.txt_numero_endereco.Name = "txt_numero_endereco";
            this.txt_numero_endereco.Size = new System.Drawing.Size(78, 26);
            this.txt_numero_endereco.TabIndex = 6;
            this.txt_numero_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_numero_endereco
            // 
            this.lbl_numero_endereco.AutoSize = true;
            this.lbl_numero_endereco.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_endereco.ForeColor = System.Drawing.Color.Black;
            this.lbl_numero_endereco.Location = new System.Drawing.Point(6, 121);
            this.lbl_numero_endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numero_endereco.Name = "lbl_numero_endereco";
            this.lbl_numero_endereco.Size = new System.Drawing.Size(61, 14);
            this.lbl_numero_endereco.TabIndex = 13;
            this.lbl_numero_endereco.Text = "Número:";
            // 
            // txt_referencia_endereco
            // 
            this.txt_referencia_endereco.Location = new System.Drawing.Point(141, 138);
            this.txt_referencia_endereco.Multiline = true;
            this.txt_referencia_endereco.Name = "txt_referencia_endereco";
            this.txt_referencia_endereco.Size = new System.Drawing.Size(294, 26);
            this.txt_referencia_endereco.TabIndex = 7;
            this.txt_referencia_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_referencia_endereco
            // 
            this.lbl_referencia_endereco.AutoSize = true;
            this.lbl_referencia_endereco.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referencia_endereco.ForeColor = System.Drawing.Color.Black;
            this.lbl_referencia_endereco.Location = new System.Drawing.Point(138, 121);
            this.lbl_referencia_endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_referencia_endereco.Name = "lbl_referencia_endereco";
            this.lbl_referencia_endereco.Size = new System.Drawing.Size(69, 14);
            this.lbl_referencia_endereco.TabIndex = 17;
            this.lbl_referencia_endereco.Text = "Referência:";
            // 
            // btn_confirmar_obs
            // 
            this.btn_confirmar_obs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_confirmar_obs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirmar_obs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar_obs.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar_obs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_confirmar_obs.Location = new System.Drawing.Point(82, 335);
            this.btn_confirmar_obs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirmar_obs.Name = "btn_confirmar_obs";
            this.btn_confirmar_obs.Size = new System.Drawing.Size(146, 32);
            this.btn_confirmar_obs.TabIndex = 15;
            this.btn_confirmar_obs.Text = "CONFIRMAR OBS.";
            this.btn_confirmar_obs.UseVisualStyleBackColor = false;
            // 
            // cbx_lista_marmitex_promo
            // 
            this.cbx_lista_marmitex_promo.FormattingEnabled = true;
            this.cbx_lista_marmitex_promo.Location = new System.Drawing.Point(6, 64);
            this.cbx_lista_marmitex_promo.Name = "cbx_lista_marmitex_promo";
            this.cbx_lista_marmitex_promo.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_marmitex_promo.TabIndex = 11;
            this.cbx_lista_marmitex_promo.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_marmitex_promo_SelectedIndexChanged);
            // 
            // lbl_marmitex_promo
            // 
            this.lbl_marmitex_promo.AutoSize = true;
            this.lbl_marmitex_promo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marmitex_promo.Location = new System.Drawing.Point(6, 50);
            this.lbl_marmitex_promo.Name = "lbl_marmitex_promo";
            this.lbl_marmitex_promo.Size = new System.Drawing.Size(163, 14);
            this.lbl_marmitex_promo.TabIndex = 20;
            this.lbl_marmitex_promo.Text = "Marmitex Promocionais:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_informção);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_data_pedido);
            this.groupBox1.Controls.Add(this.txt_nome_cliente);
            this.groupBox1.Controls.Add(this.dt_data_pedido);
            this.groupBox1.Controls.Add(this.lbl_nome_cliente);
            this.groupBox1.Controls.Add(this.lbl_tel_cliente);
            this.groupBox1.Controls.Add(this.txt_bairro_endereco);
            this.groupBox1.Controls.Add(this.lbl_bairro_endereco);
            this.groupBox1.Controls.Add(this.txt_rua_endereco);
            this.groupBox1.Controls.Add(this.lbl_rua_endereco);
            this.groupBox1.Controls.Add(this.lbl_referencia_endereco);
            this.groupBox1.Controls.Add(this.txt_numero_endereco);
            this.groupBox1.Controls.Add(this.txt_referencia_endereco);
            this.groupBox1.Controls.Add(this.lbl_numero_endereco);
            this.groupBox1.Location = new System.Drawing.Point(266, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 209);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btn_informção
            // 
            this.btn_informção.BackColor = System.Drawing.Color.Salmon;
            this.btn_informção.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_informção.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_informção.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informção.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_informção.Location = new System.Drawing.Point(89, 137);
            this.btn_informção.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_informção.Name = "btn_informção";
            this.btn_informção.Size = new System.Drawing.Size(28, 27);
            this.btn_informção.TabIndex = 43;
            this.btn_informção.Text = "i";
            this.btn_informção.UseVisualStyleBackColor = false;
            this.btn_informção.Click += new System.EventHandler(this.btn_informção_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "00000-0000";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(18, 25);
            this.txt_tel.Multiline = true;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(179, 33);
            this.txt_tel.TabIndex = 35;
            this.txt_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_alterar.Location = new System.Drawing.Point(525, 69);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(87, 49);
            this.btn_alterar.TabIndex = 8;
            this.btn_alterar.Text = "Alterar Endereço";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cadastrar.Location = new System.Drawing.Point(525, 135);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(87, 33);
            this.btn_cadastrar.TabIndex = 9;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_buscar.Location = new System.Drawing.Point(539, 25);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(59, 26);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_data_pedido
            // 
            this.lbl_data_pedido.AutoSize = true;
            this.lbl_data_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_pedido.Location = new System.Drawing.Point(6, 167);
            this.lbl_data_pedido.Name = "lbl_data_pedido";
            this.lbl_data_pedido.Size = new System.Drawing.Size(93, 14);
            this.lbl_data_pedido.TabIndex = 33;
            this.lbl_data_pedido.Text = "Data Pedido: ";
            // 
            // dt_data_pedido
            // 
            this.dt_data_pedido.Location = new System.Drawing.Point(9, 181);
            this.dt_data_pedido.Name = "dt_data_pedido";
            this.dt_data_pedido.Size = new System.Drawing.Size(200, 20);
            this.dt_data_pedido.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_lista_salada);
            this.groupBox2.Controls.Add(this.lbl_salada);
            this.groupBox2.Controls.Add(this.lbl_marmitex_especial);
            this.groupBox2.Controls.Add(this.cbx_lista_marmitex_especial);
            this.groupBox2.Controls.Add(this.lbl_bebidas);
            this.groupBox2.Controls.Add(this.cbx_lista_bebida);
            this.groupBox2.Controls.Add(this.lbl_marmitex_light);
            this.groupBox2.Controls.Add(this.cbx_lista_marmitex_light);
            this.groupBox2.Controls.Add(this.lbl_marmita_premi);
            this.groupBox2.Controls.Add(this.cbx_lista_marmitex_premi);
            this.groupBox2.Controls.Add(this.lbl_observacao);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.btn_salvar_pedido);
            this.groupBox2.Controls.Add(this.btn_imrpimir_pedido);
            this.groupBox2.Controls.Add(this.btn_remover);
            this.groupBox2.Controls.Add(this.btn_limpar);
            this.groupBox2.Controls.Add(this.lst_lista_pedido);
            this.groupBox2.Controls.Add(this.btn_confirmar_obs);
            this.groupBox2.Controls.Add(this.lbl_marmitex_promo);
            this.groupBox2.Controls.Add(this.cbx_lista_marmitex_promo);
            this.groupBox2.Location = new System.Drawing.Point(27, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 387);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // cbx_lista_salada
            // 
            this.cbx_lista_salada.FormattingEnabled = true;
            this.cbx_lista_salada.Location = new System.Drawing.Point(6, 224);
            this.cbx_lista_salada.Name = "cbx_lista_salada";
            this.cbx_lista_salada.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_salada.TabIndex = 48;
            this.cbx_lista_salada.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_salada_SelectedIndexChanged);
            // 
            // lbl_salada
            // 
            this.lbl_salada.AutoSize = true;
            this.lbl_salada.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salada.Location = new System.Drawing.Point(8, 207);
            this.lbl_salada.Name = "lbl_salada";
            this.lbl_salada.Size = new System.Drawing.Size(54, 14);
            this.lbl_salada.TabIndex = 47;
            this.lbl_salada.Text = "Salada:";
            // 
            // lbl_marmitex_especial
            // 
            this.lbl_marmitex_especial.AutoSize = true;
            this.lbl_marmitex_especial.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marmitex_especial.Location = new System.Drawing.Point(7, 126);
            this.lbl_marmitex_especial.Name = "lbl_marmitex_especial";
            this.lbl_marmitex_especial.Size = new System.Drawing.Size(131, 14);
            this.lbl_marmitex_especial.TabIndex = 46;
            this.lbl_marmitex_especial.Text = "Marmitex Especial:";
            // 
            // cbx_lista_marmitex_especial
            // 
            this.cbx_lista_marmitex_especial.FormattingEnabled = true;
            this.cbx_lista_marmitex_especial.Location = new System.Drawing.Point(6, 143);
            this.cbx_lista_marmitex_especial.Name = "cbx_lista_marmitex_especial";
            this.cbx_lista_marmitex_especial.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_marmitex_especial.TabIndex = 45;
            this.cbx_lista_marmitex_especial.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_marmitex_especial_SelectedIndexChanged);
            // 
            // lbl_bebidas
            // 
            this.lbl_bebidas.AutoSize = true;
            this.lbl_bebidas.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bebidas.Location = new System.Drawing.Point(8, 167);
            this.lbl_bebidas.Name = "lbl_bebidas";
            this.lbl_bebidas.Size = new System.Drawing.Size(57, 14);
            this.lbl_bebidas.TabIndex = 44;
            this.lbl_bebidas.Text = "Bebida:";
            // 
            // cbx_lista_bebida
            // 
            this.cbx_lista_bebida.FormattingEnabled = true;
            this.cbx_lista_bebida.Location = new System.Drawing.Point(6, 184);
            this.cbx_lista_bebida.Name = "cbx_lista_bebida";
            this.cbx_lista_bebida.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_bebida.TabIndex = 13;
            this.cbx_lista_bebida.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_bebida_SelectedIndexChanged);
            // 
            // lbl_marmitex_light
            // 
            this.lbl_marmitex_light.AutoSize = true;
            this.lbl_marmitex_light.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marmitex_light.Location = new System.Drawing.Point(8, 88);
            this.lbl_marmitex_light.Name = "lbl_marmitex_light";
            this.lbl_marmitex_light.Size = new System.Drawing.Size(112, 14);
            this.lbl_marmitex_light.TabIndex = 42;
            this.lbl_marmitex_light.Text = "Marmitex Light:";
            // 
            // cbx_lista_marmitex_light
            // 
            this.cbx_lista_marmitex_light.FormattingEnabled = true;
            this.cbx_lista_marmitex_light.Location = new System.Drawing.Point(6, 102);
            this.cbx_lista_marmitex_light.Name = "cbx_lista_marmitex_light";
            this.cbx_lista_marmitex_light.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_marmitex_light.TabIndex = 12;
            this.cbx_lista_marmitex_light.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_marmitex_light_SelectedIndexChanged);
            // 
            // lbl_marmita_premi
            // 
            this.lbl_marmita_premi.AutoSize = true;
            this.lbl_marmita_premi.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marmita_premi.Location = new System.Drawing.Point(8, 11);
            this.lbl_marmita_premi.Name = "lbl_marmita_premi";
            this.lbl_marmita_premi.Size = new System.Drawing.Size(127, 14);
            this.lbl_marmita_premi.TabIndex = 40;
            this.lbl_marmita_premi.Text = "Marmitex Premium";
            // 
            // cbx_lista_marmitex_premi
            // 
            this.cbx_lista_marmitex_premi.FormattingEnabled = true;
            this.cbx_lista_marmitex_premi.Location = new System.Drawing.Point(6, 26);
            this.cbx_lista_marmitex_premi.Name = "cbx_lista_marmitex_premi";
            this.cbx_lista_marmitex_premi.Size = new System.Drawing.Size(300, 21);
            this.cbx_lista_marmitex_premi.TabIndex = 10;
            this.cbx_lista_marmitex_premi.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_marmitex_premi_SelectedIndexChanged);
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacao.Location = new System.Drawing.Point(18, 286);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(36, 14);
            this.lbl_observacao.TabIndex = 38;
            this.lbl_observacao.Text = "Obs:";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(21, 303);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(259, 26);
            this.txt_obs.TabIndex = 14;
            this.txt_obs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_salvar_pedido
            // 
            this.btn_salvar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_salvar_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salvar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_pedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salvar_pedido.Location = new System.Drawing.Point(585, 245);
            this.btn_salvar_pedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_salvar_pedido.Name = "btn_salvar_pedido";
            this.btn_salvar_pedido.Size = new System.Drawing.Size(94, 35);
            this.btn_salvar_pedido.TabIndex = 18;
            this.btn_salvar_pedido.Text = "SALVAR";
            this.btn_salvar_pedido.UseVisualStyleBackColor = false;
            this.btn_salvar_pedido.Click += new System.EventHandler(this.btn_salvar_pedido_Click);
            // 
            // btn_imrpimir_pedido
            // 
            this.btn_imrpimir_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_imrpimir_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_imrpimir_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imrpimir_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imrpimir_pedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_imrpimir_pedido.Location = new System.Drawing.Point(585, 296);
            this.btn_imrpimir_pedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_imrpimir_pedido.Name = "btn_imrpimir_pedido";
            this.btn_imrpimir_pedido.Size = new System.Drawing.Size(94, 35);
            this.btn_imrpimir_pedido.TabIndex = 19;
            this.btn_imrpimir_pedido.Text = "IMPRIMIR";
            this.btn_imrpimir_pedido.UseVisualStyleBackColor = false;
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_remover.Location = new System.Drawing.Point(585, 91);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(94, 42);
            this.btn_remover.TabIndex = 17;
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
            this.btn_limpar.Location = new System.Drawing.Point(585, 29);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 42);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lst_lista_pedido
            // 
            this.lst_lista_pedido.FormattingEnabled = true;
            this.lst_lista_pedido.Location = new System.Drawing.Point(313, 26);
            this.lst_lista_pedido.Name = "lst_lista_pedido";
            this.lst_lista_pedido.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_lista_pedido.Size = new System.Drawing.Size(267, 303);
            this.lst_lista_pedido.TabIndex = 30;
            this.lst_lista_pedido.SelectedIndexChanged += new System.EventHandler(this.lst_lista_pedido_SelectedIndexChanged);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_finalizar.Location = new System.Drawing.Point(805, 524);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(116, 42);
            this.btn_finalizar.TabIndex = 23;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbl_total_pedido);
            this.groupBox3.Controls.Add(this.txt_total_pedido);
            this.groupBox3.Controls.Add(this.txt_troco);
            this.groupBox3.Controls.Add(this.btn_ok);
            this.groupBox3.Controls.Add(this.ckb_cartao);
            this.groupBox3.Controls.Add(this.ckb_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_pagamento);
            this.groupBox3.Controls.Add(this.txt_dinheiro);
            this.groupBox3.Controls.Add(this.lbl_troco);
            this.groupBox3.Location = new System.Drawing.Point(727, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 250);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "00,00";
            // 
            // lbl_total_pedido
            // 
            this.lbl_total_pedido.AutoSize = true;
            this.lbl_total_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pedido.Location = new System.Drawing.Point(26, 64);
            this.lbl_total_pedido.Name = "lbl_total_pedido";
            this.lbl_total_pedido.Size = new System.Drawing.Size(46, 14);
            this.lbl_total_pedido.TabIndex = 42;
            this.lbl_total_pedido.Text = "Total:";
            // 
            // txt_total_pedido
            // 
            this.txt_total_pedido.Enabled = false;
            this.txt_total_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_pedido.Location = new System.Drawing.Point(78, 50);
            this.txt_total_pedido.Multiline = true;
            this.txt_total_pedido.Name = "txt_total_pedido";
            this.txt_total_pedido.Size = new System.Drawing.Size(112, 38);
            this.txt_total_pedido.TabIndex = 41;
            this.txt_total_pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_troco
            // 
            this.txt_troco.Enabled = false;
            this.txt_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_troco.Location = new System.Drawing.Point(174, 195);
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
            this.btn_ok.Location = new System.Drawing.Point(109, 195);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(42, 38);
            this.btn_ok.TabIndex = 22;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ckb_cartao
            // 
            this.ckb_cartao.AutoSize = true;
            this.ckb_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_cartao.Location = new System.Drawing.Point(144, 111);
            this.ckb_cartao.Name = "ckb_cartao";
            this.ckb_cartao.Size = new System.Drawing.Size(76, 17);
            this.ckb_cartao.TabIndex = 21;
            this.ckb_cartao.Text = "CARTÃO";
            this.ckb_cartao.UseVisualStyleBackColor = true;
            this.ckb_cartao.CheckedChanged += new System.EventHandler(this.ckb_cartao_CheckedChanged);
            // 
            // ckb_dinheiro
            // 
            this.ckb_dinheiro.AutoSize = true;
            this.ckb_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_dinheiro.Location = new System.Drawing.Point(29, 111);
            this.ckb_dinheiro.Name = "ckb_dinheiro";
            this.ckb_dinheiro.Size = new System.Drawing.Size(87, 17);
            this.ckb_dinheiro.TabIndex = 20;
            this.ckb_dinheiro.Text = "DINHEIRO";
            this.ckb_dinheiro.UseVisualStyleBackColor = true;
            this.ckb_dinheiro.CheckedChanged += new System.EventHandler(this.ckb_dinheiro_CheckedChanged);
            // 
            // lbl_dinheiro
            // 
            this.lbl_dinheiro.AutoSize = true;
            this.lbl_dinheiro.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinheiro.Location = new System.Drawing.Point(4, 178);
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
            this.txt_dinheiro.Location = new System.Drawing.Point(7, 195);
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
            this.lbl_troco.Location = new System.Drawing.Point(171, 178);
            this.lbl_troco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(49, 14);
            this.lbl_troco.TabIndex = 7;
            this.lbl_troco.Text = "Troco:";
            // 
            // FormNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1005, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lbl_pedido);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1021, 665);
            this.MinimumSize = new System.Drawing.Size(1021, 665);
            this.Name = "FormNovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.Label lbl_tel_cliente;
        private System.Windows.Forms.TextBox txt_bairro_endereco;
        private System.Windows.Forms.Label lbl_bairro_endereco;
        private System.Windows.Forms.TextBox txt_rua_endereco;
        private System.Windows.Forms.Label lbl_rua_endereco;
        private System.Windows.Forms.TextBox txt_numero_endereco;
        private System.Windows.Forms.Label lbl_numero_endereco;
        private System.Windows.Forms.TextBox txt_referencia_endereco;
        private System.Windows.Forms.Label lbl_referencia_endereco;
        private System.Windows.Forms.Button btn_confirmar_obs;
        private System.Windows.Forms.ComboBox cbx_lista_marmitex_promo;
        private System.Windows.Forms.Label lbl_marmitex_promo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_lista_pedido;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar_pedido;
        private System.Windows.Forms.Button btn_imrpimir_pedido;
        private System.Windows.Forms.Label lbl_data_pedido;
        private System.Windows.Forms.DateTimePicker dt_data_pedido;
        private System.Windows.Forms.Label lbl_observacao;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_total_pedido;
        private System.Windows.Forms.TextBox txt_total_pedido;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox ckb_cartao;
        private System.Windows.Forms.CheckBox ckb_dinheiro;
        private System.Windows.Forms.Label lbl_dinheiro;
        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.Label lbl_marmita_premi;
        private System.Windows.Forms.ComboBox cbx_lista_marmitex_premi;
        private System.Windows.Forms.Label lbl_marmitex_light;
        private System.Windows.Forms.ComboBox cbx_lista_marmitex_light;
        private System.Windows.Forms.Label lbl_bebidas;
        private System.Windows.Forms.ComboBox cbx_lista_bebida;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label lbl_salada;
        private System.Windows.Forms.Label lbl_marmitex_especial;
        private System.Windows.Forms.ComboBox cbx_lista_marmitex_especial;
        private System.Windows.Forms.ComboBox cbx_lista_salada;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_informção;
        private System.Windows.Forms.Label label2;
    }
}