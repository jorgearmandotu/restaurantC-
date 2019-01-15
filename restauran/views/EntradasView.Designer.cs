namespace restauran.views
{
    partial class EntradasView
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
            this.button2 = new System.Windows.Forms.Button();
            this.listViewFactura = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservation = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateAddinsumo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVlrUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddItemfact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInsumo = new System.Windows.Forms.ComboBox();
            this.btnNewInsumo = new System.Windows.Forms.Button();
            this.txtNumberSales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantdel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.txtObservationBaja = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductsBaja = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateBaja = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listViewFactura);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNumberSales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbProvider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveItemsFacturaView);
            // 
            // listViewFactura
            // 
            this.listViewFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader6});
            this.listViewFactura.Location = new System.Drawing.Point(6, 264);
            this.listViewFactura.Name = "listViewFactura";
            this.listViewFactura.Size = new System.Drawing.Size(540, 146);
            this.listViewFactura.TabIndex = 10;
            this.listViewFactura.UseCompatibleStateImageBehavior = false;
            this.listViewFactura.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N.";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unidad";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vlr. Unitario";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservation);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateAddinsumo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVlrUnitario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCantAdd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAddItemfact);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbInsumo);
            this.groupBox2.Controls.Add(this.btnNewInsumo);
            this.groupBox2.Location = new System.Drawing.Point(6, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos:";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(93, 106);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(435, 48);
            this.txtObservation.TabIndex = 18;
            this.txtObservation.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Observaciones:";
            // 
            // dateAddinsumo
            // 
            this.dateAddinsumo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddinsumo.Location = new System.Drawing.Point(422, 64);
            this.dateAddinsumo.Name = "dateAddinsumo";
            this.dateAddinsumo.Size = new System.Drawing.Size(109, 20);
            this.dateAddinsumo.TabIndex = 16;
            this.dateAddinsumo.Value = new System.DateTime(2019, 1, 15, 10, 4, 54, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha:";
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(422, 29);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Size = new System.Drawing.Size(109, 20);
            this.txtVlrUnitario.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vlr.Unitario";
            // 
            // txtCantAdd
            // 
            this.txtCantAdd.Location = new System.Drawing.Point(65, 63);
            this.txtCantAdd.Name = "txtCantAdd";
            this.txtCantAdd.Size = new System.Drawing.Size(149, 20);
            this.txtCantAdd.TabIndex = 12;
            this.txtCantAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInt);
            this.txtCantAdd.Leave += new System.EventHandler(this.CantidadValid_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad:";
            // 
            // btnAddItemfact
            // 
            this.btnAddItemfact.Location = new System.Drawing.Point(245, 169);
            this.btnAddItemfact.Name = "btnAddItemfact";
            this.btnAddItemfact.Size = new System.Drawing.Size(75, 23);
            this.btnAddItemfact.TabIndex = 10;
            this.btnAddItemfact.Text = "Ingresar";
            this.btnAddItemfact.UseVisualStyleBackColor = true;
            this.btnAddItemfact.Click += new System.EventHandler(this.AddProductListView);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto:";
            // 
            // cmbInsumo
            // 
            this.cmbInsumo.FormattingEnabled = true;
            this.cmbInsumo.Location = new System.Drawing.Point(68, 29);
            this.cmbInsumo.Name = "cmbInsumo";
            this.cmbInsumo.Size = new System.Drawing.Size(146, 21);
            this.cmbInsumo.TabIndex = 6;
            // 
            // btnNewInsumo
            // 
            this.btnNewInsumo.Location = new System.Drawing.Point(245, 27);
            this.btnNewInsumo.Name = "btnNewInsumo";
            this.btnNewInsumo.Size = new System.Drawing.Size(75, 23);
            this.btnNewInsumo.TabIndex = 7;
            this.btnNewInsumo.Text = "Nuevo";
            this.btnNewInsumo.UseVisualStyleBackColor = true;
            this.btnNewInsumo.Click += new System.EventHandler(this.NewInsumo);
            // 
            // txtNumberSales
            // 
            this.txtNumberSales.Location = new System.Drawing.Point(426, 20);
            this.txtNumberSales.Name = "txtNumberSales";
            this.txtNumberSales.Size = new System.Drawing.Size(111, 20);
            this.txtNumberSales.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N. factura:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewProvider);
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(74, 19);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(146, 21);
            this.cmbProvider.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantdel
            // 
            this.txtCantdel.Location = new System.Drawing.Point(258, 25);
            this.txtCantdel.Name = "txtCantdel";
            this.txtCantdel.Size = new System.Drawing.Size(92, 20);
            this.txtCantdel.TabIndex = 9;
            this.txtCantdel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInt);
            this.txtCantdel.Leave += new System.EventHandler(this.CantidadValidBaja_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateBaja);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnDarBaja);
            this.groupBox3.Controls.Add(this.txtObservationBaja);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCantdel);
            this.groupBox3.Controls.Add(this.cmbProductsBaja);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 169);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bajas";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(251, 140);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(75, 23);
            this.btnDarBaja.TabIndex = 12;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.DarBaja);
            // 
            // txtObservationBaja
            // 
            this.txtObservationBaja.Location = new System.Drawing.Point(83, 61);
            this.txtObservationBaja.Name = "txtObservationBaja";
            this.txtObservationBaja.Size = new System.Drawing.Size(454, 65);
            this.txtObservationBaja.TabIndex = 11;
            this.txtObservationBaja.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Observacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Producto:";
            // 
            // cmbProductsBaja
            // 
            this.cmbProductsBaja.FormattingEnabled = true;
            this.cmbProductsBaja.Location = new System.Drawing.Point(65, 24);
            this.cmbProductsBaja.Name = "cmbProductsBaja";
            this.cmbProductsBaja.Size = new System.Drawing.Size(128, 21);
            this.cmbProductsBaja.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Fecha:";
            // 
            // dateBaja
            // 
            this.dateBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaja.Location = new System.Drawing.Point(409, 26);
            this.dateBaja.Name = "dateBaja";
            this.dateBaja.Size = new System.Drawing.Size(125, 20);
            this.dateBaja.TabIndex = 14;
            this.dateBaja.Value = new System.DateTime(2019, 1, 15, 16, 21, 29, 0);
            // 
            // EntradasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EntradasView";
            this.Text = "EntradasView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewInsumo;
        private System.Windows.Forms.ComboBox cmbInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFactura;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddItemfact;
        private System.Windows.Forms.TextBox txtCantdel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.RichTextBox txtObservationBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProductsBaja;
        private System.Windows.Forms.TextBox txtCantAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVlrUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateAddinsumo;
        private System.Windows.Forms.RichTextBox txtObservation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dateBaja;
        private System.Windows.Forms.Label label11;
    }
}