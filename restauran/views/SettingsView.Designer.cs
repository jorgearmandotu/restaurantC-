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
            this.btnSaveImpuestoConsumo = new System.Windows.Forms.Button();
            this.txtImpuestoConsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveImpuestoConsumo);
            this.groupBox1.Controls.Add(this.txtImpuestoConsumo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuesto Consumo:";
            // 
            // btnSaveImpuestoConsumo
            // 
            this.btnSaveImpuestoConsumo.Location = new System.Drawing.Point(254, 17);
            this.btnSaveImpuestoConsumo.Name = "btnSaveImpuestoConsumo";
            this.btnSaveImpuestoConsumo.Size = new System.Drawing.Size(87, 27);
            this.btnSaveImpuestoConsumo.TabIndex = 2;
            this.btnSaveImpuestoConsumo.Text = "Guardar";
            this.btnSaveImpuestoConsumo.UseVisualStyleBackColor = true;
            this.btnSaveImpuestoConsumo.Click += new System.EventHandler(this.SaveInpuestoConsumo);
            // 
            // txtImpuestoConsumo
            // 
            this.txtImpuestoConsumo.Location = new System.Drawing.Point(55, 21);
            this.txtImpuestoConsumo.Name = "txtImpuestoConsumo";
            this.txtImpuestoConsumo.Size = new System.Drawing.Size(136, 21);
            this.txtImpuestoConsumo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor:";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 119);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 158);
            this.MinimumSize = new System.Drawing.Size(490, 158);
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