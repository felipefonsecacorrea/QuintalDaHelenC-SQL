namespace WindowsFormsApp2
{
    partial class CardapioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardapioForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_comanda = new System.Windows.Forms.Label();
            this.txt_preco_produto = new System.Windows.Forms.TextBox();
            this.lbl_preco_produto = new System.Windows.Forms.Label();
            this.btn_alterar_cliente = new System.Windows.Forms.Button();
            this.btn_novo_produto = new System.Windows.Forms.Button();
            this.lbl_nome_produto = new System.Windows.Forms.Label();
            this.txt_nome_prod = new System.Windows.Forms.TextBox();
            this.cbx_lista_clientes = new System.Windows.Forms.ComboBox();
            this.cbx_tipos_produto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tipos_produto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id_tipo_produto = new System.Windows.Forms.TextBox();
            this.lbl_id_produto = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_produtos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_comanda
            // 
            this.lbl_comanda.AutoSize = true;
            this.lbl_comanda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comanda.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_comanda.Location = new System.Drawing.Point(233, 21);
            this.lbl_comanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_comanda.Name = "lbl_comanda";
            this.lbl_comanda.Size = new System.Drawing.Size(125, 23);
            this.lbl_comanda.TabIndex = 5;
            this.lbl_comanda.Text = "CARDÁPIO";
            // 
            // txt_preco_produto
            // 
            this.txt_preco_produto.Location = new System.Drawing.Point(6, 88);
            this.txt_preco_produto.MaxLength = 40;
            this.txt_preco_produto.Name = "txt_preco_produto";
            this.txt_preco_produto.Size = new System.Drawing.Size(97, 20);
            this.txt_preco_produto.TabIndex = 29;
            this.txt_preco_produto.TextChanged += new System.EventHandler(this.txt_numero_endereco_TextChanged);
            // 
            // lbl_preco_produto
            // 
            this.lbl_preco_produto.AutoSize = true;
            this.lbl_preco_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco_produto.Location = new System.Drawing.Point(7, 72);
            this.lbl_preco_produto.Name = "lbl_preco_produto";
            this.lbl_preco_produto.Size = new System.Drawing.Size(110, 13);
            this.lbl_preco_produto.TabIndex = 40;
            this.lbl_preco_produto.Text = "Preço do Produto:";
            this.lbl_preco_produto.Click += new System.EventHandler(this.lbl_numero_Click);
            // 
            // btn_alterar_cliente
            // 
            this.btn_alterar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_alterar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar_cliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_alterar_cliente.Location = new System.Drawing.Point(301, 122);
            this.btn_alterar_cliente.Name = "btn_alterar_cliente";
            this.btn_alterar_cliente.Size = new System.Drawing.Size(103, 30);
            this.btn_alterar_cliente.TabIndex = 33;
            this.btn_alterar_cliente.Text = "Alterar";
            this.btn_alterar_cliente.UseVisualStyleBackColor = false;
            this.btn_alterar_cliente.Click += new System.EventHandler(this.btn_alterar_cliente_Click);
            // 
            // btn_novo_produto
            // 
            this.btn_novo_produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_novo_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_produto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_novo_produto.Location = new System.Drawing.Point(301, 45);
            this.btn_novo_produto.Name = "btn_novo_produto";
            this.btn_novo_produto.Size = new System.Drawing.Size(103, 30);
            this.btn_novo_produto.TabIndex = 31;
            this.btn_novo_produto.Text = "Novo";
            this.btn_novo_produto.UseVisualStyleBackColor = false;
            this.btn_novo_produto.Click += new System.EventHandler(this.btn_novo_produto_Click);
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.AutoSize = true;
            this.lbl_nome_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto.Location = new System.Drawing.Point(7, 16);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(109, 13);
            this.lbl_nome_produto.TabIndex = 32;
            this.lbl_nome_produto.Text = "Nome do Produto:";
            this.lbl_nome_produto.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(6, 32);
            this.txt_nome_prod.MaxLength = 40;
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(223, 20);
            this.txt_nome_prod.TabIndex = 25;
            this.txt_nome_prod.TextChanged += new System.EventHandler(this.txt_nome_cliente_TextChanged);
            // 
            // cbx_lista_clientes
            // 
            this.cbx_lista_clientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_lista_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lista_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lista_clientes.ForeColor = System.Drawing.Color.Black;
            this.cbx_lista_clientes.FormattingEnabled = true;
            this.cbx_lista_clientes.Location = new System.Drawing.Point(45, 183);
            this.cbx_lista_clientes.Name = "cbx_lista_clientes";
            this.cbx_lista_clientes.Size = new System.Drawing.Size(362, 24);
            this.cbx_lista_clientes.TabIndex = 24;
            this.cbx_lista_clientes.SelectedIndexChanged += new System.EventHandler(this.cbx_lista_clientes_SelectedIndexChanged);
            // 
            // cbx_tipos_produto
            // 
            this.cbx_tipos_produto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_tipos_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipos_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipos_produto.ForeColor = System.Drawing.Color.Black;
            this.cbx_tipos_produto.FormattingEnabled = true;
            this.cbx_tipos_produto.Location = new System.Drawing.Point(6, 39);
            this.cbx_tipos_produto.Name = "cbx_tipos_produto";
            this.cbx_tipos_produto.Size = new System.Drawing.Size(182, 24);
            this.cbx_tipos_produto.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tipos_produto);
            this.groupBox1.Controls.Add(this.cbx_tipos_produto);
            this.groupBox1.Location = new System.Drawing.Point(192, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 82);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_tipos_produto
            // 
            this.lbl_tipos_produto.AutoSize = true;
            this.lbl_tipos_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipos_produto.Location = new System.Drawing.Point(6, 16);
            this.lbl_tipos_produto.Name = "lbl_tipos_produto";
            this.lbl_tipos_produto.Size = new System.Drawing.Size(114, 13);
            this.lbl_tipos_produto.TabIndex = 44;
            this.lbl_tipos_produto.Text = "Tipos de Produtos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id_tipo_produto);
            this.groupBox2.Controls.Add(this.lbl_id_produto);
            this.groupBox2.Controls.Add(this.txt_nome_prod);
            this.groupBox2.Controls.Add(this.lbl_nome_produto);
            this.groupBox2.Controls.Add(this.btn_alterar_cliente);
            this.groupBox2.Controls.Add(this.btn_novo_produto);
            this.groupBox2.Controls.Add(this.lbl_preco_produto);
            this.groupBox2.Controls.Add(this.txt_preco_produto);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 199);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // txt_id_tipo_produto
            // 
            this.txt_id_tipo_produto.Location = new System.Drawing.Point(6, 147);
            this.txt_id_tipo_produto.MaxLength = 40;
            this.txt_id_tipo_produto.Name = "txt_id_tipo_produto";
            this.txt_id_tipo_produto.Size = new System.Drawing.Size(97, 20);
            this.txt_id_tipo_produto.TabIndex = 47;
            // 
            // lbl_id_produto
            // 
            this.lbl_id_produto.AutoSize = true;
            this.lbl_id_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_produto.Location = new System.Drawing.Point(7, 131);
            this.lbl_id_produto.Name = "lbl_id_produto";
            this.lbl_id_produto.Size = new System.Drawing.Size(167, 13);
            this.lbl_id_produto.TabIndex = 46;
            this.lbl_id_produto.Text = "Número do Tipo de Produto:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(167, 477);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(103, 43);
            this.btn_sair.TabIndex = 45;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.Location = new System.Drawing.Point(42, 167);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(61, 13);
            this.lbl_produtos.TabIndex = 48;
            this.lbl_produtos.Text = "Produtos:";
            // 
            // CardapioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(447, 538);
            this.Controls.Add(this.lbl_produtos);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbx_lista_clientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_comanda);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 577);
            this.MinimumSize = new System.Drawing.Size(463, 577);
            this.Name = "CardapioForm";
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.CardapioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_comanda;
        public System.Windows.Forms.TextBox txt_preco_produto;
        private System.Windows.Forms.Label lbl_preco_produto;
        private System.Windows.Forms.Button btn_alterar_cliente;
        private System.Windows.Forms.Button btn_novo_produto;
        private System.Windows.Forms.Label lbl_nome_produto;
        public System.Windows.Forms.TextBox txt_nome_prod;
        private System.Windows.Forms.ComboBox cbx_lista_clientes;
        private System.Windows.Forms.ComboBox cbx_tipos_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tipos_produto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_id_produto;
        private System.Windows.Forms.Button btn_sair;
        public System.Windows.Forms.TextBox txt_id_tipo_produto;
        private System.Windows.Forms.Label lbl_produtos;
    }
}