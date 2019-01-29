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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insumos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresoInsumo = new System.Windows.Forms.Button();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtNameInsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insumos";
            // 
            // btnIngresoInsumo
            // 
            this.btnIngresoInsumo.Location = new System.Drawing.Point(71, 165);
            this.btnIngresoInsumo.Name = "btnIngresoInsumo";
            this.btnIngresoInsumo.Size = new System.Drawing.Size(261, 27);
            this.btnIngresoInsumo.TabIndex = 7;
            this.btnIngresoInsumo.Text = "Ingresar";
            this.btnIngresoInsumo.UseVisualStyleBackColor = true;
            this.btnIngresoInsumo.Click += new System.EventHandler(this.BtnIngresoInsumo_Click);
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(99, 115);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(233, 21);
            this.txtStockMinimo.TabIndex = 6;
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTxtStockMinimokeypress);
            this.txtStockMinimo.Leave += new System.EventHandler(this.TxtStockMinimo_Leave);
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(99, 87);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(233, 21);
            this.txtStockInicial.TabIndex = 5;
            this.txtStockInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumbertxtStockInical);
            this.txtStockInicial.Leave += new System.EventHandler(this.LeaveTxtStockInical);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(99, 58);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(233, 21);
            this.txtUnidad.TabIndex = 4;
            // 
            // txtNameInsumo
            // 
            this.txtNameInsumo.Location = new System.Drawing.Point(99, 25);
            this.txtNameInsumo.Name = "txtNameInsumo";
            this.txtNameInsumo.Size = new System.Drawing.Size(233, 21);
            this.txtNameInsumo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Minimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "stock Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 239);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 278);
            this.MinimumSize = new System.Drawing.Size(470, 278);
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