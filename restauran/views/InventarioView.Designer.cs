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
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPorFecha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDetail
            // 
            this.listViewDetail.Location = new System.Drawing.Point(3, 83);
            this.listViewDetail.Name = "listViewDetail";
            this.listViewDetail.Size = new System.Drawing.Size(449, 235);
            this.listViewDetail.TabIndex = 0;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPorFecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimeFechaFin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeFechaInicio);
            this.panel1.Controls.Add(this.listViewDetail);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 341);
            this.panel1.TabIndex = 2;
            // 
            // dateTimeFechaFin
            // 
            this.dateTimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFin.Location = new System.Drawing.Point(404, 16);
            this.dateTimeFechaFin.Name = "dateTimeFechaFin";
            this.dateTimeFechaFin.Size = new System.Drawing.Size(92, 20);
            this.dateTimeFechaFin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(214, 16);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(92, 20);
            this.dateTimeFechaInicio.TabIndex = 2;
            this.dateTimeFechaInicio.Value = new System.DateTime(2019, 1, 21, 10, 55, 29, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ventas por fecha";
            // 
            // btnPorFecha
            // 
            this.btnPorFecha.Location = new System.Drawing.Point(524, 16);
            this.btnPorFecha.Name = "btnPorFecha";
            this.btnPorFecha.Size = new System.Drawing.Size(75, 23);
            this.btnPorFecha.TabIndex = 7;
            this.btnPorFecha.Text = "Consultar";
            this.btnPorFecha.UseVisualStyleBackColor = true;
            this.btnPorFecha.Click += new System.EventHandler(this.ConsultXfecha);
            // 
            // InventarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "InventarioView";
            this.Text = "InventarioView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPorFecha;
    }
}