namespace WindowsFormsApp2
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.cbx_lista_clientes = new System.Windows.Forms.ComboBox();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro_endereco = new System.Windows.Forms.TextBox();
            this.txt_tel_cliente = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Cadastrar_cliente = new System.Windows.Forms.Button();
            this.btn_alterar_cliente = new System.Windows.Forms.Button();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.txt_rua_endereco = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero_endereco = new System.Windows.Forms.TextBox();
            this.lbl_referencia = new System.Windows.Forms.Label();
            this.txt_referencia_endereco = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numeroDoId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_clientes.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_clientes.Location = new System.Drawing.Point(168, 78);
            this.lbl_clientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(109, 20);
            this.lbl_clientes.TabIndex = 5;
            this.lbl_clientes.Text = "CLIENTES";
            // 
            // cbx_lista_clientes
            // 
            this.cbx_lista_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lista_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_clientes.FormattingEnabled = true;
            this.cbx_lista_clientes.Location = new System.Drawing.Point(74, 140);
            this.cbx_lista_clientes.Name = "cbx_lista_clientes";
            this.cbx_lista_clientes.Size = new System.Drawing.Size(279, 24);
            this.cbx_lista_clientes.TabIndex = 1;
            this.cbx_lista_clientes.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_clientes_SelectedIndexChanged);
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(31, 269);
            this.txt_nome_cliente.MaxLength = 40;
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(223, 20);
            this.txt_nome_cliente.TabIndex = 2;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(29, 253);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(28, 331);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(44, 13);
            this.lbl_bairro.TabIndex = 9;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro_endereco
            // 
            this.txt_bairro_endereco.Location = new System.Drawing.Point(31, 347);
            this.txt_bairro_endereco.MaxLength = 40;
            this.txt_bairro_endereco.Name = "txt_bairro_endereco";
            this.txt_bairro_endereco.Size = new System.Drawing.Size(223, 20);
            this.txt_bairro_endereco.TabIndex = 4;
            // 
            // txt_tel_cliente
            // 
            this.txt_tel_cliente.Location = new System.Drawing.Point(31, 308);
            this.txt_tel_cliente.MaxLength = 15;
            this.txt_tel_cliente.Name = "txt_tel_cliente";
            this.txt_tel_cliente.Size = new System.Drawing.Size(223, 20);
            this.txt_tel_cliente.TabIndex = 3;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(29, 292);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(61, 13);
            this.lbl_tel.TabIndex = 11;
            this.lbl_tel.Text = "Telefone:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(172, 524);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(97, 35);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // btn_Cadastrar_cliente
            // 
            this.btn_Cadastrar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_Cadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar_cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar_cliente.Location = new System.Drawing.Point(313, 347);
            this.btn_Cadastrar_cliente.Name = "btn_Cadastrar_cliente";
            this.btn_Cadastrar_cliente.Size = new System.Drawing.Size(103, 30);
            this.btn_Cadastrar_cliente.TabIndex = 10;
            this.btn_Cadastrar_cliente.Text = "Cadastrar";
            this.btn_Cadastrar_cliente.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_cliente.Click += new System.EventHandler(this.btn_Cadastrar_cliente_Click);
            // 
            // btn_alterar_cliente
            // 
            this.btn_alterar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_alterar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar_cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_alterar_cliente.Location = new System.Drawing.Point(313, 244);
            this.btn_alterar_cliente.Name = "btn_alterar_cliente";
            this.btn_alterar_cliente.Size = new System.Drawing.Size(103, 30);
            this.btn_alterar_cliente.TabIndex = 9;
            this.btn_alterar_cliente.Text = "Alterar";
            this.btn_alterar_cliente.UseVisualStyleBackColor = false;
            this.btn_alterar_cliente.Click += new System.EventHandler(this.btn_alterar_cliente_Click);
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(28, 370);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(34, 13);
            this.lbl_rua.TabIndex = 19;
            this.lbl_rua.Text = "Rua:";
            // 
            // txt_rua_endereco
            // 
            this.txt_rua_endereco.Location = new System.Drawing.Point(31, 386);
            this.txt_rua_endereco.MaxLength = 40;
            this.txt_rua_endereco.Name = "txt_rua_endereco";
            this.txt_rua_endereco.Size = new System.Drawing.Size(223, 20);
            this.txt_rua_endereco.TabIndex = 5;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(28, 409);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(54, 13);
            this.lbl_numero.TabIndex = 21;
            this.lbl_numero.Text = "Numero:";
            // 
            // txt_numero_endereco
            // 
            this.txt_numero_endereco.Location = new System.Drawing.Point(31, 425);
            this.txt_numero_endereco.MaxLength = 40;
            this.txt_numero_endereco.Name = "txt_numero_endereco";
            this.txt_numero_endereco.Size = new System.Drawing.Size(97, 20);
            this.txt_numero_endereco.TabIndex = 6;
            // 
            // lbl_referencia
            // 
            this.lbl_referencia.AutoSize = true;
            this.lbl_referencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referencia.Location = new System.Drawing.Point(28, 448);
            this.lbl_referencia.Name = "lbl_referencia";
            this.lbl_referencia.Size = new System.Drawing.Size(73, 13);
            this.lbl_referencia.TabIndex = 23;
            this.lbl_referencia.Text = "Referência:";
            // 
            // txt_referencia_endereco
            // 
            this.txt_referencia_endereco.Location = new System.Drawing.Point(31, 464);
            this.txt_referencia_endereco.MaxLength = 40;
            this.txt_referencia_endereco.Name = "txt_referencia_endereco";
            this.txt_referencia_endereco.Size = new System.Drawing.Size(223, 20);
            this.txt_referencia_endereco.TabIndex = 7;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.Location = new System.Drawing.Point(313, 454);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(103, 30);
            this.btn_limpar.TabIndex = 24;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Numero de identificação:";
            // 
            // txt_numeroDoId
            // 
            this.txt_numeroDoId.Enabled = false;
            this.txt_numeroDoId.Location = new System.Drawing.Point(32, 230);
            this.txt_numeroDoId.MaxLength = 40;
            this.txt_numeroDoId.Name = "txt_numeroDoId";
            this.txt_numeroDoId.Size = new System.Drawing.Size(97, 20);
            this.txt_numeroDoId.TabIndex = 26;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(428, 582);
            this.Controls.Add(this.txt_numeroDoId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_referencia_endereco);
            this.Controls.Add(this.lbl_referencia);
            this.Controls.Add(this.txt_numero_endereco);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_rua_endereco);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_Cadastrar_cliente);
            this.Controls.Add(this.btn_alterar_cliente);
            this.Controls.Add(this.txt_tel_cliente);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.txt_bairro_endereco);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.cbx_lista_clientes);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 621);
            this.MinimumSize = new System.Drawing.Size(444, 621);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.ComboBox cbx_lista_clientes;
        public System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_bairro;
        public System.Windows.Forms.TextBox txt_bairro_endereco;
        public System.Windows.Forms.TextBox txt_tel_cliente;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_Cadastrar_cliente;
        private System.Windows.Forms.Button btn_alterar_cliente;
        private System.Windows.Forms.Label lbl_rua;
        public System.Windows.Forms.TextBox txt_rua_endereco;
        private System.Windows.Forms.Label lbl_numero;
        public System.Windows.Forms.TextBox txt_numero_endereco;
        private System.Windows.Forms.Label lbl_referencia;
        public System.Windows.Forms.TextBox txt_referencia_endereco;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_numeroDoId;
    }
}