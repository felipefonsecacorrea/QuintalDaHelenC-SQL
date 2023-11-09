namespace WindowsFormsApp2
{
    partial class PedidosDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosDeliveryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.lst_itens_pedido = new System.Windows.Forms.ListBox();
            this.lbl_itens_pedido = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.sGRDataSet = new WindowsFormsApp2.SGRDataSet();
            this.tbl_pedido_deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pedido_deliveryTableAdapter = new WindowsFormsApp2.SGRDataSetTableAdapters.tbl_pedido_deliveryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.SGRDataSetTableAdapters.TableAdapterManager();
            this.tbl_pedido_deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_pedidos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_deliveryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_pedido.Location = new System.Drawing.Point(158, 21);
            this.lbl_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(215, 20);
            this.lbl_pedido.TabIndex = 6;
            this.lbl_pedido.Text = "PEDIDOS DELIVERY:";
            // 
            // lst_itens_pedido
            // 
            this.lst_itens_pedido.FormattingEnabled = true;
            this.lst_itens_pedido.Location = new System.Drawing.Point(12, 382);
            this.lst_itens_pedido.Name = "lst_itens_pedido";
            this.lst_itens_pedido.Size = new System.Drawing.Size(538, 238);
            this.lst_itens_pedido.TabIndex = 8;
            // 
            // lbl_itens_pedido
            // 
            this.lbl_itens_pedido.AutoSize = true;
            this.lbl_itens_pedido.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_itens_pedido.Location = new System.Drawing.Point(203, 350);
            this.lbl_itens_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itens_pedido.Name = "lbl_itens_pedido";
            this.lbl_itens_pedido.Size = new System.Drawing.Size(170, 20);
            this.lbl_itens_pedido.TabIndex = 10;
            this.lbl_itens_pedido.Text = "ITENS PEDIDOS:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_limpar.Location = new System.Drawing.Point(567, 450);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpar.MaximumSize = new System.Drawing.Size(94, 42);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 42);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar Itens";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(567, 592);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(94, 42);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // sGRDataSet
            // 
            this.sGRDataSet.DataSetName = "SGRDataSet";
            this.sGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_pedido_deliveryBindingSource
            // 
            this.tbl_pedido_deliveryBindingSource.DataMember = "tbl_pedido_delivery";
            this.tbl_pedido_deliveryBindingSource.DataSource = this.sGRDataSet;
            // 
            // tbl_pedido_deliveryTableAdapter
            // 
            this.tbl_pedido_deliveryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_pedido_deliveryTableAdapter = this.tbl_pedido_deliveryTableAdapter;
            this.tableAdapterManager.tbl_pedido_mesaTableAdapter = null;
            this.tableAdapterManager.tbl_produtoTableAdapter = null;
            this.tableAdapterManager.tbl_tamanho_marmitexTableAdapter = null;
            this.tableAdapterManager.tbl_tipo_marmitexTableAdapter = null;
            this.tableAdapterManager.tbl_tipo_produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.SGRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_pedido_deliveryDataGridView
            // 
            this.tbl_pedido_deliveryDataGridView.AutoGenerateColumns = false;
            this.tbl_pedido_deliveryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.tbl_pedido_deliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pedido_deliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_pedido_deliveryDataGridView.DataSource = this.tbl_pedido_deliveryBindingSource;
            this.tbl_pedido_deliveryDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.tbl_pedido_deliveryDataGridView.Location = new System.Drawing.Point(12, 44);
            this.tbl_pedido_deliveryDataGridView.Name = "tbl_pedido_deliveryDataGridView";
            this.tbl_pedido_deliveryDataGridView.Size = new System.Drawing.Size(538, 249);
            this.tbl_pedido_deliveryDataGridView.TabIndex = 10;
            this.tbl_pedido_deliveryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pedido_deliveryDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pedido_delivery";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pedido_delivery";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_pedido_delivery";
            this.dataGridViewTextBoxColumn3.HeaderText = "data_pedido_delivery";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total_pedido_delivery";
            this.dataGridViewTextBoxColumn4.HeaderText = "total_pedido_delivery";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_forma_pagamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_forma_pagamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cbx_pedidos
            // 
            this.cbx_pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pedidos.FormattingEnabled = true;
            this.cbx_pedidos.Location = new System.Drawing.Point(12, 315);
            this.cbx_pedidos.Name = "cbx_pedidos";
            this.cbx_pedidos.Size = new System.Drawing.Size(538, 24);
            this.cbx_pedidos.TabIndex = 11;
            this.cbx_pedidos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PedidosDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(681, 646);
            this.Controls.Add(this.cbx_pedidos);
            this.Controls.Add(this.tbl_pedido_deliveryDataGridView);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_itens_pedido);
            this.Controls.Add(this.lst_itens_pedido);
            this.Controls.Add(this.lbl_pedido);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 685);
            this.MinimumSize = new System.Drawing.Size(697, 685);
            this.Name = "PedidosDeliveryForm";
            this.Text = "Pedidos Delivery";
            this.Load += new System.EventHandler(this.PedidosDeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pedido_deliveryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.ListBox lst_itens_pedido;
        private System.Windows.Forms.Label lbl_itens_pedido;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private SGRDataSet sGRDataSet;
        private System.Windows.Forms.BindingSource tbl_pedido_deliveryBindingSource;
        private SGRDataSetTableAdapters.tbl_pedido_deliveryTableAdapter tbl_pedido_deliveryTableAdapter;
        private SGRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbl_pedido_deliveryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbx_pedidos;
    }
}