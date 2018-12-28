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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNameCategoria = new System.Windows.Forms.TextBox();
			this.txtDescriptionCategoria = new System.Windows.Forms.TextBox();
			this.btnAddCategoria = new System.Windows.Forms.Button();
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
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 217);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nueva Categoria";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Descripcion:";
			// 
			// txtNameCategoria
			// 
			this.txtNameCategoria.Location = new System.Drawing.Point(82, 22);
			this.txtNameCategoria.Name = "txtNameCategoria";
			this.txtNameCategoria.Size = new System.Drawing.Size(200, 20);
			this.txtNameCategoria.TabIndex = 2;
			// 
			// txtDescriptionCategoria
			// 
			this.txtDescriptionCategoria.Location = new System.Drawing.Point(83, 56);
			this.txtDescriptionCategoria.Multiline = true;
			this.txtDescriptionCategoria.Name = "txtDescriptionCategoria";
			this.txtDescriptionCategoria.Size = new System.Drawing.Size(200, 100);
			this.txtDescriptionCategoria.TabIndex = 3;
			// 
			// btnAddCategoria
			// 
			this.btnAddCategoria.Location = new System.Drawing.Point(104, 180);
			this.btnAddCategoria.Name = "btnAddCategoria";
			this.btnAddCategoria.Size = new System.Drawing.Size(136, 23);
			this.btnAddCategoria.TabIndex = 4;
			this.btnAddCategoria.Text = "Agregar";
			this.btnAddCategoria.UseVisualStyleBackColor = true;
			// 
			// Categoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 244);
			this.Controls.Add(this.groupBox1);
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