namespace Tercera_Tarea_Prog_3
{
    partial class Buscar_Nomina
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
            this.buscarnomina = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalnomina1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.txtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarnomina)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarnomina
            // 
            this.buscarnomina.AllowUserToAddRows = false;
            this.buscarnomina.AllowUserToDeleteRows = false;
            this.buscarnomina.AllowUserToResizeColumns = false;
            this.buscarnomina.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buscarnomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buscarnomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarnomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.fecha,
            this.deducciones,
            this.SueldoNeto,
            this.totalnomina1,
            this.Estatus});
            this.buscarnomina.Location = new System.Drawing.Point(21, 72);
            this.buscarnomina.Name = "buscarnomina";
            this.buscarnomina.ReadOnly = true;
            this.buscarnomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscarnomina.Size = new System.Drawing.Size(577, 297);
            this.buscarnomina.TabIndex = 7;
            this.buscarnomina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buscarnomina_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_nomina";
            this.codigo.HeaderText = "Cod.";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 80;
            // 
            // deducciones
            // 
            this.deducciones.DataPropertyName = "totaldeducciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.deducciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.deducciones.HeaderText = "Deducciones";
            this.deducciones.Name = "deducciones";
            this.deducciones.ReadOnly = true;
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.DataPropertyName = "TotalSueldoNeto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.SueldoNeto.DefaultCellStyle = dataGridViewCellStyle4;
            this.SueldoNeto.HeaderText = "Sueldo Bruto";
            this.SueldoNeto.Name = "SueldoNeto";
            this.SueldoNeto.ReadOnly = true;
            this.SueldoNeto.Width = 120;
            // 
            // totalnomina1
            // 
            this.totalnomina1.DataPropertyName = "totalnomina";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.totalnomina1.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalnomina1.HeaderText = "Total Nomina";
            this.totalnomina1.Name = "totalnomina1";
            this.totalnomina1.ReadOnly = true;
            this.totalnomina1.Width = 120;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            this.Estatus.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmostrartodo);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.txtfechainicial);
            this.groupBox2.Controls.Add(this.txtfechafinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(469, 17);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(97, 23);
            this.btnmostrartodo.TabIndex = 55;
            this.btnmostrartodo.Text = "Mostrar Todos";
            this.btnmostrartodo.UseVisualStyleBackColor = true;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(388, 17);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 54;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtfechainicial
            // 
            this.txtfechainicial.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicial.Location = new System.Drawing.Point(91, 16);
            this.txtfechainicial.Name = "txtfechainicial";
            this.txtfechainicial.Size = new System.Drawing.Size(84, 20);
            this.txtfechainicial.TabIndex = 53;
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafinal.Location = new System.Drawing.Point(268, 16);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(84, 20);
            this.txtfechafinal.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Inicial";
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnaceptar.Location = new System.Drawing.Point(185, 378);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 5;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(289, 378);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Buscar_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(608, 413);
            this.Controls.Add(this.buscarnomina);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.groupBox2);
            this.Name = "Buscar_Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.buscarnomina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView buscarnomina;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker txtfechainicial;
        private System.Windows.Forms.DateTimePicker txtfechafinal;
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalnomina1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}