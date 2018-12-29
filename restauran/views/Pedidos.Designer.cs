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
			this.mesa1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.mesa2 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			this.mesa1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mesa1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 326);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pedidos";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// mesa1
			// 
			this.mesa1.Controls.Add(this.tabPage1);
			this.mesa1.Controls.Add(this.mesa2);
			this.mesa1.Location = new System.Drawing.Point(6, 19);
			this.mesa1.Name = "mesa1";
			this.mesa1.SelectedIndex = 0;
			this.mesa1.Size = new System.Drawing.Size(753, 227);
			this.mesa1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tabControl2);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(745, 201);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "mesa1";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// mesa2
			// 
			this.mesa2.Location = new System.Drawing.Point(4, 22);
			this.mesa2.Name = "mesa2";
			this.mesa2.Padding = new System.Windows.Forms.Padding(3);
			this.mesa2.Size = new System.Drawing.Size(745, 201);
			this.mesa2.TabIndex = 1;
			this.mesa2.Text = "tabPage2";
			this.mesa2.UseVisualStyleBackColor = true;
			this.mesa2.Click += new System.EventHandler(this.mesa2_Click);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(7, 6);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(186, 192);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Location = new System.Drawing.Point(211, 7);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(515, 188);
			this.tabControl2.TabIndex = 1;
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
			// Pedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "Pedidos";
			this.Text = "Pedidos";
			this.groupBox1.ResumeLayout(false);
			this.mesa1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl mesa1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage mesa2;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ListView listView1;
	}
}