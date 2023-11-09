namespace WindowsFormsApp2
{
    partial class PedidoMesaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoMesaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lst_itens_pedido = new System.Windows.Forms.ListBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_itens_pedido = new System.Windows.Forms.Label();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.cbx_pedidos = new System.Windows.Forms.ComboBox();
            this.sGRDataSet = new WindowsFormsApp2.SGRDataSet();
            this.tbl_pedido_mesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedido_mesaTableAdapter = new WindowsFormsApp2.SGRDataSetTableAdapters.tbl_pedido_mesaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.SGRDataSetTableAdapters.TableAdapterManager();
            this.tbl_pedido_mesaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_mesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_mesaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lst_itens_pedido
            // 
            this.lst_itens_pedido.FormattingEnabled = true;
            this.lst_itens_pedido.Location = new System.Drawing.Point(12, 412);
            this.lst_itens_pedido.Name = "lst_itens_pedido";
            this.lst_itens_pedido.Size = new System.Drawing.Size(541, 264);
            this.lst_itens_pedido.TabIndex = 9;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(598, 662);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(89, 43);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.Location = new System.Drawing.Point(593, 518);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 42);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar Itens";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_itens_pedido
            // 
            this.lbl_itens_pedido.AutoSize = true;
            this.lbl_itens_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_itens_pedido.Location = new System.Drawing.Point(177, 376);
            this.lbl_itens_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itens_pedido.Name = "lbl_itens_pedido";
            this.lbl_itens_pedido.Size = new System.Drawing.Size(170, 20);
            this.lbl_itens_pedido.TabIndex = 37;
            this.lbl_itens_pedido.Text = "ITENS PEDIDOS:";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_pedido.Location = new System.Drawing.Point(179, 9);
            this.lbl_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(168, 20);
            this.lbl_pedido.TabIndex = 36;
            this.lbl_pedido.Text = "PEDIDOS MESA:";
            // 
            // cbx_pedidos
            // 
            this.cbx_pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pedidos.FormattingEnabled = true;
            this.cbx_pedidos.Location = new System.Drawing.Point(12, 334);
            this.cbx_pedidos.Name = "cbx_pedidos";
            this.cbx_pedidos.Size = new System.Drawing.Size(541, 24);
            this.cbx_pedidos.TabIndex = 38;
            this.cbx_pedidos.SelectedIndexChanged += new System.EventHandler(this.cbx_pedidos_SelectedIndexChanged);
            // 
            // sGRDataSet
            // 
            this.sGRDataSet.DataSetName = "SGRDataSet";
            this.sGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pedido_mesaBindingSource
            // 
            this.tbl_pedido_mesaBindingSource.DataMember = "tbl_pedido_mesa";
            this.tbl_pedido_mesaBindingSource.DataSource = this.sGRDataSet;
            // 
            // tbl_pedido_mesaTableAdapter
            // 
            this.tbl_pedido_mesaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_clienteTableAdapter = null;
            this.tableAdapterManager.tbl_entregaTableAdapter = null;
            this.tableAdapterManager.tbl_forma_pagamentoTableAdapter = null;
            this.tableAdapterManager.tbl_item_pedido_deliveryTableAdapter = null;
            this.tableAdapterManager.tbl_item_pedido_mesaTableAdapter = null;
            this.tableAdapterManager.tbl_marmitexTableAdapter = null;
            this.tableAdapterManager.tbl_mesaTableAdapter = null;
            this.tableAdapterManager.tbl_pedido_deliveryTableAdapter = null;
            this.tableAdapterManager.tbl_pedido_mesaTableAdapter = this.tbl_pedido_mesaTableAdapter;
            this.tableAdapterManager.tbl_produtoTableAdapter = null;
            this.tableAdapterManager.tbl_tamanho_marmitexTableAdapter = null;
            this.tableAdapterManager.tbl_tipo_marmitexTableAdapter = null;
            this.tableAdapterManager.tbl_tipo_produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.SGRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pedido_mesaDataGridView
            // 
            this.tbl_pedido_mesaDataGridView.AllowUserToAddRows = false;
            this.tbl_pedido_mesaDataGridView.AllowUserToDeleteRows = false;
            this.tbl_pedido_mesaDataGridView.AutoGenerateColumns = false;
            this.tbl_pedido_mesaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.tbl_pedido_mesaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pedido_mesaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_pedido_mesaDataGridView.DataSource = this.tbl_pedido_mesaBindingSource;
            this.tbl_pedido_mesaDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tbl_pedido_mesaDataGridView.Location = new System.Drawing.Point(12, 43);
            this.tbl_pedido_mesaDataGridView.Name = "tbl_pedido_mesaDataGridView";
            this.tbl_pedido_mesaDataGridView.ReadOnly = true;
            this.tbl_pedido_mesaDataGridView.Size = new System.Drawing.Size(541, 264);
            this.tbl_pedido_mesaDataGridView.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pedido_mesa";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pedido_mesa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numero_mesa";
            this.dataGridViewTextBoxColumn2.HeaderText = "numero_mesa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_pedido_mesa";
            this.dataGridViewTextBoxColumn3.HeaderText = "data_pedido_mesa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total_pedido_mesa";
            this.dataGridViewTextBoxColumn4.HeaderText = "total_pedido_mesa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_forma_pagamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_forma_pagamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PedidoMesaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(722, 717);
            this.Controls.Add(this.tbl_pedido_mesaDataGridView);
            this.Controls.Add(this.cbx_pedidos);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_itens_pedido);
            this.Controls.Add(this.lbl_pedido);
            this.Controls.Add(this.lst_itens_pedido);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoMesaForm";
            this.Text = "Pedidos de Mesa";
            this.Load += new System.EventHandler(this.PedidoMesaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_mesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_mesaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lst_itens_pedido;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_itens_pedido;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.ComboBox cbx_pedidos;
        private SGRDataSet sGRDataSet;
        private System.Windows.Forms.BindingSource tbl_pedido_mesaBindingSource;
        private SGRDataSetTableAdapters.tbl_pedido_mesaTableAdapter tbl_pedido_mesaTableAdapter;
        private SGRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_pedido_mesaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}