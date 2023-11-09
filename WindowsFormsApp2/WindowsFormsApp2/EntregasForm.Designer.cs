namespace WindowsFormsApp2
{
    partial class EntregasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregasForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_entregas = new System.Windows.Forms.Label();
            this.gbx_adcEntrega = new System.Windows.Forms.GroupBox();
            this.btn_adcEntrega = new System.Windows.Forms.Button();
            this.dt_entrega = new System.Windows.Forms.DateTimePicker();
            this.lbl_adcEntrega1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pesquisarEntrega = new System.Windows.Forms.Button();
            this.dt_pesquisa = new System.Windows.Forms.DateTimePicker();
            this.lst_entregas = new System.Windows.Forms.ListBox();
            this.lbl_pesquisarEntrega = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_adcEntrega.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_entregas
            // 
            this.lbl_entregas.AutoSize = true;
            this.lbl_entregas.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entregas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.lbl_entregas.Location = new System.Drawing.Point(261, 19);
            this.lbl_entregas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_entregas.Name = "lbl_entregas";
            this.lbl_entregas.Size = new System.Drawing.Size(119, 20);
            this.lbl_entregas.TabIndex = 7;
            this.lbl_entregas.Text = "ENTREGAS";
            // 
            // gbx_adcEntrega
            // 
            this.gbx_adcEntrega.Controls.Add(this.btn_adcEntrega);
            this.gbx_adcEntrega.Controls.Add(this.dt_entrega);
            this.gbx_adcEntrega.Location = new System.Drawing.Point(24, 199);
            this.gbx_adcEntrega.Name = "gbx_adcEntrega";
            this.gbx_adcEntrega.Size = new System.Drawing.Size(199, 125);
            this.gbx_adcEntrega.TabIndex = 9;
            this.gbx_adcEntrega.TabStop = false;
            // 
            // btn_adcEntrega
            // 
            this.btn_adcEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_adcEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_adcEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adcEntrega.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adcEntrega.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adcEntrega.Location = new System.Drawing.Point(37, 64);
            this.btn_adcEntrega.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_adcEntrega.Name = "btn_adcEntrega";
            this.btn_adcEntrega.Size = new System.Drawing.Size(114, 40);
            this.btn_adcEntrega.TabIndex = 30;
            this.btn_adcEntrega.Text = "ADICIONAR ENTREGA";
            this.btn_adcEntrega.UseVisualStyleBackColor = false;
            this.btn_adcEntrega.Click += new System.EventHandler(this.btn_adcEntrega_Click);
            // 
            // dt_entrega
            // 
            this.dt_entrega.Enabled = false;
            this.dt_entrega.Location = new System.Drawing.Point(15, 28);
            this.dt_entrega.Name = "dt_entrega";
            this.dt_entrega.Size = new System.Drawing.Size(166, 20);
            this.dt_entrega.TabIndex = 0;
            // 
            // lbl_adcEntrega1
            // 
            this.lbl_adcEntrega1.AutoSize = true;
            this.lbl_adcEntrega1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adcEntrega1.ForeColor = System.Drawing.Color.Black;
            this.lbl_adcEntrega1.Location = new System.Drawing.Point(29, 182);
            this.lbl_adcEntrega1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adcEntrega1.Name = "lbl_adcEntrega1";
            this.lbl_adcEntrega1.Size = new System.Drawing.Size(163, 14);
            this.lbl_adcEntrega1.TabIndex = 10;
            this.lbl_adcEntrega1.Text = "ADICIONAR ENTREGA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pesquisarEntrega);
            this.groupBox1.Controls.Add(this.dt_pesquisa);
            this.groupBox1.Location = new System.Drawing.Point(24, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 161);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btn_pesquisarEntrega
            // 
            this.btn_pesquisarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_pesquisarEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pesquisarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarEntrega.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisarEntrega.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pesquisarEntrega.Location = new System.Drawing.Point(37, 79);
            this.btn_pesquisarEntrega.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_pesquisarEntrega.Name = "btn_pesquisarEntrega";
            this.btn_pesquisarEntrega.Size = new System.Drawing.Size(114, 40);
            this.btn_pesquisarEntrega.TabIndex = 30;
            this.btn_pesquisarEntrega.Text = "PESQUISAR";
            this.btn_pesquisarEntrega.UseVisualStyleBackColor = false;
            this.btn_pesquisarEntrega.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_pesquisa
            // 
            this.dt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_pesquisa.Location = new System.Drawing.Point(15, 33);
            this.dt_pesquisa.Name = "dt_pesquisa";
            this.dt_pesquisa.Size = new System.Drawing.Size(166, 21);
            this.dt_pesquisa.TabIndex = 0;
            // 
            // lst_entregas
            // 
            this.lst_entregas.FormattingEnabled = true;
            this.lst_entregas.Location = new System.Drawing.Point(251, 58);
            this.lst_entregas.Name = "lst_entregas";
            this.lst_entregas.Size = new System.Drawing.Size(249, 420);
            this.lst_entregas.TabIndex = 32;
            // 
            // lbl_pesquisarEntrega
            // 
            this.lbl_pesquisarEntrega.AutoSize = true;
            this.lbl_pesquisarEntrega.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisarEntrega.ForeColor = System.Drawing.Color.Black;
            this.lbl_pesquisarEntrega.Location = new System.Drawing.Point(29, 353);
            this.lbl_pesquisarEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pesquisarEntrega.Name = "lbl_pesquisarEntrega";
            this.lbl_pesquisarEntrega.Size = new System.Drawing.Size(161, 14);
            this.lbl_pesquisarEntrega.TabIndex = 33;
            this.lbl_pesquisarEntrega.Text = "PESQUISAR ENTREGA:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(160)))), ((int)(((byte)(95)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Location = new System.Drawing.Point(465, 501);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(103, 43);
            this.btn_sair.TabIndex = 34;
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
            this.btn_limpar.Location = new System.Drawing.Point(340, 484);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(76, 30);
            this.btn_limpar.TabIndex = 35;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // EntregasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(208)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(580, 556);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_pesquisarEntrega);
            this.Controls.Add(this.lst_entregas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_adcEntrega1);
            this.Controls.Add(this.gbx_adcEntrega);
            this.Controls.Add(this.lbl_entregas);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(596, 595);
            this.MinimumSize = new System.Drawing.Size(596, 595);
            this.Name = "EntregasForm";
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.EntregasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_adcEntrega.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_entregas;
        private System.Windows.Forms.GroupBox gbx_adcEntrega;
        private System.Windows.Forms.DateTimePicker dt_entrega;
        private System.Windows.Forms.Button btn_adcEntrega;
        private System.Windows.Forms.Label lbl_adcEntrega1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pesquisarEntrega;
        private System.Windows.Forms.DateTimePicker dt_pesquisa;
        private System.Windows.Forms.ListBox lst_entregas;
        private System.Windows.Forms.Label lbl_pesquisarEntrega;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
    }
}