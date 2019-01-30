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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveImpuestoConsumo = new System.Windows.Forms.Button();
            this.txtImpuestoConsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPiePagina = new System.Windows.Forms.TextBox();
            this.btnUpdateDataEmpresa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateDataEmpresa);
            this.groupBox2.Controls.Add(this.txtPiePagina);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtNit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pie de Pagina:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(67, 23);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(190, 21);
            this.txtNit.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(67, 53);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(67, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(190, 21);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtPiePagina
            // 
            this.txtPiePagina.Location = new System.Drawing.Point(100, 121);
            this.txtPiePagina.Name = "txtPiePagina";
            this.txtPiePagina.Size = new System.Drawing.Size(288, 21);
            this.txtPiePagina.TabIndex = 7;
            // 
            // btnUpdateDataEmpresa
            // 
            this.btnUpdateDataEmpresa.Location = new System.Drawing.Point(136, 164);
            this.btnUpdateDataEmpresa.Name = "btnUpdateDataEmpresa";
            this.btnUpdateDataEmpresa.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateDataEmpresa.TabIndex = 8;
            this.btnUpdateDataEmpresa.Text = "Actualizar datos";
            this.btnUpdateDataEmpresa.UseVisualStyleBackColor = true;
            this.btnUpdateDataEmpresa.Click += new System.EventHandler(this.UpdateDataEmpresa);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 333);
            this.MinimumSize = new System.Drawing.Size(450, 333);
            this.Name = "SettingsView";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveImpuestoConsumo;
        private System.Windows.Forms.TextBox txtImpuestoConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateDataEmpresa;
        private System.Windows.Forms.TextBox txtPiePagina;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}