namespace restauran.views
{
    partial class SettingsView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImpuestoConsumo = new System.Windows.Forms.TextBox();
            this.btnSaveImpuestoConsumo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveImpuestoConsumo);
            this.groupBox1.Controls.Add(this.txtImpuestoConsumo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuesto Consumo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor:";
            // 
            // txtImpuestoConsumo
            // 
            this.txtImpuestoConsumo.Location = new System.Drawing.Point(47, 18);
            this.txtImpuestoConsumo.Name = "txtImpuestoConsumo";
            this.txtImpuestoConsumo.Size = new System.Drawing.Size(117, 20);
            this.txtImpuestoConsumo.TabIndex = 1;
            // 
            // btnSaveImpuestoConsumo
            // 
            this.btnSaveImpuestoConsumo.Location = new System.Drawing.Point(218, 15);
            this.btnSaveImpuestoConsumo.Name = "btnSaveImpuestoConsumo";
            this.btnSaveImpuestoConsumo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImpuestoConsumo.TabIndex = 2;
            this.btnSaveImpuestoConsumo.Text = "Guardar";
            this.btnSaveImpuestoConsumo.UseVisualStyleBackColor = true;
            this.btnSaveImpuestoConsumo.Click += new System.EventHandler(this.SaveInpuestoConsumo);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 103);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveImpuestoConsumo;
        private System.Windows.Forms.TextBox txtImpuestoConsumo;
        private System.Windows.Forms.Label label2;
    }
}