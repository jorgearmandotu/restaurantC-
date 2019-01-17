using System.Collections.Generic;

namespace restauran.views
{
    partial class Pedidos
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
            this.cmbMesero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblNameCliente = new System.Windows.Forms.Label();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lblImpConsumo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewPedido = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewOtros = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewEspeciales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewBebidas = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewPlatos = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProductos = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMesas = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMesero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbMesa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 696);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // cmbMesero
            // 
            this.cmbMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesero.FormattingEnabled = true;
            this.cmbMesero.Location = new System.Drawing.Point(343, 19);
            this.cmbMesero.Name = "cmbMesero";
            this.cmbMesero.Size = new System.Drawing.Size(179, 24);
            this.cmbMesero.TabIndex = 10;
            this.cmbMesero.SelectionChangeCommitted += new System.EventHandler(this.SelectedChangedCommitCmbMesero);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mesero: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblNameCliente);
            this.groupBox6.Controls.Add(this.btnNewCliente);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtIdCliente);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.btnFacturar);
            this.groupBox6.Controls.Add(this.lblImpConsumo);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblValorPagar);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.listViewPedido);
            this.groupBox6.Location = new System.Drawing.Point(588, 69);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 601);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pedido";
            // 
            // lblNameCliente
            // 
            this.lblNameCliente.AutoSize = true;
            this.lblNameCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCliente.Location = new System.Drawing.Point(129, 505);
            this.lblNameCliente.MinimumSize = new System.Drawing.Size(157, 20);
            this.lblNameCliente.Name = "lblNameCliente";
            this.lblNameCliente.Size = new System.Drawing.Size(157, 20);
            this.lblNameCliente.TabIndex = 16;
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Location = new System.Drawing.Point(305, 472);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNewCliente.TabIndex = 15;
            this.btnNewCliente.Text = "Nuevo";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            this.btnNewCliente.Click += new System.EventHandler(this.AddCliente);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre Cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(142, 473);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(157, 22);
            this.txtIdCliente.TabIndex = 12;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidClienteEnter);
            this.txtIdCliente.Leave += new System.EventHandler(this.ValidCliente);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CC CLiente:";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(104, 551);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(150, 23);
            this.btnFacturar.TabIndex = 10;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.FacturarPedido);
            // 
            // lblImpConsumo
            // 
            this.lblImpConsumo.AutoSize = true;
            this.lblImpConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpConsumo.Location = new System.Drawing.Point(255, 411);
            this.lblImpConsumo.MinimumSize = new System.Drawing.Size(120, 20);
            this.lblImpConsumo.Name = "lblImpConsumo";
            this.lblImpConsumo.Size = new System.Drawing.Size(120, 20);
            this.lblImpConsumo.TabIndex = 9;
            this.lblImpConsumo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Impuesto al consumo:";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.Location = new System.Drawing.Point(260, 442);
            this.lblValorPagar.MinimumSize = new System.Drawing.Size(120, 20);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(120, 20);
            this.lblValorPagar.TabIndex = 7;
            this.lblValorPagar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor a Pagar:";
            // 
            // listViewPedido
            // 
            this.listViewPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.precio,
            this.cantidad});
            this.listViewPedido.Location = new System.Drawing.Point(6, 21);
            this.listViewPedido.Name = "listViewPedido";
            this.listViewPedido.Size = new System.Drawing.Size(369, 373);
            this.listViewPedido.TabIndex = 5;
            this.listViewPedido.UseCompatibleStateImageBehavior = false;
            this.listViewPedido.View = System.Windows.Forms.View.Details;
            this.listViewPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewPedido_MouseDoubleClick);
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 200;
            // 
            // precio
            // 
            this.precio.Text = "Vlr Unit";
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.precio.Width = 90;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantidad.Width = 70;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listViewOtros);
            this.groupBox5.Location = new System.Drawing.Point(292, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 304);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Otros";
            // 
            // listViewOtros
            // 
            this.listViewOtros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewOtros.Enabled = false;
            this.listViewOtros.Location = new System.Drawing.Point(6, 19);
            this.listViewOtros.Name = "listViewOtros";
            this.listViewOtros.Size = new System.Drawing.Size(217, 272);
            this.listViewOtros.TabIndex = 0;
            this.listViewOtros.UseCompatibleStateImageBehavior = false;
            this.listViewOtros.View = System.Windows.Forms.View.Details;
            this.listViewOtros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListOtros_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 82;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.listViewEspeciales);
            this.groupBox4.Location = new System.Drawing.Point(9, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 297);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Especiales";
            // 
            // listViewEspeciales
            // 
            this.listViewEspeciales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewEspeciales.Enabled = false;
            this.listViewEspeciales.Location = new System.Drawing.Point(7, 19);
            this.listViewEspeciales.Name = "listViewEspeciales";
            this.listViewEspeciales.Size = new System.Drawing.Size(217, 272);
            this.listViewEspeciales.TabIndex = 0;
            this.listViewEspeciales.UseCompatibleStateImageBehavior = false;
            this.listViewEspeciales.View = System.Windows.Forms.View.Details;
            this.listViewEspeciales.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListEspeciales_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plato";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.Width = 82;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewBebidas);
            this.groupBox3.Location = new System.Drawing.Point(292, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 295);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bebidas";
            // 
            // listViewBebidas
            // 
            this.listViewBebidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewBebidas.Enabled = false;
            this.listViewBebidas.Location = new System.Drawing.Point(7, 21);
            this.listViewBebidas.Name = "listViewBebidas";
            this.listViewBebidas.Size = new System.Drawing.Size(217, 268);
            this.listViewBebidas.TabIndex = 0;
            this.listViewBebidas.UseCompatibleStateImageBehavior = false;
            this.listViewBebidas.View = System.Windows.Forms.View.Details;
            this.listViewBebidas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBebidas_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Producto";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Precio";
            this.columnHeader6.Width = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewPlatos);
            this.groupBox2.Location = new System.Drawing.Point(9, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platos";
            // 
            // listViewPlatos
            // 
            this.listViewPlatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewPlatos.Enabled = false;
            this.listViewPlatos.Location = new System.Drawing.Point(7, 21);
            this.listViewPlatos.Name = "listViewPlatos";
            this.listViewPlatos.Size = new System.Drawing.Size(217, 263);
            this.listViewPlatos.TabIndex = 0;
            this.listViewPlatos.UseCompatibleStateImageBehavior = false;
            this.listViewPlatos.View = System.Windows.Forms.View.Details;
            this.listViewPlatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListPlatos_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Producto";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 82;
            // 
            // cmbMesa
            // 
            this.cmbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Location = new System.Drawing.Point(57, 24);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(182, 24);
            this.cmbMesa.TabIndex = 2;
            this.cmbMesa.SelectedIndexChanged += new System.EventHandler(this.CmbMesa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesa: ";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(507, 162);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Almuerzos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(507, 162);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Desayunos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripProductos,
            this.toolStripSeparator2,
            this.toolStripMesas,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.toolStripSeparator6,
            this.toolStripLabel4,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProductos
            // 
            this.toolStripProductos.Name = "toolStripProductos";
            this.toolStripProductos.Size = new System.Drawing.Size(47, 22);
            this.toolStripProductos.Text = "Recetas";
            this.toolStripProductos.Click += new System.EventHandler(this.ShowProductos);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMesas
            // 
            this.toolStripMesas.Name = "toolStripMesas";
            this.toolStripMesas.Size = new System.Drawing.Size(96, 22);
            this.toolStripMesas.Text = "Mesas/secciones";
            this.toolStripMesas.Click += new System.EventHandler(this.ShowMesas);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Personal";
            this.toolStripLabel1.Click += new System.EventHandler(this.GestionPersonal);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel2.Text = "Inventario";
            this.toolStripLabel2.Click += new System.EventHandler(this.GestionInsumos);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel3.Text = "Settings";
            this.toolStripLabel3.Click += new System.EventHandler(this.SettingsShow);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel4.Text = "Clientes";
            this.toolStripLabel4.Click += new System.EventHandler(this.ClientesShow);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 720);
            this.panel1.TabIndex = 11;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewPedido;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewOtros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewEspeciales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewBebidas;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listViewPlatos;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader precio;
		private System.Windows.Forms.Label lblImpConsumo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblValorPagar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripProductos;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripMesas;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ComboBox cmbMesero;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameCliente;
        private System.Windows.Forms.Panel panel1;
    }
}