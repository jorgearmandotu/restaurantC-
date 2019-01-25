﻿namespace restauran.views
{
    partial class PersonalView
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNameRetiro = new System.Windows.Forms.TextBox();
            this.txtCCDel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.txtMotivoRetiro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNameRetiro);
            this.groupBox3.Controls.Add(this.txtCCDel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnRetiro);
            this.groupBox3.Controls.Add(this.txtMotivoRetiro);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dateFechaSalida);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(7, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 170);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retiro de personal";
            // 
            // txtNameRetiro
            // 
            this.txtNameRetiro.Location = new System.Drawing.Point(413, 29);
            this.txtNameRetiro.Name = "txtNameRetiro";
            this.txtNameRetiro.Size = new System.Drawing.Size(233, 21);
            this.txtNameRetiro.TabIndex = 9;
            this.txtNameRetiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Invalidatekey);
            // 
            // txtCCDel
            // 
            this.txtCCDel.Location = new System.Drawing.Point(108, 30);
            this.txtCCDel.Name = "txtCCDel";
            this.txtCCDel.Size = new System.Drawing.Size(210, 21);
            this.txtCCDel.TabIndex = 8;
            this.txtCCDel.TabStop = false;
            this.txtCCDel.Leave += new System.EventHandler(this.ViewNametxt);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "FechaRetiro:";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(300, 119);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(87, 27);
            this.btnRetiro.TabIndex = 6;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.RetirarPersonal);
            // 
            // txtMotivoRetiro
            // 
            this.txtMotivoRetiro.Location = new System.Drawing.Point(108, 70);
            this.txtMotivoRetiro.Name = "txtMotivoRetiro";
            this.txtMotivoRetiro.Size = new System.Drawing.Size(210, 21);
            this.txtMotivoRetiro.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Causa Retiro:";
            // 
            // dateFechaSalida
            // 
            this.dateFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaSalida.Location = new System.Drawing.Point(413, 70);
            this.dateFechaSalida.Name = "dateFechaSalida";
            this.dateFechaSalida.Size = new System.Drawing.Size(233, 21);
            this.dateFechaSalida.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Identificacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.dateFechaIngreso);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOtros);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNumIdentificacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTipoId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 239);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Personal";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(300, 202);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 27);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.IngresarPersonal);
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaIngreso.Location = new System.Drawing.Point(112, 157);
            this.dateFechaIngreso.MinDate = new System.DateTime(2019, 1, 12, 0, 0, 0, 0);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(233, 21);
            this.dateFechaIngreso.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha Ingreso:";
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(69, 127);
            this.txtOtros.MaxLength = 254;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(580, 21);
            this.txtOtros.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Otros:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(451, 93);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 21);
            this.txtDireccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(451, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 21);
            this.txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 21);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtNumIdentificacion
            // 
            this.txtNumIdentificacion.Location = new System.Drawing.Point(451, 27);
            this.txtNumIdentificacion.Name = "txtNumIdentificacion";
            this.txtNumIdentificacion.Size = new System.Drawing.Size(198, 21);
            this.txtNumIdentificacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "N. Identificacion:";
            // 
            // txtTipoId
            // 
            this.txtTipoId.Location = new System.Drawing.Point(140, 21);
            this.txtTipoId.Name = "txtTipoId";
            this.txtTipoId.Size = new System.Drawing.Size(154, 21);
            this.txtTipoId.TabIndex = 1;
            this.txtTipoId.Text = "CC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "tipo de identificacion:";
            // 
            // PersonalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 479);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 518);
            this.MinimumSize = new System.Drawing.Size(732, 518);
            this.Name = "PersonalView";
            this.Text = "Gestion de Personal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumIdentificacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.TextBox txtMotivoRetiro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateFechaSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCCDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNameRetiro;
    }
}