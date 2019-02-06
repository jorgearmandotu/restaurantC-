namespace restauran.views
{
    partial class InventarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioView));
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBajas = new System.Windows.Forms.RadioButton();
            this.btnExportarXls = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonEntradas = new System.Windows.Forms.RadioButton();
            this.radioButtonVentas = new System.Windows.Forms.RadioButton();
            this.btnPorFecha = new System.Windows.Forms.Button();
            this.dateTimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDetail
            // 
            this.listViewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDetail.Location = new System.Drawing.Point(3, 98);
            this.listViewDetail.Name = "listViewDetail";
            this.listViewDetail.Size = new System.Drawing.Size(905, 487);
            this.listViewDetail.TabIndex = 0;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBoxLoad);
            this.panel1.Controls.Add(this.radioButtonBajas);
            this.panel1.Controls.Add(this.btnExportarXls);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButtonEntradas);
            this.panel1.Controls.Add(this.radioButtonVentas);
            this.panel1.Controls.Add(this.btnPorFecha);
            this.panel1.Controls.Add(this.dateTimeFechaFin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeFechaInicio);
            this.panel1.Controls.Add(this.listViewDetail);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 593);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonBajas
            // 
            this.radioButtonBajas.AutoSize = true;
            this.radioButtonBajas.Location = new System.Drawing.Point(188, 18);
            this.radioButtonBajas.Name = "radioButtonBajas";
            this.radioButtonBajas.Size = new System.Drawing.Size(56, 19);
            this.radioButtonBajas.TabIndex = 13;
            this.radioButtonBajas.TabStop = true;
            this.radioButtonBajas.Text = "Bajas";
            this.radioButtonBajas.UseVisualStyleBackColor = true;
            // 
            // btnExportarXls
            // 
            this.btnExportarXls.Location = new System.Drawing.Point(530, 54);
            this.btnExportarXls.Name = "btnExportarXls";
            this.btnExportarXls.Size = new System.Drawing.Size(114, 23);
            this.btnExportarXls.TabIndex = 12;
            this.btnExportarXls.Text = "Exportar";
            this.btnExportarXls.UseVisualStyleBackColor = true;
            this.btnExportarXls.Click += new System.EventHandler(this.ExportarXls);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Estado actual del inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EstadoActuatStock);
            // 
            // radioButtonEntradas
            // 
            this.radioButtonEntradas.AutoSize = true;
            this.radioButtonEntradas.Location = new System.Drawing.Point(96, 18);
            this.radioButtonEntradas.Name = "radioButtonEntradas";
            this.radioButtonEntradas.Size = new System.Drawing.Size(74, 19);
            this.radioButtonEntradas.TabIndex = 10;
            this.radioButtonEntradas.TabStop = true;
            this.radioButtonEntradas.Text = "Entradas";
            this.radioButtonEntradas.UseVisualStyleBackColor = true;
            // 
            // radioButtonVentas
            // 
            this.radioButtonVentas.AutoSize = true;
            this.radioButtonVentas.Location = new System.Drawing.Point(14, 18);
            this.radioButtonVentas.Name = "radioButtonVentas";
            this.radioButtonVentas.Size = new System.Drawing.Size(62, 19);
            this.radioButtonVentas.TabIndex = 9;
            this.radioButtonVentas.TabStop = true;
            this.radioButtonVentas.Text = "Ventas";
            this.radioButtonVentas.UseVisualStyleBackColor = true;
            // 
            // btnPorFecha
            // 
            this.btnPorFecha.Location = new System.Drawing.Point(381, 54);
            this.btnPorFecha.Name = "btnPorFecha";
            this.btnPorFecha.Size = new System.Drawing.Size(75, 23);
            this.btnPorFecha.TabIndex = 7;
            this.btnPorFecha.Text = "Consultar";
            this.btnPorFecha.UseVisualStyleBackColor = true;
            this.btnPorFecha.Click += new System.EventHandler(this.ConsultXfecha);
            // 
            // dateTimeFechaFin
            // 
            this.dateTimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFin.Location = new System.Drawing.Point(597, 16);
            this.dateTimeFechaFin.Name = "dateTimeFechaFin";
            this.dateTimeFechaFin.Size = new System.Drawing.Size(134, 21);
            this.dateTimeFechaFin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(358, 16);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(134, 21);
            this.dateTimeFechaInicio.TabIndex = 2;
            this.dateTimeFechaInicio.Value = new System.DateTime(2019, 1, 21, 10, 55, 29, 0);
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.Enabled = false;
            this.pictureBoxLoad.Image = global::restauran.Properties.Resources.esperePorFavor;
            this.pictureBoxLoad.Location = new System.Drawing.Point(215, 155);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(500, 165);
            this.pictureBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoad.TabIndex = 14;
            this.pictureBoxLoad.TabStop = false;
            this.pictureBoxLoad.Visible = false;
            // 
            // InventarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "InventarioView";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPorFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonEntradas;
        private System.Windows.Forms.RadioButton radioButtonVentas;
        private System.Windows.Forms.RadioButton radioButtonBajas;
        private System.Windows.Forms.Button btnExportarXls;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
    }
}