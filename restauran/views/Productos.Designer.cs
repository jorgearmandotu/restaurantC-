namespace restauran.views
{
	partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveReceta = new System.Windows.Forms.Button();
            this.cmbNamePlato = new System.Windows.Forms.ComboBox();
            this.Ingredientes = new System.Windows.Forms.GroupBox();
            this.listViewReceta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewIngrediente = new System.Windows.Forms.Button();
            this.btnAddIngrediente = new System.Windows.Forms.Button();
            this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listInsumos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.Ingredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveReceta);
            this.groupBox1.Controls.Add(this.cmbNamePlato);
            this.groupBox1.Controls.Add(this.Ingredientes);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnAddImg);
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 533);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recetas";
            // 
            // btnSaveReceta
            // 
            this.btnSaveReceta.Location = new System.Drawing.Point(308, 492);
            this.btnSaveReceta.Name = "btnSaveReceta";
            this.btnSaveReceta.Size = new System.Drawing.Size(124, 27);
            this.btnSaveReceta.TabIndex = 11;
            this.btnSaveReceta.Text = "Guardar Receta";
            this.btnSaveReceta.UseVisualStyleBackColor = true;
            this.btnSaveReceta.Click += new System.EventHandler(this.BtnSaveReceta_Click);
            // 
            // cmbNamePlato
            // 
            this.cmbNamePlato.FormattingEnabled = true;
            this.cmbNamePlato.Location = new System.Drawing.Point(82, 53);
            this.cmbNamePlato.Name = "cmbNamePlato";
            this.cmbNamePlato.Size = new System.Drawing.Size(174, 23);
            this.cmbNamePlato.TabIndex = 2;
            this.cmbNamePlato.SelectedIndexChanged += new System.EventHandler(this.CmbNamePlato_SelectedIndexChanged);
            // 
            // Ingredientes
            // 
            this.Ingredientes.Controls.Add(this.listViewReceta);
            this.Ingredientes.Controls.Add(this.btnNewIngrediente);
            this.Ingredientes.Controls.Add(this.btnAddIngrediente);
            this.Ingredientes.Controls.Add(this.txtCantidadIngrediente);
            this.Ingredientes.Controls.Add(this.label7);
            this.Ingredientes.Controls.Add(this.listInsumos);
            this.Ingredientes.Location = new System.Drawing.Point(10, 159);
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Size = new System.Drawing.Size(713, 325);
            this.Ingredientes.TabIndex = 12;
            this.Ingredientes.TabStop = false;
            this.Ingredientes.Text = "Ingredientes:";
            // 
            // listViewReceta
            // 
            this.listViewReceta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewReceta.Location = new System.Drawing.Point(231, 83);
            this.listViewReceta.Name = "listViewReceta";
            this.listViewReceta.Size = new System.Drawing.Size(461, 228);
            this.listViewReceta.TabIndex = 10;
            this.listViewReceta.UseCompatibleStateImageBehavior = false;
            this.listViewReceta.View = System.Windows.Forms.View.Details;
            this.listViewReceta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewReceta_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ingrediente";
            this.columnHeader1.Width = 268;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 88;
            // 
            // btnNewIngrediente
            // 
            this.btnNewIngrediente.Location = new System.Drawing.Point(559, 33);
            this.btnNewIngrediente.Name = "btnNewIngrediente";
            this.btnNewIngrediente.Size = new System.Drawing.Size(134, 27);
            this.btnNewIngrediente.TabIndex = 9;
            this.btnNewIngrediente.Text = "Nuevo Ingrediente";
            this.btnNewIngrediente.UseVisualStyleBackColor = true;
            this.btnNewIngrediente.Click += new System.EventHandler(this.BtnNewIngrediente_Click);
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.Location = new System.Drawing.Point(444, 33);
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.Size = new System.Drawing.Size(87, 27);
            this.btnAddIngrediente.TabIndex = 8;
            this.btnAddIngrediente.Text = "Agregar";
            this.btnAddIngrediente.UseVisualStyleBackColor = true;
            this.btnAddIngrediente.Click += new System.EventHandler(this.BtnAddIngrediente_Click);
            // 
            // txtCantidadIngrediente
            // 
            this.txtCantidadIngrediente.Location = new System.Drawing.Point(287, 22);
            this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
            this.txtCantidadIngrediente.Size = new System.Drawing.Size(116, 21);
            this.txtCantidadIngrediente.TabIndex = 7;
            this.txtCantidadIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInt);
            this.txtCantidadIngrediente.Leave += new System.EventHandler(this.TxtCantidadIngrediente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "cantidad:";
            // 
            // listInsumos
            // 
            this.listInsumos.FormattingEnabled = true;
            this.listInsumos.ItemHeight = 15;
            this.listInsumos.Location = new System.Drawing.Point(7, 22);
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.Size = new System.Drawing.Size(180, 289);
            this.listInsumos.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 129);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(205, 113);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(61, 27);
            this.btnAddImg.TabIndex = 4;
            this.btnAddImg.Text = "Buscar";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.BtnAddImg_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(82, 115);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(116, 21);
            this.txtImage.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 84);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 21);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.Leave += new System.EventHandler(this.NumberTxt_Leave);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(82, 22);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(174, 23);
            this.cmbCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "imagen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "precio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plato: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria: ";
            // 
            // selectImage
            // 
            this.selectImage.Filter = " Archivos de imagen (*.jpg)|*.jpg|Archivos de imagen (*.jpeg)|*.jpeg";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 555);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 594);
            this.MinimumSize = new System.Drawing.Size(770, 594);
            this.Name = "Productos";
            this.Text = "productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Ingredientes.ResumeLayout(false);
            this.Ingredientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddImg;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox Ingredientes;
		private System.Windows.Forms.ListView listViewReceta;
		private System.Windows.Forms.Button btnNewIngrediente;
		private System.Windows.Forms.Button btnAddIngrediente;
		private System.Windows.Forms.TextBox txtCantidadIngrediente;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listInsumos;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ComboBox cmbNamePlato;
		private System.Windows.Forms.Button btnSaveReceta;
        private System.Windows.Forms.OpenFileDialog selectImage;
    }
}