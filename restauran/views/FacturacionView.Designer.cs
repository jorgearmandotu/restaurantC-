namespace restauran.views
{
    partial class FacturacionView
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
            this.reportViewerFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerFactura
            // 
            this.reportViewerFactura.Location = new System.Drawing.Point(12, 12);
            this.reportViewerFactura.Name = "reportViewerFactura";
            this.reportViewerFactura.ServerReport.BearerToken = null;
            this.reportViewerFactura.Size = new System.Drawing.Size(981, 535);
            this.reportViewerFactura.TabIndex = 0;
            // 
            // FacturacionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 559);
            this.Controls.Add(this.reportViewerFactura);
            this.Name = "FacturacionView";
            this.Text = "FacturacionView";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFactura;
    }
}