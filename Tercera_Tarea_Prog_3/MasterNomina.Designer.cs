namespace Tercera_Tarea_Prog_3
{
    partial class MasterNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.grDatosEmpleados = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.txtcodempleado = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbus = new System.Windows.Forms.Button();
            this.dtdetallesnomina = new System.Windows.Forms.DataGridView();
            this.iddetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldobruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoneto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttotaldeducciones = new System.Windows.Forms.TextBox();
            this.txttotalnomina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cheprocesada = new System.Windows.Forms.CheckBox();
            this.lbcargo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grDatosEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdetallesnomina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(170, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(60, 23);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(64, 15);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtfecha
            // 
            this.txtfecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(840, 12);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // grDatosEmpleados
            // 
            this.grDatosEmpleados.Controls.Add(this.label4);
            this.grDatosEmpleados.Controls.Add(this.label3);
            this.grDatosEmpleados.Controls.Add(this.label2);
            this.grDatosEmpleados.Controls.Add(this.txtnombre);
            this.grDatosEmpleados.Controls.Add(this.txtsueldo);
            this.grDatosEmpleados.Controls.Add(this.txtcodempleado);
            this.grDatosEmpleados.Controls.Add(this.btnagregar);
            this.grDatosEmpleados.Controls.Add(this.btnbus);
            this.grDatosEmpleados.Enabled = false;
            this.grDatosEmpleados.Location = new System.Drawing.Point(13, 53);
            this.grDatosEmpleados.Name = "grDatosEmpleados";
            this.grDatosEmpleados.Size = new System.Drawing.Size(931, 55);
            this.grDatosEmpleados.TabIndex = 5;
            this.grDatosEmpleados.TabStop = false;
            this.grDatosEmpleados.Text = "Datos Empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Codigo";
            // 
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(288, 21);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(342, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtsueldo.Enabled = false;
            this.txtsueldo.Location = new System.Drawing.Point(691, 21);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 20);
            this.txtsueldo.TabIndex = 9;
            this.txtsueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtcodempleado
            // 
            this.txtcodempleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtcodempleado.Location = new System.Drawing.Point(51, 21);
            this.txtcodempleado.Name = "txtcodempleado";
            this.txtcodempleado.Size = new System.Drawing.Size(100, 20);
            this.txtcodempleado.TabIndex = 8;
            this.txtcodempleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            // 
            // btnagregar
            // 
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Location = new System.Drawing.Point(806, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbus
            // 
            this.btnbus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbus.Location = new System.Drawing.Point(157, 20);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(75, 23);
            this.btnbus.TabIndex = 5;
            this.btnbus.Text = "Buscar";
            this.btnbus.UseVisualStyleBackColor = true;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
            // 
            // dtdetallesnomina
            // 
            this.dtdetallesnomina.AllowUserToAddRows = false;
            this.dtdetallesnomina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdetallesnomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtdetallesnomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdetallesnomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalles,
            this.Cod,
            this.nombre,
            this.cargo,
            this.sueldobruto,
            this.ISR,
            this.SS,
            this.otros,
            this.deducciones,
            this.sueldoneto,
            this.Estatus});
            this.dtdetallesnomina.Location = new System.Drawing.Point(12, 149);
            this.dtdetallesnomina.Name = "dtdetallesnomina";
            this.dtdetallesnomina.ReadOnly = true;
            this.dtdetallesnomina.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtdetallesnomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtdetallesnomina.Size = new System.Drawing.Size(939, 217);
            this.dtdetallesnomina.TabIndex = 6;
            this.dtdetallesnomina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtdetallesnomina_KeyDown);
            // 
            // iddetalles
            // 
            this.iddetalles.DataPropertyName = "iddetalle";
            this.iddetalles.HeaderText = "Detalles";
            this.iddetalles.Name = "iddetalles";
            this.iddetalles.ReadOnly = true;
            this.iddetalles.Visible = false;
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "codempleado";
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 60;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 150;
            // 
            // sueldobruto
            // 
            this.sueldobruto.DataPropertyName = "sueldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.sueldobruto.DefaultCellStyle = dataGridViewCellStyle2;
            this.sueldobruto.HeaderText = "Sueldo Bruto";
            this.sueldobruto.Name = "sueldobruto";
            this.sueldobruto.ReadOnly = true;
            // 
            // ISR
            // 
            this.ISR.DataPropertyName = "IRS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.ISR.DefaultCellStyle = dataGridViewCellStyle3;
            this.ISR.HeaderText = "ISR";
            this.ISR.Name = "ISR";
            this.ISR.ReadOnly = true;
            this.ISR.Width = 70;
            // 
            // SS
            // 
            this.SS.DataPropertyName = "SS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.SS.DefaultCellStyle = dataGridViewCellStyle4;
            this.SS.HeaderText = "S.S";
            this.SS.Name = "SS";
            this.SS.ReadOnly = true;
            this.SS.Width = 70;
            // 
            // otros
            // 
            this.otros.DataPropertyName = "Otros";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.otros.DefaultCellStyle = dataGridViewCellStyle5;
            this.otros.HeaderText = "Otros";
            this.otros.Name = "otros";
            this.otros.ReadOnly = true;
            this.otros.Width = 70;
            // 
            // deducciones
            // 
            this.deducciones.DataPropertyName = "deducciones";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.deducciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.deducciones.HeaderText = "Deducciones";
            this.deducciones.Name = "deducciones";
            this.deducciones.ReadOnly = true;
            this.deducciones.Width = 80;
            // 
            // sueldoneto
            // 
            this.sueldoneto.DataPropertyName = "sueldoneto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.sueldoneto.DefaultCellStyle = dataGridViewCellStyle7;
            this.sueldoneto.HeaderText = "Sueldo Neto";
            this.sueldoneto.Name = "sueldoneto";
            this.sueldoneto.ReadOnly = true;
            this.sueldoneto.Width = 95;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Visible = false;
            // 
            // txttotal
            // 
            this.txttotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(12, 372);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(42, 20);
            this.txttotal.TabIndex = 10;
            // 
            // txttotaldeducciones
            // 
            this.txttotaldeducciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.txttotaldeducciones.Enabled = false;
            this.txttotaldeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldeducciones.Location = new System.Drawing.Point(787, 369);
            this.txttotaldeducciones.Name = "txttotaldeducciones";
            this.txttotaldeducciones.Size = new System.Drawing.Size(162, 26);
            this.txttotaldeducciones.TabIndex = 11;
            this.txttotaldeducciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotalnomina
            // 
            this.txttotalnomina.Cursor = System.Windows.Forms.Cursors.Default;
            this.txttotalnomina.Enabled = false;
            this.txttotalnomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalnomina.Location = new System.Drawing.Point(787, 430);
            this.txttotalnomina.Name = "txttotalnomina";
            this.txttotalnomina.Size = new System.Drawing.Size(162, 31);
            this.txttotalnomina.TabIndex = 12;
            this.txttotalnomina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalnomina.TextChanged += new System.EventHandler(this.txttotalnomina_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Registros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Deducciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(711, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Nomina";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Enabled = false;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(514, 464);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 68;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(638, 464);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 67;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.Enabled = false;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(390, 464);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 66;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Enabled = false;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(266, 464);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 65;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Location = new System.Drawing.Point(142, 464);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 64;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Detalles de Nomina";
            // 
            // cheprocesada
            // 
            this.cheprocesada.AutoSize = true;
            this.cheprocesada.Location = new System.Drawing.Point(863, 38);
            this.cheprocesada.Name = "cheprocesada";
            this.cheprocesada.Size = new System.Drawing.Size(77, 17);
            this.cheprocesada.TabIndex = 70;
            this.cheprocesada.Text = "Procesada";
            this.cheprocesada.UseVisualStyleBackColor = true;
            // 
            // lbcargo
            // 
            this.lbcargo.AutoSize = true;
            this.lbcargo.Location = new System.Drawing.Point(411, 37);
            this.lbcargo.Name = "lbcargo";
            this.lbcargo.Size = new System.Drawing.Size(0, 13);
            this.lbcargo.TabIndex = 71;
            this.lbcargo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(688, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Total Sueldo Neto";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtsueldoneto.Enabled = false;
            this.txtsueldoneto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsueldoneto.Location = new System.Drawing.Point(787, 399);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(162, 26);
            this.txtsueldoneto.TabIndex = 72;
            this.txtsueldoneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(362, 399);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 74;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // MasterNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(956, 495);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsueldoneto);
            this.Controls.Add(this.lbcargo);
            this.Controls.Add(this.cheprocesada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotalnomina);
            this.Controls.Add(this.txttotaldeducciones);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dtdetallesnomina);
            this.Controls.Add(this.grDatosEmpleados);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnbuscar);
            this.Name = "MasterNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterNomina";
            this.Load += new System.EventHandler(this.MasterNomina_Load);
            this.grDatosEmpleados.ResumeLayout(false);
            this.grDatosEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdetallesnomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox grDatosEmpleados;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.TextBox txtcodempleado;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txttotaldeducciones;
        private System.Windows.Forms.TextBox txttotalnomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cheprocesada;
        private System.Windows.Forms.Label lbcargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.DataGridView dtdetallesnomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldobruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SS;
        private System.Windows.Forms.DataGridViewTextBoxColumn otros;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoneto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Button btnImprimir;
    }
}