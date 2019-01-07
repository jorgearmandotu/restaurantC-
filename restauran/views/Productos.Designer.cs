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
			this.Ingredientes = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnNewIngrediente = new System.Windows.Forms.Button();
			this.btnAddIngrediente = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnNewCategoria = new System.Windows.Forms.Button();
			this.btnAddImg = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtNamePlato = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.groupBox1.Controls.Add(this.Ingredientes);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnNewCategoria);
			this.groupBox1.Controls.Add(this.btnAddImg);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.txtNamePlato);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(631, 426);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recetas";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// Ingredientes
			// 
			this.Ingredientes.Controls.Add(this.listView1);
			this.Ingredientes.Controls.Add(this.btnNewIngrediente);
			this.Ingredientes.Controls.Add(this.btnAddIngrediente);
			this.Ingredientes.Controls.Add(this.textBox4);
			this.Ingredientes.Controls.Add(this.label7);
			this.Ingredientes.Controls.Add(this.listBox1);
			this.Ingredientes.Location = new System.Drawing.Point(9, 138);
			this.Ingredientes.Name = "Ingredientes";
			this.Ingredientes.Size = new System.Drawing.Size(611, 282);
			this.Ingredientes.TabIndex = 11;
			this.Ingredientes.TabStop = false;
			this.Ingredientes.Text = "Ingredientes:";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.Location = new System.Drawing.Point(198, 78);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(396, 198);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
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
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(246, 19);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 4;
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
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(155, 251);
			this.listBox1.TabIndex = 0;
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
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(70, 100);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(70, 73);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 20);
			this.textBox2.TabIndex = 6;
			// 
			// txtNamePlato
			// 
			this.txtNamePlato.Location = new System.Drawing.Point(70, 47);
			this.txtNamePlato.Name = "txtNamePlato";
			this.txtNamePlato.Size = new System.Drawing.Size(150, 20);
			this.txtNamePlato.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Platos",
            "Bebidas",
            "Especiales",
            "Otros"});
			this.comboBox1.Location = new System.Drawing.Point(70, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(150, 21);
			this.comboBox1.TabIndex = 4;
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
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "Productos";
			this.Text = "productos";
			this.Load += new System.EventHandler(this.Productos_Load);
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
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox txtNamePlato;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNewCategoria;
		private System.Windows.Forms.GroupBox Ingredientes;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnNewIngrediente;
		private System.Windows.Forms.Button btnAddIngrediente;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private restaurantDataSet restaurantDataSet;
		private System.Windows.Forms.BindingSource insumosBindingSource;
		private restaurantDataSetTableAdapters.insumosTableAdapter insumosTableAdapter;
		private System.Windows.Forms.BindingSource insumosBindingSource1;
	}
}