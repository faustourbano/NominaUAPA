namespace Tercera_Tarea_Prog_3
{
    partial class EmpleadoForm
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
            this.btncrear = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GruposDatos = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbosexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pictureEmpleado = new System.Windows.Forms.PictureBox();
            this.GrupoNomina = new System.Windows.Forms.GroupBox();
            this.cbocargo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.txtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.GruposDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleado)).BeginInit();
            this.GrupoNomina.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Location = new System.Drawing.Point(70, 365);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 33;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(394, 365);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 36;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Enabled = false;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(232, 365);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 35;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(151, 365);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 34;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(38, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 19;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtapellidos.Location = new System.Drawing.Point(60, 85);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(272, 20);
            this.txtapellidos.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cod.";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(141, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 51;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(434, 6);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 53;
            this.txtfecha.TextChanged += new System.EventHandler(this.txtfecha_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Fecha";
            // 
            // GruposDatos
            // 
            this.GruposDatos.Controls.Add(this.label8);
            this.GruposDatos.Controls.Add(this.lbedad);
            this.GruposDatos.Controls.Add(this.txttelefono);
            this.GruposDatos.Controls.Add(this.label11);
            this.GruposDatos.Controls.Add(this.label10);
            this.GruposDatos.Controls.Add(this.txtdireccion);
            this.GruposDatos.Controls.Add(this.txtfechanacimiento);
            this.GruposDatos.Controls.Add(this.label6);
            this.GruposDatos.Controls.Add(this.txtcedula);
            this.GruposDatos.Controls.Add(this.label9);
            this.GruposDatos.Controls.Add(this.cbosexo);
            this.GruposDatos.Controls.Add(this.label4);
            this.GruposDatos.Controls.Add(this.label2);
            this.GruposDatos.Controls.Add(this.txtnombre);
            this.GruposDatos.Controls.Add(this.txtapellidos);
            this.GruposDatos.Controls.Add(this.label3);
            this.GruposDatos.Enabled = false;
            this.GruposDatos.Location = new System.Drawing.Point(12, 61);
            this.GruposDatos.Name = "GruposDatos";
            this.GruposDatos.Size = new System.Drawing.Size(363, 200);
            this.GruposDatos.TabIndex = 54;
            this.GruposDatos.TabStop = false;
            this.GruposDatos.Text = "Datos Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Edad";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(223, 145);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(0, 13);
            this.lbedad.TabIndex = 56;
            this.lbedad.Click += new System.EventHandler(this.label8_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.Help;
            this.txttelefono.Location = new System.Drawing.Point(60, 138);
            this.txttelefono.Mask = "(999) 999-9999";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(121, 20);
            this.txttelefono.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtdireccion.Location = new System.Drawing.Point(64, 167);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(293, 20);
            this.txtdireccion.TabIndex = 52;
            // 
            // txtfechanacimiento
            // 
            this.txtfechanacimiento.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechanacimiento.Location = new System.Drawing.Point(226, 111);
            this.txtfechanacimiento.Name = "txtfechanacimiento";
            this.txtfechanacimiento.Size = new System.Drawing.Size(84, 20);
            this.txtfechanacimiento.TabIndex = 51;
            this.txtfechanacimiento.ValueChanged += new System.EventHandler(this.txtfechanacimiento_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Fecha Nac.";
            // 
            // txtcedula
            // 
            this.txtcedula.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtcedula.Location = new System.Drawing.Point(60, 29);
            this.txtcedula.Mask = "999-9999999-9";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(121, 20);
            this.txtcedula.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cedula";
            // 
            // cbosexo
            // 
            this.cbosexo.DisplayMember = "1";
            this.cbosexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo.FormattingEnabled = true;
            this.cbosexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cbosexo.Location = new System.Drawing.Point(60, 111);
            this.cbosexo.Name = "cbosexo";
            this.cbosexo.Size = new System.Drawing.Size(86, 21);
            this.cbosexo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtnombre.Location = new System.Drawing.Point(60, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(272, 20);
            this.txtnombre.TabIndex = 27;
            // 
            // pictureEmpleado
            // 
            this.pictureEmpleado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureEmpleado.Image = global::Tercera_Tarea_Prog_3.Properties.Resources.empleados_b;
            this.pictureEmpleado.Location = new System.Drawing.Point(381, 61);
            this.pictureEmpleado.Name = "pictureEmpleado";
            this.pictureEmpleado.Size = new System.Drawing.Size(148, 170);
            this.pictureEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEmpleado.TabIndex = 55;
            this.pictureEmpleado.TabStop = false;
            // 
            // GrupoNomina
            // 
            this.GrupoNomina.Controls.Add(this.btnnuevo);
            this.GrupoNomina.Controls.Add(this.cbocargo);
            this.GrupoNomina.Controls.Add(this.label12);
            this.GrupoNomina.Controls.Add(this.label5);
            this.GrupoNomina.Controls.Add(this.txtsueldo);
            this.GrupoNomina.Controls.Add(this.txtfechaingreso);
            this.GrupoNomina.Controls.Add(this.label7);
            this.GrupoNomina.Enabled = false;
            this.GrupoNomina.Location = new System.Drawing.Point(12, 267);
            this.GrupoNomina.Name = "GrupoNomina";
            this.GrupoNomina.Size = new System.Drawing.Size(522, 84);
            this.GrupoNomina.TabIndex = 56;
            this.GrupoNomina.TabStop = false;
            this.GrupoNomina.Text = "Datos Nomina";
            // 
            // cbocargo
            // 
            this.cbocargo.Cursor = System.Windows.Forms.Cursors.Help;
            this.cbocargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocargo.FormattingEnabled = true;
            this.cbocargo.Location = new System.Drawing.Point(55, 18);
            this.cbocargo.Name = "cbocargo";
            this.cbocargo.Size = new System.Drawing.Size(201, 21);
            this.cbocargo.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Sueldo";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtsueldo.Location = new System.Drawing.Point(55, 49);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(171, 20);
            this.txtsueldo.TabIndex = 53;
            // 
            // txtfechaingreso
            // 
            this.txtfechaingreso.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechaingreso.Location = new System.Drawing.Point(416, 18);
            this.txtfechaingreso.Name = "txtfechaingreso";
            this.txtfechaingreso.Size = new System.Drawing.Size(100, 20);
            this.txtfechaingreso.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Fecha Ingreso";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(313, 365);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 58;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(257, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 58;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // EmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GrupoNomina);
            this.Controls.Add(this.pictureEmpleado);
            this.Controls.Add(this.GruposDatos);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtid);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EmpleadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Empleado";
            this.GruposDatos.ResumeLayout(false);
            this.GruposDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpleado)).EndInit();
            this.GrupoNomina.ResumeLayout(false);
            this.GrupoNomina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox GruposDatos;
        private System.Windows.Forms.ComboBox cbosexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.DateTimePicker txtfechanacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtcedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureEmpleado;
        private System.Windows.Forms.GroupBox GrupoNomina;
        private System.Windows.Forms.ComboBox cbocargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.DateTimePicker txtfechaingreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnnuevo;
    }
}