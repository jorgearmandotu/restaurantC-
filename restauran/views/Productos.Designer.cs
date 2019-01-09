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
			this.components = new System.ComponentModel.Container();
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
			this.btnNewCategoria = new System.Windows.Forms.Button();
			this.btnAddImg = new System.Windows.Forms.Button();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.restaurantDataSet = new restauran.restaurantDataSet();
			this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.insumosTableAdapter = new restauran.restaurantDataSetTableAdapters.insumosTableAdapter();
			this.insumosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			this.Ingredientes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSaveReceta);
			this.groupBox1.Controls.Add(this.cmbNamePlato);
			this.groupBox1.Controls.Add(this.Ingredientes);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnNewCategoria);
			this.groupBox1.Controls.Add(this.btnAddImg);
			this.groupBox1.Controls.Add(this.txtImage);
			this.groupBox1.Controls.Add(this.txtPrecio);
			this.groupBox1.Controls.Add(this.cmbCategoria);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(7, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(631, 462);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recetas";
			// 
			// btnSaveReceta
			// 
			this.btnSaveReceta.Location = new System.Drawing.Point(264, 426);
			this.btnSaveReceta.Name = "btnSaveReceta";
			this.btnSaveReceta.Size = new System.Drawing.Size(106, 23);
			this.btnSaveReceta.TabIndex = 13;
			this.btnSaveReceta.Text = "Guardar Receta";
			this.btnSaveReceta.UseVisualStyleBackColor = true;
			this.btnSaveReceta.Click += new System.EventHandler(this.btnSaveReceta_Click);
			// 
			// cmbNamePlato
			// 
			this.cmbNamePlato.FormattingEnabled = true;
			this.cmbNamePlato.Location = new System.Drawing.Point(70, 46);
			this.cmbNamePlato.Name = "cmbNamePlato";
			this.cmbNamePlato.Size = new System.Drawing.Size(150, 21);
			this.cmbNamePlato.TabIndex = 12;
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
			this.Ingredientes.Location = new System.Drawing.Point(9, 138);
			this.Ingredientes.Name = "Ingredientes";
			this.Ingredientes.Size = new System.Drawing.Size(611, 282);
			this.Ingredientes.TabIndex = 11;
			this.Ingredientes.TabStop = false;
			this.Ingredientes.Text = "Ingredientes:";
			// 
			// listViewReceta
			// 
			this.listViewReceta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listViewReceta.Location = new System.Drawing.Point(198, 72);
			this.listViewReceta.Name = "listViewReceta";
			this.listViewReceta.Size = new System.Drawing.Size(396, 198);
			this.listViewReceta.TabIndex = 7;
			this.listViewReceta.UseCompatibleStateImageBehavior = false;
			this.listViewReceta.View = System.Windows.Forms.View.Details;
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
			this.btnNewIngrediente.Location = new System.Drawing.Point(479, 29);
			this.btnNewIngrediente.Name = "btnNewIngrediente";
			this.btnNewIngrediente.Size = new System.Drawing.Size(115, 23);
			this.btnNewIngrediente.TabIndex = 6;
			this.btnNewIngrediente.Text = "Nuevo Ingrediente";
			this.btnNewIngrediente.UseVisualStyleBackColor = true;
			this.btnNewIngrediente.Click += new System.EventHandler(this.btnNewIngrediente_Click);
			// 
			// btnAddIngrediente
			// 
			this.btnAddIngrediente.Location = new System.Drawing.Point(381, 29);
			this.btnAddIngrediente.Name = "btnAddIngrediente";
			this.btnAddIngrediente.Size = new System.Drawing.Size(75, 23);
			this.btnAddIngrediente.TabIndex = 5;
			this.btnAddIngrediente.Text = "Agregar";
			this.btnAddIngrediente.UseVisualStyleBackColor = true;
			this.btnAddIngrediente.Click += new System.EventHandler(this.btnAddIngrediente_Click);
			// 
			// txtCantidadIngrediente
			// 
			this.txtCantidadIngrediente.Location = new System.Drawing.Point(246, 19);
			this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
			this.txtCantidadIngrediente.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadIngrediente.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(183, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "cantidad:";
			// 
			// listInsumos
			// 
			this.listInsumos.FormattingEnabled = true;
			this.listInsumos.Location = new System.Drawing.Point(6, 19);
			this.listInsumos.Name = "listInsumos";
			this.listInsumos.Size = new System.Drawing.Size(155, 251);
			this.listInsumos.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(363, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 112);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// btnNewCategoria
			// 
			this.btnNewCategoria.Location = new System.Drawing.Point(255, 16);
			this.btnNewCategoria.Name = "btnNewCategoria";
			this.btnNewCategoria.Size = new System.Drawing.Size(53, 23);
			this.btnNewCategoria.TabIndex = 9;
			this.btnNewCategoria.Text = "Nueva";
			this.btnNewCategoria.UseVisualStyleBackColor = true;
			this.btnNewCategoria.Click += new System.EventHandler(this.btnNewCategoria_Click);
			// 
			// btnAddImg
			// 
			this.btnAddImg.Location = new System.Drawing.Point(176, 98);
			this.btnAddImg.Name = "btnAddImg";
			this.btnAddImg.Size = new System.Drawing.Size(52, 23);
			this.btnAddImg.TabIndex = 8;
			this.btnAddImg.Text = "Buscar";
			this.btnAddImg.UseVisualStyleBackColor = true;
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(70, 100);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new System.Drawing.Size(100, 20);
			this.txtImage.TabIndex = 7;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(70, 73);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(150, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Items.AddRange(new object[] {
            "Platos",
            "Bebidas",
            "Especiales",
            "Otros"});
			this.cmbCategoria.Location = new System.Drawing.Point(70, 19);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(150, 21);
			this.cmbCategoria.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "imagen: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "precio: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Plato: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Categoria: ";
			// 
			// restaurantDataSet
			// 
			this.restaurantDataSet.DataSetName = "restaurantDataSet";
			this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// insumosBindingSource
			// 
			this.insumosBindingSource.DataMember = "insumos";
			this.insumosBindingSource.DataSource = this.restaurantDataSet;
			// 
			// insumosTableAdapter
			// 
			this.insumosTableAdapter.ClearBeforeFill = true;
			// 
			// insumosBindingSource1
			// 
			this.insumosBindingSource1.DataMember = "insumos";
			this.insumosBindingSource1.DataSource = this.restaurantDataSet;
			// 
			// Productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 481);
			this.Controls.Add(this.groupBox1);
			this.Name = "Productos";
			this.Text = "productos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Ingredientes.ResumeLayout(false);
			this.Ingredientes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource1)).EndInit();
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
		private System.Windows.Forms.Button btnNewCategoria;
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
		private restaurantDataSet restaurantDataSet;
		private System.Windows.Forms.BindingSource insumosBindingSource;
		private restaurantDataSetTableAdapters.insumosTableAdapter insumosTableAdapter;
		private System.Windows.Forms.BindingSource insumosBindingSource1;
		private System.Windows.Forms.ComboBox cmbNamePlato;
		private System.Windows.Forms.Button btnSaveReceta;
	}
}