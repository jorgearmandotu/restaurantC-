namespace restauran.views
{
	partial class Insumos
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNameInsumo = new System.Windows.Forms.TextBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.txtStockInicial = new System.Windows.Forms.TextBox();
			this.txtStockMinimo = new System.Windows.Forms.TextBox();
			this.btnIngresoInsumo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnIngresoInsumo);
			this.groupBox1.Controls.Add(this.txtStockMinimo);
			this.groupBox1.Controls.Add(this.txtStockInicial);
			this.groupBox1.Controls.Add(this.txtUnidad);
			this.groupBox1.Controls.Add(this.txtNameInsumo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 189);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Insumos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "stock Inicial:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Stock Minimo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Unidad:";
			// 
			// txtNameInsumo
			// 
			this.txtNameInsumo.Location = new System.Drawing.Point(85, 22);
			this.txtNameInsumo.Name = "txtNameInsumo";
			this.txtNameInsumo.Size = new System.Drawing.Size(200, 20);
			this.txtNameInsumo.TabIndex = 1;
			// 
			// txtUnidad
			// 
			this.txtUnidad.Location = new System.Drawing.Point(85, 50);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(200, 20);
			this.txtUnidad.TabIndex = 4;
			// 
			// txtStockInicial
			// 
			this.txtStockInicial.Location = new System.Drawing.Point(85, 75);
			this.txtStockInicial.Name = "txtStockInicial";
			this.txtStockInicial.Size = new System.Drawing.Size(200, 20);
			this.txtStockInicial.TabIndex = 5;
			// 
			// txtStockMinimo
			// 
			this.txtStockMinimo.Location = new System.Drawing.Point(85, 100);
			this.txtStockMinimo.Name = "txtStockMinimo";
			this.txtStockMinimo.Size = new System.Drawing.Size(200, 20);
			this.txtStockMinimo.TabIndex = 6;
			// 
			// btnIngresoInsumo
			// 
			this.btnIngresoInsumo.Location = new System.Drawing.Point(61, 143);
			this.btnIngresoInsumo.Name = "btnIngresoInsumo";
			this.btnIngresoInsumo.Size = new System.Drawing.Size(224, 23);
			this.btnIngresoInsumo.TabIndex = 7;
			this.btnIngresoInsumo.Text = "Ingresar";
			this.btnIngresoInsumo.UseVisualStyleBackColor = true;
			// 
			// Insumos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 207);
			this.Controls.Add(this.groupBox1);
			this.Name = "Insumos";
			this.Text = "Insumos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNameInsumo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnIngresoInsumo;
		private System.Windows.Forms.TextBox txtStockMinimo;
		private System.Windows.Forms.TextBox txtStockInicial;
		private System.Windows.Forms.TextBox txtUnidad;
	}
}