namespace Tercera_Tarea_Prog_3
{
    partial class Buscar_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncerrar1 = new System.Windows.Forms.Button();
            this.BuscarEmpleado = new System.Windows.Forms.DataGridView();
            this.Cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtvalor1);
            this.groupBox2.Controls.Add(this.cmbbuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(226, 16);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(269, 20);
            this.txtvalor1.TabIndex = 3;
            this.txtvalor1.TextChanged += new System.EventHandler(this.txtvalor1_TextChanged);
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Items.AddRange(new object[] {
            "Codigo",
            "Cedula",
            "Nombre",
            "Apellidos"});
            this.cmbbuscar.Location = new System.Drawing.Point(66, 16);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbbuscar.TabIndex = 2;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.cmbbuscar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar Por";
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(145, 372);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // btncerrar1
            // 
            this.btncerrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar1.Location = new System.Drawing.Point(249, 372);
            this.btncerrar1.Name = "btncerrar1";
            this.btncerrar1.Size = new System.Drawing.Size(75, 23);
            this.btncerrar1.TabIndex = 2;
            this.btncerrar1.Text = "Cerrar";
            this.btncerrar1.UseVisualStyleBackColor = true;
            this.btncerrar1.Click += new System.EventHandler(this.btncerrar1_Click);
            // 
            // BuscarEmpleado
            // 
            this.BuscarEmpleado.AllowUserToAddRows = false;
            this.BuscarEmpleado.AllowUserToDeleteRows = false;
            this.BuscarEmpleado.AllowUserToResizeColumns = false;
            this.BuscarEmpleado.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscarEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_empleado,
            this.Cedula,
            this.Nombre,
            this.Apellidos});
            this.BuscarEmpleado.Location = new System.Drawing.Point(12, 69);
            this.BuscarEmpleado.Name = "BuscarEmpleado";
            this.BuscarEmpleado.ReadOnly = true;
            this.BuscarEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuscarEmpleado.Size = new System.Drawing.Size(501, 297);
            this.BuscarEmpleado.TabIndex = 3;
            this.BuscarEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BuscarEmpleado_CellDoubleClick);
            // 
            // Cod_empleado
            // 
            this.Cod_empleado.DataPropertyName = "Cod_empleado";
            this.Cod_empleado.HeaderText = "Cod";
            this.Cod_empleado.Name = "Cod_empleado";
            this.Cod_empleado.ReadOnly = true;
            this.Cod_empleado.Width = 50;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 160;
            // 
            // Buscar_Empleado
            // 
            this.ClientSize = new System.Drawing.Size(534, 410);
            this.Controls.Add(this.BuscarEmpleado);
            this.Controls.Add(this.btncerrar1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.groupBox2);
            this.Name = "Buscar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbuscarpor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacectar;
        private System.Windows.Forms.DataGridView ListaEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncerrar1;
        private System.Windows.Forms.DataGridView BuscarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
    }
}