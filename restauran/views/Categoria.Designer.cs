namespace restauran.views
{
	partial class Categoria
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
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.txtDescriptionCategoria = new System.Windows.Forms.TextBox();
            this.txtNameCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCategoria);
            this.groupBox1.Controls.Add(this.txtDescriptionCategoria);
            this.groupBox1.Controls.Add(this.txtNameCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Categoria";
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(121, 208);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(159, 27);
            this.btnAddCategoria.TabIndex = 4;
            this.btnAddCategoria.Text = "Agregar";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionCategoria
            // 
            this.txtDescriptionCategoria.Location = new System.Drawing.Point(97, 65);
            this.txtDescriptionCategoria.Multiline = true;
            this.txtDescriptionCategoria.Name = "txtDescriptionCategoria";
            this.txtDescriptionCategoria.Size = new System.Drawing.Size(233, 115);
            this.txtDescriptionCategoria.TabIndex = 3;
            // 
            // txtNameCategoria
            // 
            this.txtNameCategoria.Location = new System.Drawing.Point(96, 25);
            this.txtNameCategoria.Name = "txtNameCategoria";
            this.txtNameCategoria.Size = new System.Drawing.Size(233, 21);
            this.txtNameCategoria.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 282);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddCategoria;
		private System.Windows.Forms.TextBox txtDescriptionCategoria;
		private System.Windows.Forms.TextBox txtNameCategoria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}