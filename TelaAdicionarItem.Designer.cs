
namespace Project_Inventory
{
    partial class TelaAdicionarItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.comboQuantidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dblucianoDataSet = new Project_Inventory.dblucianoDataSet();
            this.itensCriadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensCriadosTableAdapter = new Project_Inventory.dblucianoDataSetTableAdapters.ItensCriadosTableAdapter();
            this.itensCriadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblucianoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCriadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCriadosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // comboItem
            // 
            this.comboItem.DataSource = this.itensCriadosBindingSource1;
            this.comboItem.DisplayMember = "NOME_ITEM";
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(97, 26);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(121, 21);
            this.comboItem.TabIndex = 1;
            this.comboItem.ValueMember = "ID";
            // 
            // comboQuantidade
            // 
            this.comboQuantidade.FormattingEnabled = true;
            this.comboQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboQuantidade.Location = new System.Drawing.Point(97, 72);
            this.comboQuantidade.Name = "comboQuantidade";
            this.comboQuantidade.Size = new System.Drawing.Size(43, 21);
            this.comboQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(97, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dblucianoDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dblucianoDataSet
            // 
            this.dblucianoDataSet.DataSetName = "dblucianoDataSet";
            this.dblucianoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itensCriadosBindingSource
            // 
            this.itensCriadosBindingSource.DataMember = "ItensCriados";
            this.itensCriadosBindingSource.DataSource = this.bindingSource1;
            // 
            // itensCriadosTableAdapter
            // 
            this.itensCriadosTableAdapter.ClearBeforeFill = true;
            // 
            // itensCriadosBindingSource1
            // 
            this.itensCriadosBindingSource1.DataMember = "ItensCriados";
            this.itensCriadosBindingSource1.DataSource = this.bindingSource1;
            // 
            // TelaAdicionarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(315, 287);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.label1);
            this.Name = "TelaAdicionarItem";
            this.Text = "Adicionar Item";
            this.Load += new System.EventHandler(this.TelaAdicionarItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblucianoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCriadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCriadosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.ComboBox comboQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dblucianoDataSet dblucianoDataSet;
        private System.Windows.Forms.BindingSource itensCriadosBindingSource;
        private dblucianoDataSetTableAdapters.ItensCriadosTableAdapter itensCriadosTableAdapter;
        private System.Windows.Forms.BindingSource itensCriadosBindingSource1;
    }
}