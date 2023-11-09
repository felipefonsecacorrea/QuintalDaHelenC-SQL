namespace WindowsFormsApp2
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_novo_pedido = new System.Windows.Forms.Button();
            this.lbl_menuPrincipal = new System.Windows.Forms.Label();
            this.btn_comanda = new System.Windows.Forms.Button();
            this.btn_entrega = new System.Windows.Forms.Button();
            this.gbx_comandos1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_faturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_marmitex = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delivery = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mesa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clientes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_comandos1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_novo_pedido
            // 
            this.btn_novo_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_novo_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_novo_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_pedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_novo_pedido.Location = new System.Drawing.Point(378, 43);
            this.btn_novo_pedido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_novo_pedido.Name = "btn_novo_pedido";
            this.btn_novo_pedido.Size = new System.Drawing.Size(135, 38);
            this.btn_novo_pedido.TabIndex = 1;
            this.btn_novo_pedido.Text = "NOVO PEDIDO";
            this.btn_novo_pedido.UseVisualStyleBackColor = false;
            this.btn_novo_pedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_menuPrincipal
            // 
            this.lbl_menuPrincipal.AutoSize = true;
            this.lbl_menuPrincipal.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_menuPrincipal.Location = new System.Drawing.Point(339, 74);
            this.lbl_menuPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_menuPrincipal.Name = "lbl_menuPrincipal";
            this.lbl_menuPrincipal.Size = new System.Drawing.Size(200, 23);
            this.lbl_menuPrincipal.TabIndex = 2;
            this.lbl_menuPrincipal.Text = "MENU PRINCIPAL";
            this.lbl_menuPrincipal.Click += new System.EventHandler(this.lbl_menuPrincipal_Click);
            // 
            // btn_comanda
            // 
            this.btn_comanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_comanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_comanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comanda.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comanda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_comanda.Location = new System.Drawing.Point(378, 126);
            this.btn_comanda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_comanda.Name = "btn_comanda";
            this.btn_comanda.Size = new System.Drawing.Size(135, 38);
            this.btn_comanda.TabIndex = 2;
            this.btn_comanda.Text = "COMANDA";
            this.btn_comanda.UseVisualStyleBackColor = false;
            this.btn_comanda.Click += new System.EventHandler(this.btn_comanda_Click);
            // 
            // btn_entrega
            // 
            this.btn_entrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_entrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrega.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrega.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_entrega.Location = new System.Drawing.Point(378, 208);
            this.btn_entrega.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_entrega.Name = "btn_entrega";
            this.btn_entrega.Size = new System.Drawing.Size(135, 38);
            this.btn_entrega.TabIndex = 3;
            this.btn_entrega.Text = "ENTREGAS";
            this.btn_entrega.UseVisualStyleBackColor = false;
            this.btn_entrega.Click += new System.EventHandler(this.btn_entrega_Click);
            // 
            // gbx_comandos1
            // 
            this.gbx_comandos1.BackColor = System.Drawing.Color.Transparent;
            this.gbx_comandos1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_comandos1.BackgroundImage")));
            this.gbx_comandos1.Controls.Add(this.btn_novo_pedido);
            this.gbx_comandos1.Controls.Add(this.btn_entrega);
            this.gbx_comandos1.Controls.Add(this.btn_comanda);
            this.gbx_comandos1.Location = new System.Drawing.Point(0, 152);
            this.gbx_comandos1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_comandos1.Name = "gbx_comandos1";
            this.gbx_comandos1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_comandos1.Size = new System.Drawing.Size(913, 327);
            this.gbx_comandos1.TabIndex = 5;
            this.gbx_comandos1.TabStop = false;
            this.gbx_comandos1.Enter += new System.EventHandler(this.gbx_comandos1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_faturamento,
            this.btn_produtos,
            this.btn_pedidos,
            this.btn_clientes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_faturamento
            // 
            this.btn_faturamento.Name = "btn_faturamento";
            this.btn_faturamento.Size = new System.Drawing.Size(102, 21);
            this.btn_faturamento.Text = "Faturamento";
            this.btn_faturamento.Click += new System.EventHandler(this.btn_faturamento_Click);
            // 
            // btn_produtos
            // 
            this.btn_produtos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cardapio,
            this.btn_marmitex});
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(78, 21);
            this.btn_produtos.Text = "Produtos";
            // 
            // btn_cardapio
            // 
            this.btn_cardapio.Name = "btn_cardapio";
            this.btn_cardapio.Size = new System.Drawing.Size(139, 22);
            this.btn_cardapio.Text = "Cardápio";
            this.btn_cardapio.Click += new System.EventHandler(this.btn_cardapio_Click);
            // 
            // btn_marmitex
            // 
            this.btn_marmitex.Name = "btn_marmitex";
            this.btn_marmitex.Size = new System.Drawing.Size(139, 22);
            this.btn_marmitex.Text = "Marmitex";
            this.btn_marmitex.Click += new System.EventHandler(this.btn_marmitex_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_delivery,
            this.btn_mesa});
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(70, 21);
            this.btn_pedidos.Text = "Pedidos";
            // 
            // btn_delivery
            // 
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(180, 22);
            this.btn_delivery.Text = "Delivery";
            this.btn_delivery.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // btn_mesa
            // 
            this.btn_mesa.Name = "btn_mesa";
            this.btn_mesa.Size = new System.Drawing.Size(180, 22);
            this.btn_mesa.Text = "Mesa";
            this.btn_mesa.Click += new System.EventHandler(this.btn_mesa_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.ForeColor = System.Drawing.Color.Black;
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(69, 21);
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click_1);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(913, 565);
            this.Controls.Add(this.gbx_comandos1);
            this.Controls.Add(this.lbl_menuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(929, 604);
            this.MinimumSize = new System.Drawing.Size(929, 604);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quintal da Hellen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_comandos1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_novo_pedido;
        private System.Windows.Forms.Label lbl_menuPrincipal;
        private System.Windows.Forms.Button btn_comanda;
        private System.Windows.Forms.Button btn_entrega;
        private System.Windows.Forms.GroupBox gbx_comandos1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_faturamento;
        private System.Windows.Forms.ToolStripMenuItem btn_produtos;
        private System.Windows.Forms.ToolStripMenuItem btn_cardapio;
        private System.Windows.Forms.ToolStripMenuItem btn_marmitex;
        private System.Windows.Forms.ToolStripMenuItem btn_pedidos;
        private System.Windows.Forms.ToolStripMenuItem btn_delivery;
        private System.Windows.Forms.ToolStripMenuItem btn_mesa;
        private System.Windows.Forms.ToolStripMenuItem btn_clientes;
    }
}

