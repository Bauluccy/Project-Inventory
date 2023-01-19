
namespace Project_Inventory
{
    partial class TelaInventarioTI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInventarioTI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btConfiguracao = new System.Windows.Forms.ToolStripButton();
            this.btExportarNovoExcel = new System.Windows.Forms.ToolStripButton();
            this.btAlterarExcel = new System.Windows.Forms.ToolStripButton();
            this.btImprimir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCreateItem = new System.Windows.Forms.Button();
            this.btDescarte = new System.Windows.Forms.Button();
            this.btAddItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensSeparadosPorIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dblucianoDataSetInventarioTI = new Project_Inventory.dblucianoDataSetInventarioTI();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.itensSeparadosPorIDTableAdapter = new Project_Inventory.dblucianoDataSetInventarioTITableAdapters.ItensSeparadosPorIDTableAdapter();
            this.process1 = new System.Diagnostics.Process();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSeparadosPorIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblucianoDataSetInventarioTI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 25);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConfiguracao,
            this.btExportarNovoExcel,
            this.btAlterarExcel,
            this.btImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(505, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btConfiguracao
            // 
            this.btConfiguracao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btConfiguracao.Image = global::Project_Inventory.Properties.Resources.options;
            this.btConfiguracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btConfiguracao.Name = "btConfiguracao";
            this.btConfiguracao.Size = new System.Drawing.Size(23, 22);
            this.btConfiguracao.Text = "toolStripButton3";
            this.btConfiguracao.Click += new System.EventHandler(this.btConfiguracao_Click);
            // 
            // btExportarNovoExcel
            // 
            this.btExportarNovoExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExportarNovoExcel.Image = global::Project_Inventory.Properties.Resources.icons8_google_sheets_48;
            this.btExportarNovoExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExportarNovoExcel.Name = "btExportarNovoExcel";
            this.btExportarNovoExcel.Size = new System.Drawing.Size(23, 22);
            this.btExportarNovoExcel.Text = "toolStripButton1";
            this.btExportarNovoExcel.Click += new System.EventHandler(this.btExportarNovoExcel_Click);
            // 
            // btAlterarExcel
            // 
            this.btAlterarExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlterarExcel.Image = global::Project_Inventory.Properties.Resources.edit_sheets2;
            this.btAlterarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlterarExcel.Name = "btAlterarExcel";
            this.btAlterarExcel.Size = new System.Drawing.Size(23, 22);
            this.btAlterarExcel.Text = "toolStripButton4";
            this.btAlterarExcel.Click += new System.EventHandler(this.btAlterarExcel_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(23, 22);
            this.btImprimir.Text = "toolStripButton2";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCreateItem);
            this.panel2.Controls.Add(this.btDescarte);
            this.panel2.Controls.Add(this.btAddItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel2.Size = new System.Drawing.Size(175, 320);
            this.panel2.TabIndex = 0;
            // 
            // btCreateItem
            // 
            this.btCreateItem.Location = new System.Drawing.Point(10, 76);
            this.btCreateItem.Name = "btCreateItem";
            this.btCreateItem.Size = new System.Drawing.Size(155, 50);
            this.btCreateItem.TabIndex = 8;
            this.btCreateItem.Text = "Criar Novo Item";
            this.btCreateItem.UseVisualStyleBackColor = true;
            this.btCreateItem.Click += new System.EventHandler(this.btCreateItem_Click);
            // 
            // btDescarte
            // 
            this.btDescarte.Location = new System.Drawing.Point(10, 142);
            this.btDescarte.Name = "btDescarte";
            this.btDescarte.Size = new System.Drawing.Size(155, 50);
            this.btDescarte.TabIndex = 7;
            this.btDescarte.Text = "Descarte";
            this.btDescarte.UseVisualStyleBackColor = true;
            this.btDescarte.Click += new System.EventHandler(this.btDescarte_Click);
            // 
            // btAddItem
            // 
            this.btAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddItem.Location = new System.Drawing.Point(10, 10);
            this.btAddItem.Name = "btAddItem";
            this.btAddItem.Size = new System.Drawing.Size(155, 50);
            this.btAddItem.TabIndex = 5;
            this.btAddItem.Text = "Adicionar Item";
            this.btAddItem.UseVisualStyleBackColor = true;
            this.btAddItem.Click += new System.EventHandler(this.btAddItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(175, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(330, 320);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDITEMDataGridViewTextBoxColumn,
            this.iTEMDataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensSeparadosPorIDBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(310, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDITEMDataGridViewTextBoxColumn
            // 
            this.iDITEMDataGridViewTextBoxColumn.DataPropertyName = "ID_ITEM";
            this.iDITEMDataGridViewTextBoxColumn.HeaderText = "ID_ITEM";
            this.iDITEMDataGridViewTextBoxColumn.Name = "iDITEMDataGridViewTextBoxColumn";
            this.iDITEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDITEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // iTEMDataGridViewTextBoxColumn
            // 
            this.iTEMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iTEMDataGridViewTextBoxColumn.DataPropertyName = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.iTEMDataGridViewTextBoxColumn.Name = "iTEMDataGridViewTextBoxColumn";
            this.iTEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QNT";
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.qUANTIDADEDataGridViewTextBoxColumn.Width = 75;
            // 
            // itensSeparadosPorIDBindingSource
            // 
            this.itensSeparadosPorIDBindingSource.DataMember = "ItensSeparadosPorID";
            this.itensSeparadosPorIDBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dblucianoDataSetInventarioTI;
            this.bindingSource1.Position = 0;
            // 
            // dblucianoDataSetInventarioTI
            // 
            this.dblucianoDataSetInventarioTI.DataSetName = "dblucianoDataSetInventarioTI";
            this.dblucianoDataSetInventarioTI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itensSeparadosPorIDTableAdapter
            // 
            this.itensSeparadosPorIDTableAdapter.ClearBeforeFill = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // TelaInventarioTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(505, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInventarioTI";
            this.Text = "Inventario da TI";
            this.Activated += new System.EventHandler(this.TelaInventarioTI_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensSeparadosPorIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblucianoDataSetInventarioTI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCreateItem;
        private System.Windows.Forms.Button btDescarte;
        private System.Windows.Forms.Button btAddItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btExportarNovoExcel;
        private System.Windows.Forms.ToolStripButton btImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton btConfiguracao;
        private dblucianoDataSetInventarioTI dblucianoDataSetInventarioTI;
        private System.Windows.Forms.BindingSource itensSeparadosPorIDBindingSource;
        private dblucianoDataSetInventarioTITableAdapters.ItensSeparadosPorIDTableAdapter itensSeparadosPorIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        public System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripButton btAlterarExcel;
    }
}

