namespace restauran.views
{
	partial class Mesas
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
            this.btnAddMesa = new System.Windows.Forms.Button();
            this.txtNameMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMesa);
            this.groupBox1.Controls.Add(this.txtNameMesa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesas/Secciones";
            // 
            // btnAddMesa
            // 
            this.btnAddMesa.Location = new System.Drawing.Point(125, 65);
            this.btnAddMesa.Name = "btnAddMesa";
            this.btnAddMesa.Size = new System.Drawing.Size(87, 27);
            this.btnAddMesa.TabIndex = 2;
            this.btnAddMesa.Text = "Agregar";
            this.btnAddMesa.UseVisualStyleBackColor = true;
            this.btnAddMesa.Click += new System.EventHandler(this.btnAddMesa_Click);
            // 
            // txtNameMesa
            // 
            this.txtNameMesa.Location = new System.Drawing.Point(77, 23);
            this.txtNameMesa.Name = "txtNameMesa";
            this.txtNameMesa.Size = new System.Drawing.Size(233, 21);
            this.txtNameMesa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 128);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddMesa;
		private System.Windows.Forms.TextBox txtNameMesa;
		private System.Windows.Forms.Label label1;
	}
}