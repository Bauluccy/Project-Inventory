﻿
namespace Project_Inventory
{
    partial class TelaConfigurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConfigurações));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxInventarioAutomatico = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exportar inventario e descarte no inicio do mês";
            // 
            // checkBoxInventarioAutomatico
            // 
            this.checkBoxInventarioAutomatico.AutoSize = true;
            this.checkBoxInventarioAutomatico.Location = new System.Drawing.Point(245, 8);
            this.checkBoxInventarioAutomatico.Name = "checkBoxInventarioAutomatico";
            this.checkBoxInventarioAutomatico.Size = new System.Drawing.Size(15, 14);
            this.checkBoxInventarioAutomatico.TabIndex = 2;
            this.checkBoxInventarioAutomatico.UseVisualStyleBackColor = true;
            this.checkBoxInventarioAutomatico.CheckedChanged += new System.EventHandler(this.checkBoxInventarioAutomatico_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaConfigurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 72);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxInventarioAutomatico);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaConfigurações";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxInventarioAutomatico;
        private System.Windows.Forms.Button button1;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}